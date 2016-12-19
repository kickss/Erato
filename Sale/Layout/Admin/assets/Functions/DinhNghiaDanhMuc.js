var ErrorCha = false;
var ErrorCon = false;
var ErrorUpdate = false;
var ErrorDelete = false;
var result = [];
var txtArrayCha = [];
var txtArrayCon = [];
var txtArrayUpdate1 = [];
var txtArrayUpdate2 = [];

txtArrayCha.push('txtMaQuyenCha', 'txtTenQuyenCha', 'txtSTTCha');
txtArrayCon.push('txtMaQuyenCon', 'txtTenQuyenCon', 'txtDuongDan', 'txtSTTCon', 'cmbMenuCha');
txtArrayUpdate1.push('txtTenQuyenUpd', 'txtDuongDanUpd', 'txtSTTUpd');
txtArrayUpdate2.push('txtTenQuyenUpd', 'txtSTTUpd');

function Get_Menu_Cha() {
    $.getJSON("/Admin/Get_Menu_Cha")
    .done(function (data) {
        $('#cmbMenuCha').empty();
        $.each(data, function (key, item) {
            // Add a list item for the product.
            $("<option value=" + item.QUYEN_ID + ">" + item.MAQUYEN + " </option>").appendTo($('#cmbMenuCha'));
        });
        $('#cmbMenuCha').selectpicker('refresh');
    });
}

function getMenuName(value) {
    var temp = value.split("*");
    return temp[1];
}

function INSERT_CHA() {
    ShowHideError(txtArrayCha);
    ErrorCha = ErrorBool(txtArrayCha);

    if (ErrorCha == true) {
        $('#loading').fadeIn();
        $.ajax({
            type: 'POST',
            url: '/Admin/DinhNghiaDanhMuc?t=' + Math.random(),
            data: {
                MAQUYEN: $('#txtMaQuyenCha').val(),
                TENQUYEN: $('#txtTenQuyenCha').val(),
                ENABLE: $("#chkEnableCha").is(":checked") ? 'True' : 'False',
                STT: $('#txtSTTCha').val(),
                LOAI: 'INSERT_CHA'
            },
            //async: true,
            dataType: 'text',
            success: function (html) {
                $('#loading').fadeOut();
                if (html == "...") {
                    $(':input')
                        .removeAttr('checked')
                        .removeAttr('selected')
                        .not(':button, :submit, :reset, :hidden, :radio, :checkbox')
                        .val('');
                    Get_Menu_Cha();
                    $('#grid_DS_MENU').data('kendoGrid').dataSource.read();
                    ShowAlert("Thông báo", 'Tạo Menu Cha thành công!');
                }
                else {
                    ShowAlert("Thông báo", html);
                }

            },
        })
        .fail(
            function (jqXHR, textStatus, err) {
                $('#loading').fadeOut();
                ShowAlert("Thông báo", err);
            });
    }
}

function INSERT_CON() {
    ShowHideError(txtArrayCon);
    ErrorCon = ErrorBool(txtArrayCon);

    if (ErrorCon == true) {
        $('#loading').fadeIn();
        $.ajax({
            type: 'POST',
            url: '/Admin/DinhNghiaDanhMuc?t=' + Math.random(),
            data: {
                MAQUYEN: $('#txtMaQuyenCon').val(),
                TENQUYEN: $('#txtTenQuyenCon').val(),
                ENABLE: $("#chkEnableCon").is(":checked") ? 'True' : 'False',
                DUONGDAN: $('#txtDuongDan').val(),
                QUYEN_CHA_ID: $('#cmbMenuCha').val(),
                STT: $('#txtSTTCon').val(),
                MA_QUYEN_CHA: $('#cmbMenuCha option:selected').text(),
                LOAI: 'INSERT_CON'
            },
            //async: true,
            dataType: 'text',
            success: function (html) {
                $('#loading').fadeOut();
                if (html == "...") {
                    $(':input')
                        .removeAttr('checked')
                        .removeAttr('selected')
                        .not(':button, :submit, :reset, :hidden, :radio, :checkbox')
                        .val('');
                    Get_Menu_Cha();
                    $('#grid_DS_MENU').data('kendoGrid').dataSource.read();
                    ShowAlert("Thông báo", 'Tạo Menu Con thành công!');
                }
                else {
                    ShowAlert("Thông báo", html);
                }

            },
        })
        .fail(
            function (jqXHR, textStatus, err) {
                $('#loading').fadeOut();
                ShowAlert("Thông báo", err);
            });
    }
}

