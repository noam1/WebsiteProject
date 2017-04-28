<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebsiteProject.SignUp" %>

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
        <script src="signUp.js"></script>

        <title>מרוץ הסת"ם - הרשמה</title>
    </head>

    <body>
        <form id="form1" runat="server" onsubmit="return validate();">
            <div class="container">
                <div class="jumbotron" style="font-size: 65px;">
                    הירשם צדיק!
                </div>
            </div>

            <div class="container sign-form">
                <div class="well">
                    <h5 style="color: red;"> <%=errorMessage %> </h5><br /><br />

                    שם בישראל
                    <input type="text" name="fullname" class="form-control" id="fullname" />
                    שם משתמש
                    <input type="text" name="username" class="form-control" id="username" />
                    סיסמא
                    <input type="password" name="password" class="form-control" id="password" />
                    אי-מייל
                    <input type="email" name="email" class="form-control" id="email" /> <br />

                    <u> רב אהוב </u> <br />
                    <fieldset id="rabi">
                        <div style="display: inline-block; margin: 10px">
                            <input type="radio" name="rabi" value="ovadia"  id="ovadia" />
                            <label for="ovadia"> עובדיה יוסף </label> <br />
                            <img src="ovadya.jpg" width="150px" height="150px" />
                        </div>
                        
                        <div style="display: inline-block; margin: 10px">
                            <input type="radio" name="rabi" value="milubavic" id="milubavic" />
                            <label for="milubavic"> הרבי מילובביץ </label> <br />
                            <img src="milubavic.jpg" width="150px" height="150px" />
                        </div>
                    </fieldset>
                    <br />
                    
                    <u> האם אתה שונא גויים? </u>
                    <fieldset id="goi_question">
                        <input type="radio" name="hate_goi" value="yes" id="yes" />
                        <label for="yes"> כן </label>

                        <input type="radio" name="hate_goi" value="no" id="no" />
                        <label for="no"> לא </label>
                    </fieldset>

                    <div align="center">
                        <input type="submit" class="btn btn-primary def-btn" value="שלח עוד היום!" />
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>
