var homeController = function () {

    this.init = function () {

        registerEvent();
    }

 

    function registerEvent() {

     

        $('#loadJson').off('click').on('click',
            function () {
                $("#table").attr("hidden", false);

                loadData();
            });

        $('body').on('click',
            '#btnPost',
            function (e) {
                e.preventDefault();
                var fullName = $('#txtFullName').val();
                var gender = $('#txtGender').val();
                var username = $('#txtUsername').val();
                var password = $('#txtPassword').val();
                dataNewUser(fullName, gender, username, password);
            });


    }



    function loadData() {
        $.ajax({
            url: '/Api',
            type: 'GET',
            dataType: 'json',
            success: function (response) {

                var data = response;
                var html = '';
                var template = $('#data-template').html();
                $.each(data,
                    function (i, item) {
                        html += Mustache.render(template,
                            {
                                ID: item.Id,
                                FullName: item.FullName,
                                Gender: item.Gender
                            });

                    });
                $('#tblData').html(html);
            }
        });
    }


    function dataNewUser(fullName, gender, username, password) {

        var user = {
            FullName: fullName,
            Gender: gender,
            Username: username,
            Password: password
        }


        $.ajax({
            type: "POST",
            url: "/Api/PostUser",
            data: {
                users: JSON.stringify(user)

            },
            dataType: "json",
            success: function (response) {

                if (response != null) {
                    loadUser();
                    alert("Done!" + JSON.parse(this.responseText));
                } else {
                    alert("Something went wrong?");
                }
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });

    }

    function loadUser() {
        $.ajax({
            url: '/Api/GetUser',
            type: 'GET',
            dataType: 'json',
            success: function (response) {

                var data = response;
                var html = '';
                var template = $('#User-template').html();
                $.each(data,
                    function (i, item) {
                        html += Mustache.render(template,
                            {
                                FullName: item.Fullname,
                                Gender: item.Gender,
                                UserName: item.Username,
                                Password: item.Password
                            });

                    });
                setTimeout(loadUser(),1000 * 10);
                $('#UserData').html(html);
     
            }
        });
    }
    

}

