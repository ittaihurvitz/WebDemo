<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="IttaiWebDemo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Registration</h2>
        <table>
            <tr>
                <td><label for="userName">User Name:</label></td>
                <td><input type="text" id="userName" name="userName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="firstName">First Name:</label></td>
                <td><input type="text" id="firstName" name="firstName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="lastName">last Name:</label></td>
                <td><input type="text" id="lastName" name="lastName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="password">Password:</label></td>
                <td><input type="password" id="password" name="password" value="" runat="server" required/></td>
            </tr>
            <tr>
                <td><label for="confirmPassword">Confirm Password:</label></td>
                <td><input type="password" id="password1" name="password" value=""/></td>
            </tr>
            <tr>
                <td><label for="gender">Gender:</label></td>
                <td><select id="gender" name="gender" required>
                    <option value="">Select...</option>
                    <option value="male">Male</option>
                    <option value="female">Female</option>
                    <option value="other">Other</option>
                </select></td>
            </tr>
        </table>

        <div style="margin:20px">
            <%--<button type="submit" onserverclick="registerButton_Click" onclick="return validateRegistration()" runat="server" >Register</button>--%>
            <asp:Button 
                ID="registerButton" 
                runat="server" 
                Text="Register" 
                OnClientClick="return validateRegistration();" 
                OnClick="registerButton_Click" />
        </div>
            
    </div>
    <div style="margin:40px" id="message" runat="server">Please register</div>
    <script src="validation.js"></script>

</asp:Content>
