<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showAuthorizedPersonnel.aspx.cs" Inherits="WebApplication1.showAuthorizedPersonnel" %>

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
               <h2>שלום מנהל יקר!</h2>
        <p>כאן תוכל לראות את כל המבקרים בבניין</p>
        </div>
     
       <asp:DropDownList ID="List" runat="server" >
        
          <asp:Button ID="SelectButton"
          Text="לחץ לצפייה"
          OnClick="Button_Click"
          runat="server" />
        </div>




    </div>
    </form>
</body>
</html>
