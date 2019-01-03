/*
 * Filename: Default.aspx.cs
 * Date: 2.24.2018
 * Author: William Ponton
 * Description:  Codebehind for Default.aspx
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
    /// Default.aspx
    /// The Home Page for Ponton Insurance Group, LLC
    /// </summary>
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// btnContact
        /// Redirects to the ContactInfo.aspx page.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ContactInfo");
        }

        /// <summary>
        /// btnQuote
        /// Redirects user to the QuoteInfo.aspx page after checking
        /// if a Contact Object is saved in Session State.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnQuote_Click(object sender, EventArgs e)
        {
            //Checks session for a previously saved Contact Object
            //and if true redirects to the QuoteInfo Page
            if (Session["contact"] != null)
            {
                Response.Redirect("~/QuoteInfo");
            }
            else
            {
                //..otherwise, redirect to ContactInfo.aspx
                Response.Redirect("~/ContactInfo");
            }
        }

        /// <summary>
        /// Directs user to the Agent Info Page
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void btnAgents_Click(object sender, EventArgs e)
        {
            lblSignIn.Visible = true;
            lblInstructions.Visible = true;
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
        }
        
    /// <summary>
    /// btnLogin
    /// User Authorization
    /// </summary>
    /// <param name="sender">Control Initiating Event</param>
    /// <param name="e">Event Argument</param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;

            userName = txtUserName.Text.Trim();
            password = txtPassword.Text.Trim();

            if (userName != "admin" && password != "Password#123")
            {
                Response.Redirect("~/AgentForm");
            }
            else
            {
                Response.Redirect("~/AdminAgents");
            }
        }
    }
}