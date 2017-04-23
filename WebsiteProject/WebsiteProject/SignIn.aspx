<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebsiteProject.SignIn" %>

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

        <title>מרוץ הסת"ם - התחברות</title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div class="container">
                <div class="jumbotron" style="font-size: 65px;">
                    הגאולה קרבה! התחבר!
                </div>
            </div>
            <div class="container sign-form">
                <div class="well">
                    <h6 style="color: red;"> <%=errorMessage %> </h6> <br /><br />
                    שם משתמש
                    <input type="text" name="username" class="form-control" />
                    סיסמא
                    <input type="password" name="password" class="form-control" />
                    <br />

                    <div align="center">
                        <input type="submit" value="התחבר" class="btn btn-primary def-btn" />
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>
