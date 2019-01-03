/*
 * Filename:        QuoteInfo.aspx.cs
 * Date:            2.26.2018   (Finished Late)
 * Author:          William Ponton
 * Description:     QuoteInfo Form Displays an object in SessionState,
 *                  alows the user to enter bDay and Gender, and makes
 *                  a calculation for the quote based on their age.
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
    /// QuoteInfo.aspx.cs
    /// QuoteInfo page displays when a Contact object has been stored in Session State.
    /// The user is allowed to enter their Date of Birth and Gender via controls.
    /// When the user clicks Submit, the birth year of the user is parsed and their 
    /// current age is calculated.  If the person is over 25, they are asked to 
    /// contact us for a quote.  If the person is under 25, a tiered pricing system exists
    /// and the monthly and annual rates are calculated.
    /// A new QuoteRequest object is then instantiated and its contents displayed in a label.
    /// The new Object is saved in Session State.
    /// </summary>
    public partial class QuoteInfo : System.Web.UI.Page
    {
        /// <summary>
        /// Page_Load
        /// Checks for a Session Object "contact" - if the object exists the contents
        /// of the object is displayed and the user may enter the DOB and Gender.
        /// If Session["contact"] does not exist, the user is redirected to ContactInfo.aspx
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["contact"] == null)
                {
                    Response.Redirect("~/ContactInfo");
                }
                else
                {
                    /* Session State with Contact Class from ContactInfo Page*/
                    Models.Contact myContact = (Models.Contact)Session["contact"];
                    lblDisplay.Text = "Welcome Back! " + myContact.ToString();                    
                }
                
            }
        }

        /// <summary>
        /// btnSubmit
        /// After entering their info, this calculated the age of the person
        /// and issues a rate based on their age.  People over 25 are directed to
        /// contact the Ponton Insurance Group via email for a quote.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Local variables
                string firstName, lastName, email, phone, bDay, gender;
                int age = 0;
                double rate = 0.0, monthlyRate = 0.0, annualRate = 0.0;

                //Initialization from Form and Session State
                bDay = txtDOB.Text;
                gender = ddlGender.SelectedValue;
                firstName = Session["firstName"].ToString();
                lastName = Session["lastName"].ToString();
                email = Session["email"].ToString();
                phone = Session["phone"].ToString();

                try
                {
                    //Instantiate a new QuoteRequest Object
                    Models.QuoteRequest myQuote = new Models.QuoteRequest(firstName, lastName, email, phone, bDay, gender);

                    try
                    {
                        //Parse the Year from DateTime
                        string currentYear = DateTime.Now.Year.ToString();
                        int.TryParse(currentYear, out int year);
                        //Parse the BirthYear from bDay
                        int birthYear =  DateTime.Parse(bDay).Year;
                        age = year - birthYear;

                        /* Insurance Calculation */
                        //Age has passed validation, now the rate is determined.
                        // 0 - 7 = $2.17/month, $26.04/anum.
                        // 8 - 15 = $3.25/month, $39.00/anum.
                        // 16 - 21 = $3.82/month, $45.84/anum.
                        // 22 -25 = $4.33/month , $51.96/anum.
                        if (age > 25)
                        {
                            //Show message to Contact fo a Quote if over 25 years old.
                            lblDisplay.Visible = false;
                            lblMessage.Visible = true;
                            lblMessage.Text = "Contact us for a Quote if you are over 25 years old! <br />"; 
                        }
                        else if (age > 21)
                        {
                            rate = 4.33;
                        }
                        else if (age > 15)
                        {
                            rate = 3.82;
                        }
                        else if (age > 7)
                        {
                            rate = 3.25;
                        }
                        else if (age > 0)
                        {
                            rate = 2.17;
                        }
                        else
                        {
                            rate = 0.0;
                        }
                        try
                        {
                            //Calculation:
                            monthlyRate = rate;
                            annualRate = monthlyRate * 12;
                            //Display the info if all checks out.
                            lblDisplay.Text = myQuote.ToString() + "<br /> " +
                                "Age: " + age + "<br />Monthly Rate: " + monthlyRate.ToString("c") + 
                                                "<br />Annual Rate: " + annualRate.ToString("c") + "<br />";
                                                Session["quote"] = myQuote;
                                                Session["monthlyRate"] = monthlyRate;
                                                Session["annualRate"] = annualRate;
                        }
                        catch (Exception ex)
                        {
                            //Some kind of calculation error - division by 0 or something odd.
                            lblDisplay.Text = "Error! " + ex.Message + "Cannot compute rate.";
                        }
                    }
                    catch (Exception ex)
                    {
                        //Age has failed somehow.
                        lblDisplay.Text = "Error" + ex.Message + "Age is not valid.";
                    }
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
        /// Clears the controls of the form
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event argument</param>
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtDOB.Text = string.Empty;
            ddlGender.ClearSelection();
            lblCookie.Text = string.Empty;
            lblDisplay.Text = string.Empty;
            txtDOB.Focus();
        }

        /// <summary>
        /// btnCancel
        /// Cancels the Session.
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event Argument</param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["contact"] = null;
            Session["UserName"] = null;
            Response.Redirect("~/Default");
        }
    }
}