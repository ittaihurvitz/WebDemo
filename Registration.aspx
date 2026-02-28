<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Registration</h2>
        <table>
            <tr>
                <td><label for="userName">Name:</label></td>
                <td><input type="text" id="userName" name="userName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="familyName">family Name:</label></td>
                <td><input type="text" id="familyName" name="familyName" value="" runat="server" /></td>
            </tr>
        </table>

        <div style="margin:20px">
            <button type="submit" onclick="return validateRegistration()">Register</button>
        </div>
            
    </div>
    <div style="margin:40px" id="message" runat="server">Please register</div>
    <script src="validation.js"></script>

</asp:Content>
