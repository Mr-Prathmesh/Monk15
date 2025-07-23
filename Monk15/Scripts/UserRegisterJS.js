var SaveUserReg = function () {
    debugger;
    var first_name = $("#txtfname").val();
    var last_name = $("#txtlname").val();
    var username = $("#txtusername").val();
    var email = $("#txtemail").val();
    var password_hash = $("#pass").val();
    var role = $("#txtrole").val();
    var agreed_terms = $("#agreed_terms").val();

    var model =
    {
        first_name: first_name,
        last_name: last_name,
        username: username,
        email: email,
        password_hash: password_hash,
        role: role,
        agreed_terms: agreed_terms,

    };

    $.ajax({
        url: "/UserRegistration/SaveUserRegistration",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert(response.Message);
        }

    });

}
