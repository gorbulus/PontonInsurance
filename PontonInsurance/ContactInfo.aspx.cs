/*
 * Filename: ContactInfo.aspx.cs
 * Date: 2.24.18
 * Author: William Ponton
 * Description:  Codebehind for ContactForm.aspx
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PontonInsurance
{
    /// <summary>
    /// ContactForm
    /// UI for gathering user Contact Data.
    /// </summary>
    public partial class ContactInfo : System.Web.UI.Page
    {
        /// <summary>
        /// PageLoad
        /// Checks for a saved cookie "UserName".
        /// If cookie exists, the user is welcomed with a Texan Howdy.
        /// If cookie does not exist, user is instructed to fill out the form to start a quote.
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Checks to see if the page has posted back   
            if (!IsPostBack)
            {
                //If the page has indeed posted back, save the userName in Session State.
                if (Request.Cookies["UserName"] != null)
                {
                    txtFirstName.Text = Request.Cookies["UserName"].Value;
                    //Greet the returning user with a Texan Howdy.
                    lblDisplay.Text = "Howdy, " + txtFirstName.Text + ".";
                }
                else
                {
                    //Instruct the user to complete the contact information.
                    lblDisplay.Text = "Please fill out your Contact Info to make a Quote.";
                }
            }
        }

        /// <summary>
        /// btnSubmit
        /// Validates user input from web controls, and if valid
        /// instantiates a new Contact Object.
        /// Contents of myContact are displayed in lblDisplay.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Local Variables
            string firstName, lastName, email, phone;

            try
            {
                //Initializing 
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                email = txtEmail.Text;
                phone = txtPhone.Text;

                try
                {
                    try
                    {
                        //Try/Catch for Cookie - duration is 7 days.
                        HttpCookie userCookie = new HttpCookie("UserName", txtFirstName.Text);
                        userCookie.Expires = DateTime.Now.AddDays(7);
                        Response.Cookies.Add(userCookie);
                    }
                    catch(Exception ex)
                    {
                        lblDisplay.Text = "Error! " + ex.Message + " Cannot create cookies!";
                    }

                    //Instantiate a Contact Object
                    Models.Contact myContact = new Models.Contact(firstName, lastName, email, phone);

                    //Session State - persistance of data in class through all pages in the app.
                    //Object Saved
                    Session["contact"] = myContact;

                    //Individual members Saved
                    Session["firstName"] = myContact.FirstName;
                    Session["lastName"] = myContact.LastName;
                    Session["email"] = myContact.Email;
                    Session["phone"] = myContact.Phone;

                    //Redirect to the Quote Page
                    Response.Redirect("~/QuoteInfo");
                }
                catch (Exception ex)
                {
                    lblDisplay.Text = "Error! " + ex.Message + " Cannot create object!";
                }
            }
            catch (Exception ex)
            {
                lblDisplay.Text = "Error! " + ex.Message + "Cannot validate input!";
            }
        }

        /// <summary>
        /// btnClear
        /// Clears the textboxes and labels in the form.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            lblDisplay.Text = string.Empty;
            txtFirstName.Focus();
        }

        /// <summary>
        /// btnCancel
        /// Cancels the session and Redirects to Default page.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
            
        }
    }
}