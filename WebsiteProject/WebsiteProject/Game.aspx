<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="WebsiteProject.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

        <link rel="Stylesheet" href="http://fonts.googleapis.com/earlyaccess/alefhebrew.css" />

        <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
            integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"
            integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"
            integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

        <link rel="Stylesheet" href="main.css" />
        <script> <%=script %> </script>
        <script src="game.js"></script>

        <title>מרוץ הסת"ם</title>
    </head>
    <body>
        <form id="form1" runat="server">
            
            <input id="state" name="state" type="hidden" value="failure" />
            <input id="delta" name="delta" type="hidden" />

            <div class="verse-div">
                <span id="verse" class="verse-centered">
                    <span id="solved" class="marked"></span><span id="unsolved" style="font-weight: bold;"></span>
                </span>
            </div>
            
            <a href="Profile.aspx" class="btn btn-danger def-btn" style="display: inline;"> חזרה לפרופיל </a>

            <span class="well timer-span">
                <div id="timer" class="timer-div">
                    0
                </div>
                <br />

            </span>

        </form>
    </body>
</html>
