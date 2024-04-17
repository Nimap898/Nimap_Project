<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="JQueryExample.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.7.1.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            $('#div1').html("Height = " + $('#img1').height() + "<br/>" + "Width = " + $('#img1').width() + "<br/>");
        });
    </script>
    

   <%-- <script type="text/javascript"> window.onload = function() {
    if (document.addEventListener) {
        document.getElementById('Button1').addEventListener('click', clickHandler,false);
    }
    else {
        document.getElementById('Button1').attachEvent('onclick', clickHandler);
    }
        };
        function clickHandler() {
            alert('jQuery Hello');
        }
    </script>--%>
</head>
<body>
<%--    <script type="text/javascript">
        jquery(document).ready(function () {
            jquery('#button1').click(function () {
                alert("hello jquery");
            });
        });
    </script>--%>

   <div id="div1"></div>
   <img id="img1" src="img.jpg" />

    <%--<input id="Button1" type="button" value="button" />--%>
</body>
</html>
