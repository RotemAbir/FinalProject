<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="StyleSheet1.css" />
</head>
<body id="body" style="text-align:center">
    <form id="form1" runat="server" >
    <div>
      <p>
        <a href="HTMLPage3.html"> לחץ לחזרה לדף הבית</a>
    </p>

    <div id="pic">
        <img id="img" src="avatar.png" />
    </div>

    <h4 class="first">כניסה לחשבון</h4>
    
        <div>
         
            <asp:TextBox ID="user" runat="server" style=" text-align:center;
    border-radius: 2px;
    transition: all 0.5s;
    box-shadow: none;
    border-color: #ddd;
    width: 150px;
    height: 15px;
    padding: 6px 12px;
    font-size: 14px;
    line-height: 1.42857143;
    color: #555;
    background-color: #fff;
    background-image: none;
    border: 1px solid #ccc;
    margin-left:3px;
    -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);">  </asp:TextBox>


                <br />
            <asp:TextBox ID="pass" runat="server" TextMode="password" style="text-align:center;
    border-radius: 2px;
    transition: all 0.5s;
    box-shadow: none;
    border-color: #ddd;
    width: 150px;
    height: 15px;
    padding: 6px 12px;
    font-size: 14px;
    line-height: 1.42857143;
    color: #555;
    background-color: #fff;
    background-image: none;
    border: 1px solid #ccc;
  
    -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);">  </asp:TextBox>

                 <br />
                <br />
                <br />

                 
         <asp:Button ID="loginButton" style="background: #1f73ba;
    line-height: normal;
    height:42px;
    width:200px;
    font-size:20px;
    color:#fcfdf0;"
          Text="Login"
          OnClick="Button_Click"
          runat="server"  />

            <br />
            זכור אותי <input type="checkbox" name="remember" value="remember" id="remember"/> <p>שכחתי סיסמא</p>
           
        </div>
        <asp:Label runat="server" ID="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
