<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerAthorizedPersonnel.aspx.cs" Inherits="WebApplication1.registerAthorizedPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="StyleSheet1.css" />
</head>
<body id="body">
    <form id="form1" runat="server">
    <div>
    <img class="secondary-logo" src="logo.jpg" />
          <div style="text-align:right">
        <table class="tool-bar" runat="server">
            <tr>
                <th> <a href="HTMLPage2.html"> איזור אישי </a>  </th>
                <th> <a href="HTMLPage7.html"> בעלי מקצוע ואנשי שירות </a>  </th>
                <th> <a href="HTMLPage6.html"> תקנון ונהלים </a>  </th>
                <th> <a href="HTMLPage5.html"> הודעות </a>  </th>
                <th> <a href="HTMLPage3.html"> דף בית</a> </th>
            </tr>
        </table>
    </div>

            <h1 style="text-align:center">רישום אורחים</h1>
         <p >דייר יקר, על מנת לאפשר כניסה  לאורחים\אנשי שירות המגיעים אליך אנא מלא את הטופס הבא</p>

         <p >מספר ת.ז של המבקר</p>
        <input type="text" id="ID" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >שם פרטי של המבקר</p>
        <input type="text" id="fName" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >שם משפחה של המבקר</p>
        <input type="text" id="lName" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >מספר טלפון של המבקר</p>
        <input type="text" id="phone" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >מספר דירה</p>
        <input type="text" id="apt" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >תאריך ביקור</p>
        <input type="text" id="date" style="margin-left:43%" class="input" required="required" runat="server" />

         <p >מטרת הביקור</p>
        <input type="text" id="visit" style="margin-left:43%" class="input" required="required" runat="server" />

        <asp:Button ID="submit" style="margin-left:48%"
          Text="שלח"
          OnClick="Button_Click"
          runat="server" />



    </div>
    </form>
</body>
</html>
