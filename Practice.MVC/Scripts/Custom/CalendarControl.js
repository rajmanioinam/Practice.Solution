$(document).ready(function () {
    $('input[type=datetime]').datepicker(
        {
        dateFormat: "MM/dd/yyyy",
        changeMonth: true,
        changeYear: true,
        yearRange: "-60:+0"
        }
    );
});