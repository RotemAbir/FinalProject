<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createTenant.aspx.cs" Inherits="WebApplication1.createTenant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="StyleSheet1.css" />
</head>
<body id="body">
    <form id="form1" runat="server">
    <div>
     <h1 style="text-align:center">יצירת משתמש לדייר</h1>

        <p >מספר ת.ז של הדייר</p>
        <input type="text" id="tenant" style="margin-left:43%" class="input" required="required" runat="server" />
         <p >סיסמא</p>
        <input type="text" id="pass" style="margin-left:43%" class="input" required="required" runat="server" />
         <p >שם פרטי של הדייר</p>
        <input type="text" id="fName" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >שם משפחה של הדייר</p>
        <input type="text" id="lName" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >מספר טלפון</p>
        <input type="text" id="phone" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >אימייל</p>
        <input type="text" id="email" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >מספר דירה</p>
        <input type="text" id="apt" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >קומה</p>
        <input type="text" id="floor" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >מספר חדרים</p>
        <input type="text" id="rooms" style="margin-left:43%" class="input" required="required" runat="server" />
        <p >סמן אם הדייר הוא בעל הדירה</p>
        <input type="checkbox" id="owner" style="margin-left:43%" class="input" runat="server" />
         <p >בניין</p>
        <input type="text" id="build" style="margin-left:43%" class="input" required="required" runat="server" />


        
             <asp:Button ID="Isuue" style="margin-left:48%"
          Text="לחץ ליצירת דייר"
          OnClick="Button_Click"
          runat="server" />



    </div>
    </form>
</body>
</html>
