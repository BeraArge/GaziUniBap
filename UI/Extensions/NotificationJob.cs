using BusinessLogicLayer.Abstracts;

namespace UI.Extensions
{
    public class NotificationJob
    {
        private readonly IUserBL _userBL;
        private readonly IConfiguration _configuration;

        public NotificationJob(IUserBL userBL, IConfiguration configuration)
        {
            _userBL = userBL;
            _configuration = configuration;
        }



        public async Task SendGeneralReminder()
        {
            var message = GetRandomMessage(GeneralMessages);
            await SendToAllUsers("Genel Uyum ve Devamlılık", message);
        }
        private async Task SendToUsersExcept(
            string title ,
            string message,
            List<int> excludedUserIds)
        {
            var userList = _userBL.GetAllHasta();

            if (userList?.Data == null || userList.Data.Count == 0)
                return;

            var excludedSet = (excludedUserIds ?? new List<int>()).ToHashSet();

            var users = userList.Data
                .Where(x => !excludedSet.Contains(x.Id))
                .Where(x => !string.IsNullOrWhiteSpace(x.DeviceToken))
                .Where(x => Guid.TryParse(x.DeviceToken, out _))
                .ToList();

            foreach (var user in users)
            {
                await OneSignalHelper.SendToSubscriptionAsync(
                    user.DeviceToken!,
                    _configuration,
                    title,
                    message
                );
            }
        }

        private async Task SendToAllUsers(string title, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            var userList = _userBL.GetAllHasta();

            if (userList?.Data == null || userList.Data.Count == 0)
                return;

            var subscriptionIds = userList.Data
                .Select(x => x.DeviceToken)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Where(x => Guid.TryParse(x, out _))
                .Distinct()
                .ToList();

            if (subscriptionIds.Count == 0)
                return;

            foreach (var subId in subscriptionIds)
            {
                await OneSignalHelper.SendToSubscriptionAsync(
                    subId!,
                    _configuration,
                    title,
                    message
                );
            }
        }

        private static string GetRandomMessage(List<string> messages)
        {
            var index = Random.Shared.Next(messages.Count);
            return messages[index];
        }

        private static readonly List<string> GeneralMessages = new()
        {
            "Bugünkü bakımını tamamladın mı? Küçük hatırlatmalar büyük değişim yaratır.",
            "Rutinine bağlı kalman, sağlığını korumanın en güçlü yoludur.",
            "Her gün gösterdiğin özen, uzun vadeli koruma sağlar.",
            "İstikrarın en büyük sonucu: daha güçlü bir beden."
        };
    }
}