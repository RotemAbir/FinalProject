<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportingIssue.aspx.cs" Inherits="WebApplication1.ReportingIssue" %>

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

<h1 style="text-align:center">דיווח על תקלות</h1>

    <p >על מנת לדווח על תקלה מלאו את כל הפרטים בטופס הבא</p>

<div class="problem" >

        <p >מספר ת.ז של הדייר</p>
        <input type="text" id="tenant" style="margin-left:43%" class="input" required="required" runat="server" />

        <p >נושא הפניה</p>

        <asp:DropDownList ID="dropDown" runat="server" style="margin-left:43%">
            <asp:ListItem value="choose">בחר</asp:ListItem>
            <asp:ListItem value="cleaning">בעיית ניקיון</asp:ListItem>
            <asp:ListItem value="security">בעיית אבטחה</asp:ListItem>
            <asp:ListItem value="technical">בעיית תחזוקה</asp:ListItem>
             <asp:ListItem value="services">בעיית שירותים</asp:ListItem>
            <asp:ListItem value="other">אחר</asp:ListItem>
        </asp:DropDownList>

   <p>תאריך התקלה</p>
        <input type="text" runat="server" id="Odate" style="margin-left:43%" class="input" required="required"/>
    
        <p >פירוט התקלה</p>
       <input type="text"  runat="server" style="margin-left:38%; word-wrap: break-word" id="problemSummary" required="required" />
   <br />
  
</div>
        <asp:Button ID="Isuue" style="margin-left:48%"
          Text="שלח"
          OnClick="Button_Click"
          runat="server" />

    </div>

        

    </form>
</body>
</html>
