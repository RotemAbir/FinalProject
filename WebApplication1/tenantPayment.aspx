<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tenantPayment.aspx.cs" Inherits="WebApplication1.WebForm2" %>

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

        <h1 style="text-align:center">ביצוע תשלום</h1>
         <p >על מנת לבצע תשלום מלאו את הפרטים בטופס</p>

        <div class="problem" >

             <p >מספר ת.ז של הדייר</p>
        <input type="text" id="tenant" style="margin-left:43%" class="input" required="required" runat="server" />
            <p >סיבת התשלום</p>
        <input type="text" id="reason" style="margin-left:43%" class="input" required="required" runat="server" />
              <p >סכום לתשלום</p>
        <input type="text" id="amount" style="margin-left:43%" class="input" required="required" runat="server" />
               <p >תאריך</p>
        <input type="text" id="date" style="margin-left:43%" class="input" required="required" runat="server" />
            <h3 style="margin-left:43%">פרטי תשלום</h3>
            <p >מספר אשראי</p>
             <%--<input type="text" id="creditNum" style="margin-left:43%" class="input" required="required" runat="server" TextMode="password"/>--%>
          <asp:TextBox runat="server" ID="credit" TextMode="password" style="margin-left:43%"></asp:TextBox>
                <p >תוקף</p>
             <input type="text" id="expDate" style="margin-left:43%" class="input" required="required" runat="server" />
              <p >3 ספרות בגב הכרטיס</p>
             <input type="text" id="CVV" style="margin-left:43%" class="input" required="required" runat="server" />

             <asp:Button ID="Isuue" style="margin-left:48%"
          Text="שלח"
          OnClick="Button_Click"
          runat="server" />

            </div>




    </div>
    </form>
</body>
</html>
