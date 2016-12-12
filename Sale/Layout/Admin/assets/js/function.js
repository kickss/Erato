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
    $("#myAlert").appendTo("body").modal();
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

function ShowHideError(array) {
    for (i = 0; i < array.length ; i++) {
        if ($('#' + array[i]).val() == '' || $('#' + array[i]).val().length == 0) {
            $('#' + array[i] + '-error').fadeIn();
        }
        else {
            $('#' + array[i] + '-error').fadeOut();
        }
    }
}

function TestError(id) {
    if ($('#' + id).val() == '' || $('#' + id).val().length == 0) {
        $('#' + id + '-error').fadeIn();
    }
    else {
        $('#' + id + '-error').fadeOut();
    }
}

function ErrorBool(array) {
    var error = 0;
    for (i = 0; i < array.length ; i++) {
        if($('#' + array[i]).val() == '' || $('#' + array[i]).val().length == 0)
        {
            error++;
        }
    }

    if (error > 0) {
        return false;
    }
    else {
        return true;
    }
}

function HideError(array) {
    for (i = 0; i < array.length ; i++) {
        $('#' + array[i] + '-error').hide();
    }
}

function IsSucess(id, text) {
    if (text == '' || text.length == 0) {
        $('#' + id + '-IsSuccess').css({'color':'red','font-style':'italic'});
        $('#' + id + '-IsSuccess').text(text);
    }
    else {
        $('#' + id + '-IsSuccess').css({ 'color': 'green','font-style': 'italic' });
        $('#' + id + '-IsSuccess').text(text);
    }
}

