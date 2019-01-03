<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgentForm.aspx.cs" Inherits="PontonInsurance.AgentForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--
    Filename: AgentForm.aspx
    Date: 3.12.18
    Author: William Ponton
    Description: aspx file for the AgentForm page.
    -->

    <div class="container">

        <!-- Welcome -->
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Ponton Insurance Group Registered Agents</h1>
            </div>
        </div>

        <!-- Break Row -->
        <div class="row">
            <br />
        </div>

        <!-- Subheading -->
        <div class="row">
            <div class="col-md-offset-4 col-md-8">
                <h3>Find a representative near you.</h3>
            </div>
        </div>

        <!-- Break Row -->
        <div class="row">
            <br />
        </div>

        <!-- Agent Data -->
        <div class="table table-bordered table-striped table-condensed" onprerender="gvAgents_PreRender">
            <asp:GridView ID="gvAgents" runat="server" AutoGenerateColumns="False" DataSourceID="odsAgentLocation">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Agency" HeaderText="Agency" SortExpression="Agency" />
                    <asp:BoundField DataField="Certifications" HeaderText="Certifications" SortExpression="Certifications" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Suite" HeaderText="Suite" SortExpression="Suite" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
                    <asp:BoundField DataField="Licenses" HeaderText="Licenses" SortExpression="Licenses" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="odsAgentLocation" runat="server" SelectMethod="GetAllAgents" TypeName="PontonInsurance.Models.AgentDataAccessLayer" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
        </div>

        <!-- Break Row -->
        <div class="row">
            <br />
        </div>

    </div>
    <!-- End container -->
</asp:Content>
