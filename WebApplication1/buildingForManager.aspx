<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buildingForManager.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="StyleSheet1.css" />
</head>
<script runat="server">


</script>

<body id="body">

    <img class="secondary-logo" src="logo.jpg" />

    <form id="choose" runat="server">
        
    <h3>שלום מנהל יקר!</h3>
        <h3>בחר מספר מזהה בניין </h3>
        
    

        <asp:DropDownList ID="List" runat="server">
            <asp:ListItem Value="1"> 1</asp:ListItem>
            <asp:ListItem Value="2"> 2</asp:ListItem>
        </asp:DropDownList>

       <br />
        <br />

        <asp:Button ID="SelectButton"
          Text="לחץ לקבלת רשימת דיירים"
          OnClick="Button_Click"
          runat="server" />

        
          <asp:Table runat="server" ID="BulidingsTable" style="border:solid; margin-right: 50%; text-align:right">
              <asp:TableRow >
                  <asp:TableHeaderCell >שם פרטי</asp:TableHeaderCell>
                  <asp:TableHeaderCell >שם משפחה</asp:TableHeaderCell>
                  <asp:TableHeaderCell >אימייל</asp:TableHeaderCell>
                  <asp:TableHeaderCell >מספר דירה</asp:TableHeaderCell>
                  <asp:TableHeaderCell >מספר בניין</asp:TableHeaderCell>
              </asp:TableRow>

         </asp:Table>
        
       


      &nbsp;&nbsp;
         <asp:Label ID="MessageLabel"
            runat="server" />
         
         <br />
        <br />

    </form>
</body>
</html>
