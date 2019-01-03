/*
 * Filename: AgentForm.aspx
 * Date: 3.12.18
 * Author: William Ponton
 * Description: AgentForm displays data from a database in a gridview format.
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

namespace PontonInsurance
{
    public partial class AgentForm : System.Web.UI.Page
    {
        /// <summary>
        /// Page_Load
        /// Events that occur when the page is loaded.
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
            if (gvAgents.HeaderRow != null)
            {
                gvAgents.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}