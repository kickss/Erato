jQuery.fn.showLoading = function (msg) {
    msg = msg || '';
    jQuery(this).html('<img src="/Content/Images/ajax-loader.gif"> ' + msg).show();
}
jQuery.fn.hideLoading = function () { jQuery(this).hide(); }

function redirectTo(location) {
    window.location = location;
}
//Show Alert
function ShowAlert(title, messages) {
    $("#myAlert").modal();
    $("#h4Alert").html(title);
    $("#divContentAlert").html(messages);
}
//Xu ly ky tu ""
function string(html) {
    html = html.replace('"', '');
    html = html.replace('"', '');
    return html;
}
//Hiển thị tin nhắn
function Show(id) {
    $("#myModal").modal();
    $("#MessagesContent").load("/Home/Messages/" + id);
}

function Show(id) {
    $("#myModal").modal();
    $("#MessagesContent").load("/Home/Messages/" + id);
}