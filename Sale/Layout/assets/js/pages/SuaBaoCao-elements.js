$(document).ready(function(){
	/* ---------- Datapicker ---------- */
    $('#dateNgayBC').datepicker(({
        todayBtn: "linked",
        language: "it",
        autoclose: true,
        todayHighlight: true,
        dateFormat: 'dd/mm/yy'
    }));

    /* ---------- DataRangepicker ---------- */
    $('#dateTuNgayDenNgay').daterangepicker();
});