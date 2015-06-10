<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="Lesson6.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Departments</h1>

    <a href="department.aspx">Add Department</a>

    <asp:GridView ID="grdDepartments" runat="server" CssClass="table table-striped table-hover" 
        AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Budget" HeaderText="Budget" />

    </Columns>
</asp:GridView>
</asp:Content>
