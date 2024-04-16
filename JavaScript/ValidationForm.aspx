<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationForm.aspx.cs" Inherits="JavaScriptBasicExample2.ValidationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function GetFullName() {
            var firstName = document.getElementById("Text1").value;
            var secondName = document.getElementById("Text2").value;

            document.getElementById("Text3").value = firstName + secondName;
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FirstName:<input id="Text1" type="text" />
        </div>
        <p>
            LastName:<input id="Text2" class="auto-style1" type="text" />
        </p>
        Result<input id="Text3" type="text" /></form>
    <p>
        <input id="Button1" type="button" value="button" onclick="GetFullName()"/></p>
    <p>
        &nbsp;
    </p>
</body>
</html>