function OnLoadGridMenu() {
    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                contentType: "application/json; charset=utf-8",
                url: "/Admin/Get_DS_Menu",
                type: 'GET',
                dataType: "json"
            }
        },
        pageSize: 100,
        schema: {
            model: {
                id: "QUYEN_ID",
                fields: {
                    QUYEN_ID: { type: "number", editable: false, nullable: true },
                    MAQUYEN: { type: "string", editable: true, nullable: true },
                    TENQUYEN: { type: "string", editable: true, nullable: true },
                    QUYEN_CHA_ID: { type: "number", editable: true, nullable: true },
                    MA_QUYEN_CHA: { type: "string", editable: true, nullable: true },
                    ENABLE: { type: "bool", editable: true, nullable: true },
                    DUONGDAN: { type: "string", editable: true, nullable: true },
                    STT: { editable: true, type: "number", validation: { min: 0 } }
                }
            }
        },
        group: [
            {
                field: "MA_QUYEN_CHA"
            }
        ]
    });

    $("#grid_DS_MENU").kendoGrid({
        dataSource: dataSource,
        noRecords: true,
        messages: {
            noRecords: "Không có Menu!"
        },
        columns: [
        {
            field: "QUYEN_ID",
            title: "MENU ID",
            width: 70,
            attributes: { class: "canhgiua" },
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            },
        },
        {
            field: "MAQUYEN",
            title: "MÃ MENU",
            width: 150,
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            },
            hidden: true
        },
        {
            field: "TENQUYEN",
            title: "TÊN MENU",
            width: 300,
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            }
        },
        {
            field: "ENABLE",
            title: "HIỂN THỊ",
            width: 70,
            attributes: { class: "canhgiua" },
            template: "<img src='../Layout/assets/img/" + "# if (ENABLE == true) { #" + "success.png" + "# } else { #" + "cancel.png" + "# } #" + "' style='width:25px;' />",
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            }
        },
        {
            field: "QUYEN_CHA_ID",
            title: "MÃ CHA",
            width: 150,
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            },
            hidden: true
        },
        {
            field: "MA_QUYEN_CHA",
            title: "MÃ MENU CHA",
            width: 150,
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            },
            groupHeaderTemplate: "#= getMenuName(value) #",
            hidden: true
        },
        {
            field: "DUONGDAN",
            title: "ĐƯỜNG DẪN",
            width: 250,
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            }
        },
        {
            field: "STT",
            title: "THỨ TỰ",
            width: 70,
            attributes: { class: "canhgiua" },
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            }
        },
        {
            width: 60,
            template: '<a onclick="ShowCapNhatMenu(\'#= QUYEN_ID #\');" class="btn btn-xs btn-info"><i class="ace-icon fa fa-edit bigger-40"></i> SỬA</a>',
            attributes: { class: "canhgiua" },
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;"
            }
        },
        {
            width: 60,
            template: '<a onclick="ShowXoaMenu(\'#= QUYEN_ID #\');" class="btn btn-xs btn-danger"><i class="ace-icon fa fa-trash bigger-40"></i> Xóa</a>',
            attributes: { class: "canhgiua" },
            headerAttributes: {
                style: "text-align: center; vertical-align: middle; font-weight:bold;",
            }
        }]
    }).data("kendoGrid");
}

function ShowCapNhatMenu(QUYEN_ID) {
    HideError(txtArrayUpdate1);
    var grid_data = $("#grid_DS_MENU").data("kendoGrid"),
    data = grid_data.dataSource.data();

    var res = $.grep(data, function (d) {
        return d.QUYEN_ID == QUYEN_ID;
    });

    $('#txtQuyenIdUpd').val(QUYEN_ID);
    $('#txtTenQuyenUpd').val(res[0].TENQUYEN);
    $('#txtDuongDanUpd').val(res[0].DUONGDAN);
    $('#txtSTTUpd').val(res[0].STT);

    if (res[0].ENABLE == true) {
        $('#chkEnableUpd').attr("checked", "checked");
    }
    else {
        $('#chkEnableUpd').removeAttr("checked");
    }

    if (res[0].QUYEN_CHA_ID == 0 || res[0].QUYEN_CHA_ID == "0") {
        $('#txtDuongDanUpd').attr("readonly", "true");
    }
    else {
        $('#txtDuongDanUpd').removeAttr("readonly");
    }
    $('#myModalSua').appendTo("body").modal('show');
}

