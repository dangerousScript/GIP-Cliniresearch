﻿<%@ Page Title="" Language="C#" MasterPageFile="~/CliniresearchSite.Master" AutoEventWireup="true" CodeBehind="ContractPage.aspx.cs" Inherits="Presentation.Site.ContractPage" %>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
	<title>Client Contracts</title>
</asp:Content>

<asp:Content ID="Header" ContentPlaceHolderID="Header" runat="server">
	<div class="headLeft"><p class="uppercase">Client Contracts</p></div>
	<div class="headRight">
        <asp:LinkButton id="btnAdd" runat="server" OnClick="Add" ToolTip="Add one or more client(s)" ><i class="material-icons">add</i></asp:LinkButton>
        <asp:LinkButton id="btnEdit" runat="server" OnClick="Edit" Tooltip="Edit selected row(s)"><i class="material-icons">edit</i></asp:LinkButton>
        <asp:LinkButton id="btnDelete" runat="server" OnClick="Delete" ToolTip="Delete selected row(s)"><i class="material-icons">delete</i></asp:LinkButton>
	</div>
</asp:Content>

<asp:Content ID="Body" ContentPlaceHolderID="Body" runat="server">
    <asp:GridView ID="GridView" runat="server" AllowSorting="True" OnSorting="Sort" onrowdatabound="Gridview_RowDataBound" AutoGenerateColumns="False" DataKeyNames="Contract_ID">
        <Columns>
            <asp:TemplateField ShowHeader="false" HeaderStyle-Width="50px" >
                <ItemTemplate>
                    <label class="container">
                        <asp:CheckBox ID="CheckBox" runat="server" />
                        <span class="checkmark"></span>
                    </label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Legal_country" HeaderText="Legal Country" SortExpression="Legal_country" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader"/>
            <asp:BoundField DataField="Fee" HeaderText="Fee" SortExpression="Fee" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader"/>
            <asp:BoundField DataField="Start_Date" HeaderText="Start Date" SortExpression="Start_Date" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader"/>
            <asp:BoundField DataField="End_Date" HeaderText="End Date" SortExpression="End_Date" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader"/>
            <asp:TemplateField HeaderText="Project" SortExpression="Project_ID" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader">
                <ItemTemplate>
                    <asp:Label ID="lbProject" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Client" SortExpression="Client_ID" HeaderStyle-ForeColor="Black" HeaderStyle-CssClass="viewHeader">
                <ItemTemplate>
                    <asp:Label ID="lbClient" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>