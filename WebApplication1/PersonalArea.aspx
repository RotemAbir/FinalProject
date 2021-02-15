<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalArea.aspx.cs" Inherits="WebApplication1.PersonalArea" %>

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
    </div>

        <div >
        <table class="tool-bar">
            <tr>
                <th> <a href="HTMLPage7.html"> בעלי מקצוע ואנשי שירות </a>  </th>
                <th> <a href="HTMLPage6.html"> תקנון ונהלים </a>  </th>
                <th> <a href="HTMLPage5.html"> הודעות </a>  </th>
                <th> <a href="HTMLPage4.html"> דיווח על תקלה </a> </th>
                <th> <a href="HTMLPage3.html"> דף בית</a> </th>
            </tr>
        </table>
            </div>
            <br />

            <div>
       <img id="user" src="user.png" />
       <h2 id="personal" style="margin-left:81%;">איזור אישי</h2>
   </div>

        
            <h3 style="text-align:right">פרטי דייר</h3>
           <p style="text-align:right">,שלום</p> <asp:label ID="Name"
            runat="server" style="margin-left:90%"/>
        
        <h3 style="text-align:right"> פרטי בניין</h3>
        <p style="text-align:right">מספר בניין</p><asp:label ID="Num"
            runat="server" style="margin-left:95%"/>
         <p style="text-align:right">מספר דירה</p><asp:label ID="Apt"
            runat="server" style="margin-left:95%"/>
         <p style="text-align:right">מספר קומה</p><asp:label ID="Floor"
            runat="server" style="margin-left:95%"/>

        <h3 style="margin-left:85%">היסטוריית תשלומים</h3>
        <asp:Button ID="SelectButton"
          Text="לחץ להצגת היסטוריית תשלומים"
          OnClick="Button_Click"
          runat="server" style="margin-left:85%" />

        <br />

         <asp:Table runat="server" ID="PaymentTable" style="border:solid; margin-left: 60%;">  </asp:Table>


         <h3 style="margin-left:85%">ביצוע תשלום</h3>
          <asp:Button ID="payment"
          Text="על מנת לבצע תשלום לחץ כאן"
          OnClick="Payment"
          runat="server" style="margin-left:85%" />

    </form>
</body>
</html>
