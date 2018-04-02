// Write your JavaScript code.
var div = $("#sss");
div.html("Yeahlolol");


function _userListing() {
    $.ajax({
        type: "GET",
        url: "Backoffice/_userListing",
        success: function (data) {
            $("#UserListingDiv").html(data);
        },
        error: function () {
            alert("Something is wrong");
        }
    });
}
function _saveAccountView() {
    $("#Modalform")[0].reset();
    $("#Modaltitle").html("Add new user");
    $.ajax({
        url: "Backoffice/_saveAccount",
        success: function (data) {
            $("#SubmitUserform").html(data);
        }
    });
}
function _saveAccount() {
    var data = $("#SubmitUserform").serialize();
    $.ajax({
        type: "POST",
        url: "Backoffice/_saveAccount",
        data: data,
        success: function (result) {
            _userListing();
            alert("Success");
            $("#Mymodal").modal("hide");
        },
        error: function () {
            alert("something is not workings");
        }
    });

}
function _editAccountView(AccID) {
    $("#Modalform")[0].reset();
    $("#Modaltitle").html("Edit user");
    $.ajax({
        type: "GET",
        url: "Backoffice/_editAccount",
        data: { AccId: AccID},
        success: function (data) {
            $("#SubmitUserform").html(data);
        }
    });
}

