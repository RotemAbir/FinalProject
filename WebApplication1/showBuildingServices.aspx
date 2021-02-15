<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showBuildingServices.aspx.cs" Inherits="WebApplication1.showBuildingServices" %>

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
        <h3> בחר להציג את נותני השירות לפי נושא </h3>
        </div>
     
        <div style="text-align:right">

               <asp:DropDownList ID="List" runat="server" >
       <asp:ListItem Value="All"> הכל</asp:ListItem>
            <asp:ListItem Value="pool"> בריכה</asp:ListItem>
            <asp:ListItem Value="gym"> חדר כושר</asp:ListItem>
        <asp:ListItem Value="service"> תחזוקה</asp:ListItem>
            <asp:ListItem Value="security"> אבטחה</asp:ListItem>
        </asp:DropDownList>

            <br />
            <br />

         <asp:Button ID="SelectButton"
          Text="לחץ לצפייה"
          OnClick="Button_Click"
          runat="server" />
        </div>

         <div style=" margin-left:70%;">
                  <asp:Table runat="server" ID="BulidingsTable" style="border:solid; margin-right: 50%; text-align:right">
              <asp:TableRow >
                  <asp:TableHeaderCell >סוג השירות</asp:TableHeaderCell>
                  <asp:TableHeaderCell >תיאור השירות</asp:TableHeaderCell>
                  <asp:TableHeaderCell >מחיר</asp:TableHeaderCell>
                  <asp:TableHeaderCell >מזהה בניין</asp:TableHeaderCell>
               
                  
              </asp:TableRow>
         </asp:Table>

         </div>
       




    </div>
    </form>
</body>
</html>
