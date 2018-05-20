<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reverseString.aspx.cs" Inherits="ReverseStringWeb.reverseString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/main.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
    <title></title>
	<style type="text/css">
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div Class="color">
			 Enter a string to reverse!

        </div>
    	<p>
			<asp:TextBox ID="reversedInput" runat="server" OnTextChanged="reversedInput_TextChanged" Width="175px"></asp:TextBox>
        	<asp:Button ID="Button1" runat="server" Text="Reverse" OnClick="Button1_Click" />
        </p>
    	<p>

			<asp:Label ID="reversedOutput" runat="server" Text="" CssClass="newStyle1"></asp:Label>
		</p>
    </form>
</body>
</html>
