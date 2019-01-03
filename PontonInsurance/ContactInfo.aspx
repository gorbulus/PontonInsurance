<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactInfo.aspx.cs" Inherits="PontonInsurance.ContactInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--
    Filename: ContactInfo.aspx
    Date:     2.24.2018
    Author:   William Ponton
    Description:    The ContactInfo aspx page for entering in user contact information.
    -->
     <!-- Contact Info Page Heading -->
    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <div class="col-md-offset-1">
                    <h1>Contact Information</h1>
                </div>
            </div>
        </div>

        <!-- Instructions -->
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <div class="col-md-offset-2">
                    Enter your info below to register with us!
                </div>
            </div>
        </div>

        <!-- Labels and Text Boxes -->
        <div class="form-vertical">
            <div class="col-md-offset-4 col-md-4">
                <!-- First Name -->
                <div class="form-group">
                    <label class="label" for="txtFirstName">First Name: </label>
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="entry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" CssClass="warning" ErrorMessage="First Name Required!" ControlToValidate="txtFirstName" Display="Dynamic" Text="*" ></asp:RequiredFieldValidator>
                </div>

                <!-- Last Name -->
                <div class="form-group">
                    <label class="label" for="txtLastName">Last Name:</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="entry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" CssClass="warning" ErrorMessage="Last Name Required!" ControlToValidate="txtLastName" Display="Dynamic" Text="*" ></asp:RequiredFieldValidator>
                </div>
            </div>

            <!-- Labels and Text Boxes -->
            <div class="col-md-offset-4 col-md-4">
                <!-- Email -->
                <div class="form-group">
                    <label class="label" for="txtEmail">Email Address: </label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="entry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Email Required!" ControlToValidate="txtEmail" CssClass="warning">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" CssClass="warning" ErrorMessage="Invalid Email Address!" ControlToValidate="txtEmail" Display="Dynamic" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
                </div>

                <!-- Phone -->
                <div class="form-group">
                    <label class="label" for="txtPhone">Phone Number: </label>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="entry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ErrorMessage="Phone Number Required!" ControlToValidate="txtPhone" CssClass="warning" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPhone" runat="server" CssClass="warning" ErrorMessage="Invalid Phone Number!" ControlToValidate="txtPhone" Display="Dynamic" Text="*" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ></asp:RegularExpressionValidator>
                </div>
            </div>

            <!-- DISPLAY -->
            <div class="row col-md-offset-4 col-md-4">
                <div class="col-md-offset-4 col-md-8">
                    <br />
                    <asp:Label ID="lblDisplay" runat="server" Text="" CssClass="display"></asp:Label>
                    <br />
                    <br />
                    <br />
                </div>
            </div>

             <!-- Validation Summary -->
            <div class="row">
                <div class="col-md-offset-4 col-md-4">
                    <asp:ValidationSummary ID="vsContactInfo" runat="server" CssClass="error"/>
                    </div>
            </div>

            <!-- BUTTONS -->
            <div class="form-horizontal">
                <div class="row">
                    <!-- Submit Button -->
                    <div class="col-md-offset-4 col-md-4">
                        <div class="col-md-2">
                            <div class="button">
                                <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit &raquo;" OnClick="btnSubmit_Click" />
                            </div>
                        </div>

                        <!-- Clear Button -->
                        <div class="col-md-offset-2 col-md-2">
                            <div class="button">
                                <asp:Button ID="btnClear" class="btn btn-default" runat="server" Text="Clear &raquo;" OnClick="btnClear_Click" />
                            </div>
                        </div>

                        <!-- Cancel Button -->
                        <div class="col-md-offset-2 col-md-2">
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
