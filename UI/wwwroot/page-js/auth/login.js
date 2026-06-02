'use strict';

(async ($) => {
    CloseInitLoader();
    $('#login-form').submit(async (e) => {
        e.preventDefault();
        startLoader();
        try {
            const form = $('#login-form');
            const form_data = new FormData(form[0]);

            const model = {
                phone: form_data.get('Phone'),
                password: form_data.get('Password')
            };
            console.log(model)
            const url = '/Auth/Login'
            const data = model;
            const config = {
                headers: {
                    'Content-Type': 'application/json; charset=UTF-8',
                    'RequestVerificationToken': VerifyToken
                }
            };
            const result = await SendPostRequest(url, data, config);
            if (result.isSuccess) {
                toastr["success"](result?.message);
                location.href = result.redirect;
            }
            else {
                //toastr["error"](result?.message);
                $('#errors-block').css("display", "block").html(result?.message);
            }
        }
        catch (err) {
            console.log(err)
            HandleCatchBlock(err);
        }
        finally { closeLoader(); }
    });
})(jQuery).catch(err => {
    console.error("err ::: ", err)
});