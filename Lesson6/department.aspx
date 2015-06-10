<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="Lesson6.department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Department Details</h1>
    <h5>All fields are required</h5>

     <fieldset>
        <label for="txtDeptName">Department:</label>
        <asp:TextBox ID="txtDeptName" runat="server" required MaxLength="50" />
    </fieldset>
    <fieldset>
        <label for="txtBudget">Budget:</label>
        <asp:TextBox ID="txtBudget" runat="server" required TextMode="Number" />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Must be a number"
            ControlToValidate="txtBudget" CssClass="alert alert-danger" </asp:RangeValidator>
    </fieldset>

    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary"
             OnClick="btnSave_Click" />
    </div>


</asp:Content>
