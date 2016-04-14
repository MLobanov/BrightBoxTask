var Login = function (callback) {
    var html = '<div id="LoginDiv">Логин: <input id="Login"><br/>Пароль: <input id="Password" type="password"><br/><button id="btnLogin">Вход</button></div>'
    var loginForm = $(html);
    loginForm.find('#btnLogin').click(function () {
        $.getJSON('Login.ashx', { Login: $('#Login').val(), Password: $('#Password').val() }, function (response) {
            if (response.NeedAuth) alert('Неправильное имя пользователя или пароль')
            else if (response.ErrorMessage) alert(response.ErrorMessage);
            else if (response.Data) {
                loginForm.dialog("close")
                callback();
            }
        });
    });
    loginForm.dialog();
}