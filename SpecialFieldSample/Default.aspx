<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpecialFieldSample.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div data-detail="UserPort" data-method="edit">
        <table>
            <tr>
                <td>Username</td>
                <td data-field="UserPort.Username"></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><input type="text" data-field="UserPort.Password" /></td>
            </tr>
        </table>
        <input type="button" onclick="EditPort('UserPort')" value="Submit" />
    </div>
    <script>
        Detail.UserPort = "admin";
        DetailEvents.UserPort.onEdited = function () {
            location.reload();
        }
    </script>
</asp:Content>
