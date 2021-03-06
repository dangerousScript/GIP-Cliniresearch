﻿<%@ Page Title="" Language="C#" MasterPageFile="/MasterPage2.0.Master" AutoEventWireup="true" CodeBehind="HospitalPage.aspx.cs" Inherits="Presentation.Site.HospitalPage" %>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
	<title>Hospitals</title>
</asp:Content>

<asp:Content ID="Form" ContentPlaceHolderID="Form" runat="server">
    <div class="view-page">
    <div class="form">
        <h2>Hospitals</h2>
        <hr />
        <div class="gridview">
            <asp:GridView ID="GridView" runat="server" AllowSorting="True" OnSorting="Sort" onrowdatabound="Gridview_RowDataBound" AutoGenerateColumns="False" DataKeyNames="Hospital_ID" CssClass="gv">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"/>
                    <asp:BoundField DataField="Adress" HeaderText="Adress" SortExpression="Adress"/>
                    <asp:BoundField DataField="Postal_Code" HeaderText="Postal Code" SortExpression="Postal_Code"/>
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"/>
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"/>
                    <asp:BoundField DataField="Central_number" HeaderText="Central Number" SortExpression="Central_Number"/>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </div>
</asp:Content>