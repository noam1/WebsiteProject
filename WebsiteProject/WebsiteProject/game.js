
var index = 0;
var playing = true;
var started = false;

var startTime;

var solved = [];
var unsolved = [];

$(document).ready(function () {
    unsolved = raw;

    updateUI();
});

$(document).on("keypress", function (e) {

    if (!playing)
        return;

    var c = String.fromCharCode(e.which);

    if (!started)
    {
        started = true;
        startTimer();
    }

    if (c == clean[index])
        proceed();
    else
        failure();
});

function updateUI() {
    $("#solved").text(getSolved());
    $("#unsolved").text(getUnsolved());

    var delta = new Date() - startTime;

    if (delta)
        $("#timer").text(delta / 1000);
}

function proceed() {
    if (index < clean.length - 1)
    {
        solved.push(unsolved[0]);
        unsolved.splice(0, 1);

        index++;
    }
    else
    {
        solved.push(unsolved[0]);
        unsolved.splice(0, 1);

        success();
    }

    updateUI();
}

function startTimer() {

    startTime = new Date();
    setInterval(updateUI, 100);
}

function success() {
    playing = false;

    var delta = new Date() - startTime;
    clearInterval(updateUI);

    $("#state").attr("value", "success");
    $("#delta").attr("value", delta / 1000);
    $("#form1").attr("action", "End.aspx");

    $("#form1").submit();
}

function failure() {
    playing = false;

    var delta = new Date() - startTime;
    clearInterval(updateUI);

    $("#state").attr("value", "failure");
    $("#delta").attr("value", delta / 1000);
    $("#form1").attr("action", "End.aspx");

    $("#form1").submit();
}

function getUnsolved() {
    var result = '';

    for (var i = 0; i < unsolved.length; i++)
        result += unsolved[i];

    return result;
}

function getSolved() {
    var result = '';

    for (var i = 0; i < solved.length; i++)
        result += solved[i];

    return result;
}