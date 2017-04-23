function validate()
{
    var fullName = $("#fullname").val();
    var username = $("#username").val();
    var email = $("email").val();

    var rabi = $('input[name=rabi]:checked', '#form1').val();
    var hateGoi = $('input[name=hate_goi]:checked', '#form1').val();

    if (fullName == '' || username == '' || rabi == undefined || hateGoi == undefined)
    {
        alert('אנא מלא את כל השדות');
        return false;
    }

    return true;
}