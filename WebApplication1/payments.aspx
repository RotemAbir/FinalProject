 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payments.aspx.cs" Inherits="WebApplication1.payments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

     <img class="secondary-logo" src="logo.jpg" />
        <div style="text-align:right">
               <h2>שלום מנהל יקר!</h2>
        <h3>בחר תנאים להצגת נתוני תשלומים של הדיירים</h3>
        </div>
          <div style="text-align:right">

               <asp:DropDownList ID="List" runat="server" >
       <asp:ListItem Value="All"> הכל</asp:ListItem>
            <asp:ListItem Value="Open"> לא שולם</asp:ListItem>
            <asp:ListItem Value="Closed"> שולם</asp:ListItem>
        </asp:DropDownList>

            <br />
            <br />

         <asp:Button ID="SelectButton"
          Text="לחץ לצפייה"
          OnClick="Button_Click"
          runat="server" />
        </div>

         <div style="text-align:right">
                  <asp:Table runat="server" ID="BulidingsTable" style="border:solid; margin-right: 50%; text-align:right">
              <asp:TableRow >
                  <asp:TableHeaderCell >ת.ז של הדייר</asp:TableHeaderCell>
                   <asp:TableHeaderCell >סיבת התשלום</asp:TableHeaderCell>
                  <asp:TableHeaderCell >סכום</asp:TableHeaderCell>
                  <asp:TableHeaderCell >סטאטוס</asp:TableHeaderCell>
                  
              </asp:TableRow>
         </asp:Table>

         </div>


    </div>
    </form>
</body>
</html>
