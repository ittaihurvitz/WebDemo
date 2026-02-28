<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Login</h2>
        <table>
            <tr>
                <td><label for="userName">Name:</label></td>
                <td><input type="text" id="userName" name="userName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="password">Password:</label></td>
                <td><input type="password" id="password" name="password" value="" runat="server" /></td>
            </tr>
        </table>

        <div style="margin:20px">
            <button type="submit" onclick="return validateLogin()">Login</button>
        </div>
            
    </div>
    <div style="margin:40px" id="message" runat="server">Please login</div>
    <script src="validation.js"></script>
</asp:Content>
