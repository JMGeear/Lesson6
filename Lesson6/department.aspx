﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="Lesson6.department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Department Details</h1>
    <h5>All fields are required</h5>

     <fieldset>
        <label for="txtDeptName" class="col-sm-2">Department:</label>
        <asp:TextBox ID="txtDeptName" runat="server" required MaxLength="50" />
    </fieldset>
    <fieldset>
        <label for="txtBudget" class="col-sm-2">Budget:</label>
        <asp:TextBox ID="txtBudget" runat="server" required TextMode="Number" />
    </fieldset>

    <div class="col-sm-offset-2">
        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary"
             OnClick="btnSave_Click" />
    </div>


</asp:Content>
