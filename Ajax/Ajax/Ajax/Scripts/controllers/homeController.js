
var homeController = function (){

    this.init = function  () {
        
        registerEvent();
    }

     function registerEvent () {

         $('#loadJson').off('click').on('click', function () {
             loadData();
        });

    }
    
    function loadData () {
        $.ajax({
            url: '/Api/LoadData',
            type: 'GET',
            dataType: 'json',
            success: function(response) {
               
                    var data = response;
                    var html = '';
                    var template = $('#data-template').html();
                    $.each(data, function (i, item) {
                        html += Mustache.render(template,{
                                    ID: item.Id,
                                    FullName: item.FullName,
                                    Gender: item.Gender
                                  
                       });

                        });
                    $('#tblData').html(html);
                
            }
        });
    }

 
}
