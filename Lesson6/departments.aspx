<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="Lesson6.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Departments</h1>

    <a href="department.aspx">Add Department</a>

    <asp:GridView ID="grdDepartments" runat="server" CssClass="table table-striped table-hover" 
        AutoGenerateColumns="false" AllowSorting="true" OnSorting="grdDepartments_Sorting" DataKeyNames="DepartmentID">
    <Columns>
        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" SortExpression="DepartmentID" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Budget" HeaderText="Budget" DataFormatString="{0:C2}" />
        <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/department.aspx"
            DataNavigateUrlFields="DepartmentID" DataNavigateUrlFormatString="Department.aspx?DepartmentID={0}" />
        <asp:CommandField HeaderText="Delete" DeleteText="Delete" ShowDeleteButton="true" />

    </Columns>
</asp:GridView>
</asp:Content>
