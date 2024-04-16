<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumOfTwo.aspx.cs" Inherits="ExampleJavaScript.SumOfTwo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    function addNumbers() {

        firstNumber = document.getElementById("Text1").value;

        if(firstNumber == ""){
            alert("First Number is required");
        }
        //parseFloat to convert the string value to float Value  //parseInt to convert the string value to Int Value
        var firstNumber = parseFloat(firstNumber);
         if(isNaN(firstNumber)){
           alert("Please enter a valid number in first number textbox");
        }

        secondNumber = document.getElementById("Text2").value;
          if(secondNumber == ""){
           alert("Second Number is required");
        }

        var secondNumber = parseFloat(secondNumber);
        //isNaN Check to given input is number or not
        if(isNaN(secondNumber)){
            alert("Please enter a valid number in second number textbox ");
        }

        document.getElementById("Text3").value = firstNumber + secondNumber;
        
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 262px;
            margin-bottom: 0px;
        }

        .auto-style2 {
            width: 41%;
            height: 154px;
            margin-bottom: 41px;
        }

        .auto-style3 {
            height: 77px;
        }

        .auto-style4 {
            height: 76px;
        }

        .auto-style5 {
            height: 68px;
        }

        .auto-style6 {
            height: 80px;
        }
    </style>

</head>
<body>
    <table style="margin-right: 20px;" class="auto-style2">
        <tr>
            <td class="auto-style5">&nbsp;FirstNumber&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Text1" class="auto-style1" type="text" /></td>


        </tr>
        <tr>
            <td class="auto-style5">SecondNumber&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;
                <input id="Text2" class="auto-style1" type="text" /></td>


        </tr>
        <tr>
            <td class="auto-style3">&nbsp; Result&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <input id="Text3" class="auto-style1" type="text" /></td>

        </tr>
        <tr>
            <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Submit1" type="submit" value="submit" onclick="addNumbers()" />&nbsp;&nbsp; </td>

        </tr>
    </table>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</body>
</html>
