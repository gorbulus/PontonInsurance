<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PontonInsurance._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--
    Filename: Default.aspx
    Date:     2.26.2018
        (Updated with Project 4  on 3.12.18)
    Author:   William Ponton
    Description:  The Default Page for Ponton Insurance  Group, LLC website.
    -->
    <!-- Welcome Info -->
    <div class="col-md-12">
        <p>
            The Ponton Insurance Group has always lived up to its name by being one step ahead of the insurance industry, 
            and finding new and affordable insurance solutions. We began in 1937 with the first drive-in claims office, 
            became the first to introduce reduced rates for low-risk drivers, and then changed the insurance shopping experience 
            by online tools for calculation and instant quoting.
            <br />
            <br />
            Ponton Group continues to find better ways to serve you with our personalized Quoting program and our legendary "uninsured" coverage.
        </p>
    </div>

    <!-- Button for ContactInfo Page -->
    <div class="row">
        <div class="col-md-4">
            <h2>Enter your Contact Info</h2>
            <p>
                Make a profile and save your contact info for next time.
            </p>
            <p>
                <asp:Button ID="btnContact" runat="server" Text="Contact Info &raquo;" class="btn btn-default" OnClick="btnContact_Click" />
            </p>
        </div>

        <!-- Button for QuoteInfo Page -->
        <div class="col-md-4">
            <h2>Create a Quote</h2>
            <p>
                To create a quote, we need your Contact Info first!
            </p>
            <p>
                <asp:Button ID="btnQuote" runat="server" class="btn btn-default" Text="Quote &raquo;" OnClick="btnQuote_Click" />
            </p>
        </div>

        <!-- Button for Agent Locations -->
        <div class="col-md-3">
            <h2>Agent Locations</h2>
            <p>
                Find a local representative.
            </p>
            <p>
                <asp:Button ID="btnAgents" runat="server" class="btn btn-default" Text="Agents &raquo;" OnClick="btnAgents_Click" />
            </p>
        </div>


        <!-- Button for GitHub -->
        <div class="row">
            <div class="col-md-4">
                <h2>GitHub</h2>
                <p>
                    Check out our Github!
                </p>
                <p>
                    <a class="btn btn-default" href="https://www.github.com">Github &raquo;</a>
                </p>
            </div>

            <div class="col-md-3">
                <asp:Label ID="lblSignIn" runat="server" Text="Sign In" Visible="false" CssClass="h2"></asp:Label>
                <br />
                <p>
                    <asp:Label ID="lblInstructions" runat="server" Text="Please sign in to view agents." Visible="false"></asp:Label>
                </p>
                <div class="form-group">
                    <div class="label">
                        <asp:Label ID="lblUserName" runat="server" Text="User Name: " Visible="False"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="entry" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ErrorMessage="User Name Required!" ControlToValidate="txtUserName" CssClass="warning" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <div class="label">
                        <asp:Label ID="lblPassword" runat="server" Text="Password: " Visible="False"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="entry" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Password Required!" ControlToValidate="txtUserName" CssClass="warning" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLogin" runat="server" Text="Login &raquo;" CssClass="btn btn-default" Visible="false" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
