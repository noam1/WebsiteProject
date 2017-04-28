<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebsiteProject.Profile" %>

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

        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div class="container jumbotron">
                <h1> פרופיל </h1>
                <div class="left" style="display: inline;">
                    <input type="submit" name="play" value="התחל לשחק!" class="btn btn-success def-btn" style="margin: 10px" /> <br />
                    <input type="submit" name="disconnect" value="התנתק" class="btn btn-primary def-btn" style="margin: 10px" /><br /><br />

                    <input type="submit" name="delete" value="מחק משתמש" class="btn btn-danger def-btn" style="margin: 10px" /> <br />
                </div>
                
                <br /><br /><br />

                <h3> <label> שם בישראל: </label> </h3> <h4> <%=fullName %> </h4> <br /><br />
                <h3> <label> שם משתמש: </label> </h3> <h4> <%=username %> </h4> <br /><br />
                <h3> <label> סוכריות טופי: </label> </h3> <h4> <%=tofiCount %> </h4>  <br /><br />
                <h3> <label> דרגה: </label> </h3> <h4> <%=rank %> </h4> <br /> <br />

                <div style="margin-top: 10vh; font-size: 20px;">
                    <table align="center">
                        <tr>
                            <th> סטטיסטיקות משחק </th>
                        </tr>
                        <tr>
                            <td><u>הצלחה</u></td>
                            <td><%=successCount %></td>
                        </tr>
                        <tr>
                            <td><u>כשלון</u></td>
                            <td><%=failCount %></td>
                        </tr>
                        <tr>
                            <td><u>יחס הצלחה</u></td>
                            <td><%=ratio %>%</td>
                        </tr>
                    </table>
                </div>

                
            </div>
        </form>
    </body>
</html>