function UpdateMenu() {
    var DuongDanUpd = document.getElementById('txtDuongDanUpd');
    if (DuongDanUpd.hasAttribute('readonly')) {
        ShowHideError(txtArrayUpdate2);
        ErrorUpdate = ErrorBool(txtArrayUpdate2);
    }
    else {
        ShowHideError(txtArrayUpdate1);
        ErrorUpdate = ErrorBool(txtArrayUpdate1);
    }

    if (ErrorUpdate == true) {
        $('#loading').fadeIn();
        $.ajax({
            type: 'POST',
            url: '/Admin/DinhNghiaDanhMuc?t=' + Math.random(),
            data: {
                QUYEN_ID: $('#txtQuyenIdUpd').val(),
                TENQUYEN: $('#txtTenQuyenUpd').val(),
                ENABLE: $("#chkEnableUpd").is(":checked") ? 'True' : 'False',
                STT: $('#txtSTTUpd').val(),
                DUONGDAN: $('#txtDuongDanUpd').val(),
                LOAI: 'UPDATE_MENU'
            },
            //async: true,
            dataType: 'text',
            success: function (html) {
                $('#loading').fadeOut();
                if (html == "...") {
                    Get_Menu_Cha();
                    $('#myModalSua').modal('hide');
                    $('#grid_DS_MENU').data('kendoGrid').dataSource.read();
                    IsSucess('myModalSua', 'Cập nhật thành công!');
                }
                else {
                    IsSucess('myModalSua', html);
                }

            },
        })
        .fail(
            function (jqXHR, textStatus, err) {
                $('#loading').fadeOut();
                ShowAlert("Thông báo", err);
            });
    }
}

function ShowXoaMenu(QUYEN_ID) {
    var grid_data = $("#grid_DS_MENU").data("kendoGrid"),
    data = grid_data.dataSource.data();

    var res = $.grep(data, function (d) {
        return d.QUYEN_ID == QUYEN_ID;
    });

    $('#QuyenChaIdDel').val(res[0].QUYEN_CHA_ID);
    $('#QuyenIdDel').val(QUYEN_ID);

    if (res[0].QUYEN_CHA_ID == 0 || res[0].QUYEN_CHA_ID == "0") {
        $('#alertxoa').text('Đây là Menu Cha ! Nếu xóa Menu Cha sẽ xóa Menu Con !');
    }
    else {
        $('#alertxoa').text('Bạn có muốn xóa Menu này?');
    }

    $('#myModalXoa').appendTo("body").modal('show');
}

function XoaMenu() {
    $('#myModalXoa').modal('hide');
    $('#loading').fadeIn();

    var QUYEN_CHA_ID = $('#QuyenChaIdDel').val();
    var QUYEN_ID = $('#QuyenIdDel').val();
    var LOAI = '';

    if (QUYEN_CHA_ID == 0 || QUYEN_CHA_ID == "0") {
        LOAI = 'XOA_MENU_CHA';
    }
    else {
        LOAI = 'XOA_MENU_CON';
    }

    $.ajax({
        type: 'POST',
        url: '/Admin/DinhNghiaDanhMuc?t=' + Math.random(),
        data: {
            QUYEN_ID: QUYEN_ID,
            LOAI: LOAI
        },
        //async: true,
        dataType: 'text',
        success: function (html) {
            $('#loading').fadeOut();
            if (html == "...") {
                $('#loading').fadeOut();
                Get_Menu_Cha();
                $('#grid_DS_MENU').data('kendoGrid').dataSource.read();
                IsSucess('myModalXoa', 'Xóa thành công!');
            }
            else {
                IsSucess('myModalXoa', html);
            }

        },
    })
    .fail(
        function (jqXHR, textStatus, err) {
            $('#loading').fadeOut();
            ShowAlert("Thông báo", err);
        });
}

$(function () {
    Get_Menu_Cha();

    $('.selectpicker').selectpicker({
        size: 10,
        liveSearchStyle: 'contains'
    });

    HideError(txtArrayCha);
    HideError(txtArrayCon);

    OnLoadGridMenu();
});