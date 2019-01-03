<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QuoteInfo.aspx.cs" Inherits="PontonInsurance.QuoteInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- 
        Filename: QuoteInfo.aspx
        Date:     2.24.2018
        Author:   William Ponton
        Description:    The QuoteInfo.aspx page.
        -->

    <!-- Title -->
    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <div class="col-md-offset-2">
                    <h1>Quote Info</h1>
                </div>

                <!-- Instructions -->
                <div class="row">
                    <div class=" col-md-12">
                        <div class="col-md-12">
                            We need some more info for your quote.
                        </div>
                        <div class="col-md-12">
                            <asp:Label ID="lblCookie" runat="server" CssClass="display"></asp:Label>
                        </div>

                    </div>
                </div>

                <!-- Labels and Text Boxes -->
                <div class="form-horizontal">
                    <div class="col-md-offset-1 col-md-8">
                        <!-- Date of Birth -->
                        <div class="form-group">
                            <label class="label" for="txtDOB" runat="server">Date of Birth:</label>
                            <asp:TextBox ID="txtDOB" runat="server" CssClass="entry"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ErrorMessage="Date of Birth Required!" ControlToValidate="txtDOB" CssClass="warning" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revDOB" runat="server" ErrorMessage="Invalid DOB Format!" ControlToValidate="txtDOB" CssClass="warning" Display="Dynamic" Text="*" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$"></asp:RegularExpressionValidator>
                        </div>
                    </div>

                    <div class="form-horizontal">
                        <div class="col-md-offset-1 col-md-8">
                            <!-- Gender Drop Down List -->
                            <div class="form-group">
                                <label class="label" for="ddlGender">Gender:</label>
                                <asp:DropDownList ID="ddlGender" runat="server" CssClass="drop">
                                    <asp:ListItem>(Select)</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Millenial</asp:ListItem>
                                </asp:DropDownList>
                                <asp:CompareValidator ID="cvGender" runat="server" ErrorMessage="Must Choose Gender!" ControlToValidate="ddlGender" CssClass="warning" Display="Dynamic" Text="*" Operator="NotEqual" ValueToCompare="(Select)"></asp:CompareValidator>
                            </div>

                            <!-- DISPLAY -->
                            <div class="row col-offset-md-4  col-md-24">
                                <div class="col-md-16">
                                    <br />
                                    <asp:Label ID="lblDisplay" runat="server" Text="" CssClass="display"></asp:Label>
                                    <asp:Label ID="lblMessage" runat="server" Visible="false" Text="" CssClass="display"></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Validation Summary -->
                <div class="row">
                    <div class="col-md-offset-2 col-md-8">
                        <asp:ValidationSummary ID="vsQuoteInfo" runat="server" CssClass="error" />
                    </div>
                </div>

                <!-- BUTTONS -->
                <div class="form-horizontal">
                    <div class="row col-md-16">
                        <!-- Submit Button -->
                        <div class="col-md-3">
                            <div class="button">
                                <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit &raquo;" OnClick="btnSubmit_Click" />
                            </div>
                        </div>

                        <!-- Clear Button -->
                        <div class="col-md-3">
                            <div class="button">
                                <asp:Button ID="btnClear" class="btn btn-default" runat="server" Text="Clear &raquo;" OnClick="btnClear_Click" />
                            </div>
                        </div>

                        <!--  Cancel Button -->
                        <div class="col-md-3">
                            <div class="button">
                                <asp:Button ID="btnCancel" class="btn btn-default" runat="server" Text="Cancel &raquo;" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
