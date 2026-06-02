using BusinessLogicLayer.Abstracts;
using DataTransferObject.Notification;
using Microsoft.AspNetCore.Mvc;
using UI.Extensions;

namespace UI.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationBL _notificationBL;
        private readonly IUserBL _userBL;
        private readonly IConfiguration _configuration;

        public NotificationController(
            INotificationBL notificationBL,
            IUserBL userBL,
            IConfiguration configuration)
        {
            _notificationBL = notificationBL;
            _userBL = userBL;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NotificationGetAll()
        {
            var result = _notificationBL.GetAllNotification();
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> NotificationSend([FromBody] NotificationDTO model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Message))
            {
                return Json(new
                {
                    success = false,
                    message = "Bildirim mesajı boş olamaz."
                });
            }

            model.Message = model.Message.Trim();

            var userList = _userBL.GetAllHasta();

            if (userList?.Data == null || userList.Data.Count == 0)
            {
                return Json(new
                {
                    success = false,
                    message = "Bildirim gönderilecek kullanıcı bulunamadı."
                });
            }

            var subscriptionIds = userList.Data
                .Select(x => x.DeviceToken)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Where(x => Guid.TryParse(x, out _))
                .Distinct()
                .ToList();

            if (subscriptionIds.Count == 0)
            {
                return Json(new
                {
                    success = false,
                    message = "Kayıtlı kullanıcı cihazı bulunamadı."
                });
            }

            int successCount = 0;
            int failCount = 0;

            foreach (var subId in subscriptionIds)
            {
                var sendResult = await OneSignalHelper.SendToSubscriptionAsync(
                    subId!,
                    _configuration,
                    "Yeni Bildirim",
                    model.Message
                );

                if (sendResult.ok)
                    successCount++;
                else
                    failCount++;
                Console.WriteLine(sendResult.errorBody);
            }

            if (successCount == 0)
            {
                return Json(new
                {
                    success = false,
                    message = $"Bildirim hiçbir kullanıcıya gönderilemedi. Başarılı: {successCount}, Başarısız: {failCount}. Kayıt oluşturulmadı."
                });
            }

            var addResult = _notificationBL.Add(model);

            if (!addResult.IsSuccess)
            {
                return Json(new
                {
                    success = false,
                    message = "Bildirim gönderildi fakat veritabanına kaydedilemedi."
                });
            }

            return Json(new
            {
                success = true,
                message = $"Bildirim gönderildi ve kaydedildi. Başarılı: {successCount}, Başarısız: {failCount}"
            });
        }
    }
}