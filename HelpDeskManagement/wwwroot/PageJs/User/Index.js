
$(document).ready(function () {

    $("#btnSave").click(function () {

        var user;
        user = {
            "UserName": $("#UserNameInput").val(),
            "Email": $("#").val(),
            "Address": $("#").val(),
            "Contact": $("#").val(),
            "Password": $("#").val(),
            "HintQue": $("#").val(),
            "HintAns": $("#").val(),
            "UserTypeId": $("#").val()
        }

        $.ajax({
            url: "/User/saveUser",
            method: "POST",      // The HTTP method to use for the request
            dataType: "json",   // The type of data that you're exerciseecting back 	
            data: user,
            success: function (response) {

                console.log("Response : " + response);
            },
            error: function () {

                // A function to be called if the request fails.					
            }
        });​

    });



});


