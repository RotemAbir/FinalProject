<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="WebApplication1.Messages" %>

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



    <div style="background-color:#FFFFDD;width:300px;margin-left:100px;"><a href="javascript:movedown()" style="margin-left:30px;font-size:20px;">Down</a>  <a href="javascript:moveup()" style="margin-left:30px;font-size:20px;">Up</a> 
<a href="javascript:stopscroll()" style="margin-left:30px;font-size:20px;">Stop</a>  <a href="javascript:movetop()" style="margin-left:30px;font-size:20px;">Top</a>
</div>

<script>

//specify speed of scroll (greater=faster)
var speed=1

iens6=document.all||document.getElementById
ns4=document.layers

if (iens6){
    document.write('<div id="container" style="position:relative;width:300px;height:200px;overflow:hidden;border:2px ridge white;margin-left:100px;">')
document.write('<div id="content" style="position:absolute;width:300px;left:0px;top:0px;">')
}
</script>

<ilayer name="nscontainer" width=300 height=200 clip="0,0,500,500">
<layer name="nscontent" width=300 height=200 visibility=hidden>

<!--INSERT CONTENT HERE-->
<p style="font-size:15px; text-align:center; font-family:Arial;">-24.10.18 <br /> הפסקת חשמל בין השעות 22:00 עד 7:00</p>
<p style="font-size:15px; text-align:center; font-family:Arial;">-23.10.28 <br />מאמן הכושר לא יגיע היום, עמכם הסליחה</p>
<p style="font-size:15px; text-align:center; font-family:Arial;"> הפסקת חשמל בתאריך 24.10.18 בין השעות 2</p>
<p style="font-size:15px; text-align:center; font-family:Arial;"> הפסקת חשמל בתאריך 24.10.18 בין השעות 2</p>
<p style="font-size:15px; text-align:center; font-family:Arial;"> הפסקת חשמל בתאריך 24.10.18 בין השעות 2</p>

<!--END CONTENT-->

</layer>
</ilayer>

<script>
if (iens6){
document.write('</div></div>')
var crossobj=document.getElementById? document.getElementById("content") : document.all.content
var contentheight=crossobj.offsetHeight
}
else if (ns4){
var crossobj=document.nscontainer.document.nscontent
var contentheight=crossobj.clip.height
}

function movedown(){
if (window.moveupvar) clearTimeout(moveupvar)
if (iens6&&parseInt(crossobj.style.top)>=(contentheight*(-1)+100))
crossobj.style.top=parseInt(crossobj.style.top)-speed+"px"
else if (ns4&&crossobj.top>=(contentheight*(-1)+100))
crossobj.top-=speed
movedownvar=setTimeout("movedown()",20)
}

function moveup(){
if (window.movedownvar) clearTimeout(movedownvar)
if (iens6&&parseInt(crossobj.style.top)<=0)
crossobj.style.top=parseInt(crossobj.style.top)+speed+"px"
else if (ns4&&crossobj.top<=0)
crossobj.top+=speed
moveupvar=setTimeout("moveup()",20)
}

function stopscroll() {
if (window.moveupvar) clearTimeout(moveupvar)
if (window.movedownvar) clearTimeout(movedownvar)

}

function movetop(){
stopscroll()
if (iens6)
crossobj.style.top=0+"px"
else if (ns4)
crossobj.top=0
}

function getcontent_height(){
if (iens6)
contentheight=crossobj.offsetHeight
else if (ns4)
document.nscontainer.document.nscontent.visibility="show"
}
window.onload=getcontent_height
</script>
    </div>
    </form>
</body>
</html>


