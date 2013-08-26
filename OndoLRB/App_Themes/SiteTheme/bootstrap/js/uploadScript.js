//Handle survey plan uploads
//expects a single copy
var lrb = {};

lrb.UploadHandler = function (ctrl_name, ctrl_value) {
    return {
        replaceFileInput: true,
        dataType: 'json',
        url: 'AjaxUploadHandler.ashx',
        formData: function (form) {
            return [{
                //pass the variable names for the survey plan
                name: ctrl_name,
                value: ctrl_value
            }];
        },
        done: function (e, data) {
            $.each(data.result, function (index, file) {
                Console.log(file);
                $("</p>").text(file + " has been uploaded successfully.").addClass("alert alert-success").appendTo('#result')//.css("alert");
            });
        },
        progressall: function (e, data) {
            var progress = parseInt(data.loaded / data.total * 100, 10);
            $('#progress .bar').css(
                'width',
                progress + '%'
            );
        }
    }
}

$("#surveyPlan").fileupload(lrb.UploadHandler("surveyPlan", "surveyPlan"));
$("#devLevyReciepts").fileupload(lrb.UploadHandler("devLevyReciepts", "Development Levy Receipts"));
$("#passport").fileupload(lrb.UploadHandler("passport", "Pasport Picture"));




/*
* The following functions handle file uploads from the corporate organization upload page
*/

//Registration Certificates

$("#regCert").fileupload(lrb.UploadHandler("regCert", "Registration Certificates"));
$("#levyReciepts").fileupload(lrb.UploadHandler("levyReciepts", "Registration Certificates"));
