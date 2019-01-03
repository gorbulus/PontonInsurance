<%@ Page Title="AdminAgents" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminAgents.aspx.cs" Inherits="PontonInsurance.AdminAgents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--
    Filename: AgentForm.aspx
    Date: 3.21.18
    Author: William Ponton
    Description: aspx file for the AgentForm page.
    -->

    <div class="container">

        <!-- Welcome -->
        <div class="row">
            <div class="col-md-offset-3 col-md-8">
                <h1>Ponton Insurance Registered Agents</h1>
            </div>
        </div>

        <div class="row">
            <br />
        </div>

        <!-- Subheading -->
        <div class="row">
            <div class="col-md-offset-4 col-md-8">
                <h3>Administrative Maintenance Page</h3>
            </div>
        </div>

        <!-- Break Row -->
        <div class="row">
            <br />
        </div>


        <!-- Break Row -->
        <div class="row">
            <br />
        </div>

        <!-- Display -->
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <div class="label">
                    <asp:Label ID="lblDisplay" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>


        <!-- Agent Insert DetailsView -->
        <div class="row">
            <div class="col-md-6">
                <p>To create a new Agent, enter the Agent Info and click Insert.</p>
            </div>
            <asp:DetailsView ID="dvNewAgent" runat="server" Height="500px" Width="400px" 
                AutoGenerateRows="False" DataSourceID="odsAgentLocation"
                DefaultMode="Insert"
                OnItemInserted="dvNewAgent_ItemInserted"
                CssClass="table table-bordered table-condensed" >
                <Fields>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Agency" HeaderText="Agency" />
                    <asp:BoundField DataField="Certifications" HeaderText="Certifications" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Suite" HeaderText="Suite" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="State" HeaderText="State" />
                    <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
                    <asp:BoundField DataField="Licenses" HeaderText="Licenses" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <RowStyle CssClass="rowStyle" />
                <CommandRowStyle CssClass="commandRowStyle" />
            </asp:DetailsView>
        </div>

        <!-- Agent Data GridView -->
        <div class="table table-bordered table-striped table-condensed" onprerender="gvAgents_PreRender">
            <asp:GridView ID="gvAgentsEdit" runat="server" AutoGenerateColumns="False" AllowSorting="True"
                DataSourceID="odsAgentLocation"
                OnPreRender="gvAgents_PreRender"
                OnDeleted="odsAgentLocation_RowsDeleted"
                OnUpdated="odsAgentLocation_RowsUpdated">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Agency" HeaderText="Agency" />
                    <asp:BoundField DataField="Certifications" HeaderText="Certifications" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Suite" HeaderText="Suite" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="State" HeaderText="State" />
                    <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
                    <asp:BoundField DataField="Licenses" HeaderText="Licenses" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>

            <!-- Object Data Source odsAgentLocation -->
            <asp:ObjectDataSource ID="odsAgentLocation" runat="server"
                DataObjectTypeName="PontonInsurance.Models.AgentLocation"
                DeleteMethod="DeleteAgent"
                InsertMethod="InsertAgent"
                OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAllAgents"
                UpdateMethod="UpdateAgent"
                TypeName="PontonInsurance.Models.AgentDataAccessLayer"
                ConflictDetection="CompareAllValues"
                OnDeleted="odsAgentLocation_GetAffectedRows"
                OnUpdated="odsAgentLocation_GetAffectedRows">

                <UpdateParameters>
                    <asp:Parameter Name="original_Agent" Type="Object" />
                    <asp:Parameter Name="myAgent" Type="Object" />
                </UpdateParameters>

            </asp:ObjectDataSource>
            <br />
        </div>

        <!-- Break Row -->
        <div class="row">
            <br />
        </div>
        <!-- End container -->
    </div>
</asp:Content>
