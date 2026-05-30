<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="LoginID.aspx.cs" Inherits="IttaiWebDemo.LoginID" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Login by ID number</h2>
        <table>
            <tr>
                <td><label for="ID Number">ID Number:</label></td>
                <td><input type="text" id="idNumber" name="idNumber" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="password">Password:</label></td>
                <td><input type="password" id="password" name="password" value="" runat="server" /></td>
            </tr>
        </table>

        <div style="margin:20px">
            <button type="submit" onclick="return validateLoginID()">Login</button>
        </div>
            
    </div>
    <div style="margin:40px" id="message" runat="server">Please login</div>
    <script src="validation.js"></script>
</asp:Content>
