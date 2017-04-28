<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="End.aspx.cs" Inherits="WebsiteProject.End" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

        <link rel="Stylesheet" href="http://fonts.googleapis.com/earlyaccess/alefhebrew.css" />

        <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
            integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css
            integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"
            integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

        <link rel="Stylesheet" href="main.css" />

        <title>סיום משחק</title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div class="container jumbotron">
                <div style="font-size: 75px;"><%=msg %></div> <br /><br />
                <div style="font-size: 40px;"><%=speech %></div> <br /> <br />
                <div style="font-size: 50px; text-align: center;"><%=prizeStr %></div> <br /> <br />

                <div style="font-size: 40px;"><%=bestTimeStr %></div>
                <div style="font-size: 40px;"><%=myTimeStr %></div> <br /><br />

                <div style="text-align: center;">
                    <a style="display: inline; margin: 10px;" class="btn btn-success def-btn" href="Game.aspx">משחק נוסף!</a> 
                    <a style="display: inline; margin: 10px;" class="btn btn-danger def-btn" href="Profile.aspx">חזרה לפרופיל</a>
                </div>
            </div>
        </form>
    </body>
</html>
