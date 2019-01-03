/*
 * Filename: AdminAgents.aspx.cs
 * Date: 3.21.18
 * Author: William Ponton
 * Description: Agent Data with Admin rights to edit, delete, and add new.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PontonInsurance.Models;


namespace PontonInsurance
{
    /// <summary>
    /// AdminAgents Form
    /// </summary>
    public partial class AdminAgents : System.Web.UI.Page
    {
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// gvAgents PreRender Method
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void gvAgents_PreRender(object sender, EventArgs e)
        {
            if (gvAgentsEdit.HeaderRow != null)
            {
                gvAgentsEdit.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }

        /// <summary>
        /// GetAffectedRows
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void odsAgentLocation_GetAffectedRows(object sender,
            ObjectDataSourceStatusEventArgs e)
        {
            e.AffectedRows = Convert.ToInt32(e.ReturnValue);
        }

        /// <summary>
        /// RowsUpdated
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void gvAgentsEdit_RowsUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if (e.Exception != null)
            {
                lblDisplay.Text = e.Exception.ToString();
                e.ExceptionHandled = true;
                e.KeepInEditMode = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblDisplay.Text = ConcurrencyErrorMessage();
            }
        }

        /// <summary>
        /// ItemInserted
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void dvNewAgent_ItemInserted(object sender,
            DetailsViewInsertedEventArgs e)
        {
            
            if (e.Exception != null)
            {
                lblDisplay.Text = "Error! " + DatabaseErrorMessage(e.Exception) + " Insertion error!";
                e.ExceptionHandled = true;
            }
        }

        /// <summary>
        /// RowsDeleted
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void gvAgentsEdit_RowsDeleted(object sender, GridViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                lblDisplay.Text = "Error! " + DatabaseErrorMessage(e.Exception) + " Deletion error!";
                e.ExceptionHandled = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblDisplay.Text = ConcurrencyErrorMessage();
            }
        }

        /// <summary>
        /// DatabaseErrorMessage
        /// </summary>
        /// <param name="ex">Exception ex</param>
        /// <returns>Message</returns>
        private string DatabaseErrorMessage(Exception ex)
        {
            string msg = $"<b>A database error has occured:</b> {ex.Message}";
            if (ex.InnerException != null)
            {
                msg += $"<br />Message: {ex.InnerException.Message}";
            }
            return msg;
        }

        /// <summary>
        /// ConcurrencyErrorMessage 
        /// </summary>
        /// <returns>Message</returns>
        private string ConcurrencyErrorMessage()
        {
            string message;
            message = "Another user may have updated this record already. Please try again.";
            return message;
        }

        /// <summary>
        /// odsAgentLocation_Deleted
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        protected void odsAgentLocation_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                lblDisplay.Text = DatabaseErrorMessage(e.Exception);
                e.ExceptionHandled = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblDisplay.Text = "Error! " + ConcurrencyErrorMessage() +" Concurrency Error!";
            }
        }
    }
}
