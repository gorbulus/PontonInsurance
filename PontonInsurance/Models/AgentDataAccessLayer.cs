/*
 * Filename: AgentDataAccessLayer
 * Date: 3.20.18
 * Author: William Ponton
 * Description: Specification for the AgentDataAccessLayer Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace PontonInsurance.Models
{

    /// <summary>
    /// AgentDataAccessLayer
    /// The DataAccessLayer Specifications and SQL Access Methods
    /// </summary>
    #region AgentDataAccessLayer
    [DataObject(true)]
    public class AgentDataAccessLayer
    {
        /// <summary>
        /// Open Constructor
        /// </summary>
        AgentDataAccessLayer()
        {

        }
        /// <summary>
        /// DataObjectMethod GetAllAgents
        /// Loads all records from the database into the gvAgents GridView Control.
        /// </summary>
        /// <returns>agentList</returns>
        #region GetAllAgents
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<AgentLocation> GetAllAgents()
        {
            List<AgentLocation> agentList = new List<AgentLocation>();
            string cs = ConfigurationManager.ConnectionStrings["AgentAdmin"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Locations", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    AgentLocation myAgent = new AgentLocation();
                    myAgent.Id = Convert.ToInt32(rdr["Id"]);
                    myAgent.FirstName = rdr["FirstName"].ToString();
                    myAgent.LastName = rdr["LastName"].ToString();
                    myAgent.Agency = rdr["Agency"].ToString();
                    myAgent.Certifications = rdr["Certifications"].ToString();
                    myAgent.Address = rdr["Address"].ToString();
                    myAgent.Suite = rdr["Suite"].ToString();
                    myAgent.City = rdr["City"].ToString();
                    myAgent.State = rdr["State"].ToString();
                    myAgent.Zip = rdr["Zip"].ToString();
                    myAgent.Licenses = rdr["Licenses"].ToString();
                    myAgent.Phone = rdr["Phone"].ToString();
                    agentList.Add(myAgent);
                }
            }
            return agentList;
        }
        #endregion

        /// <summary>
        /// GetConnectionString
        /// </summary>
        /// <returns>AgentAdmin Connection String</returns>
        #region GetConnectionString
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["AgentAdmin"].ConnectionString;
        }
        #endregion

        /// <summary>
        /// DataObjectMethod InsertAgent
        /// Inserts data from the client into the database.
        /// </summary>
        /// <param name="myAgent">myAgent</param>
        #region InsertAgent
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static void InsertAgent(AgentLocation myAgent)
        {
            string sql = "INSERT INTO Locations "
                        + "(Id, FirstName, LastName, Agency, Certifications, Address, Suite, City, State, Zip, Licenses, Phone) "
                        + "VALUES (@Id, @FirstName, @LastName, @Agency, @Certifications, @Address, @Suite, @City, @State, @Zip, @Licenses, @Phone)";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("Id", myAgent.Id);
                    cmd.Parameters.AddWithValue("FirstName", myAgent.FirstName);
                    cmd.Parameters.AddWithValue("LastName", myAgent.LastName);
                    cmd.Parameters.AddWithValue("Agency", myAgent.Agency);
                    cmd.Parameters.AddWithValue("Certifications", myAgent.Certifications);
                    cmd.Parameters.AddWithValue("Address", myAgent.Address);
                    cmd.Parameters.AddWithValue("Suite", myAgent.Suite);
                    cmd.Parameters.AddWithValue("City", myAgent.City);
                    cmd.Parameters.AddWithValue("State", myAgent.State);
                    cmd.Parameters.AddWithValue("Zip", myAgent.Zip);
                    cmd.Parameters.AddWithValue("Licenses", myAgent.Licenses);
                    cmd.Parameters.AddWithValue("Phone", myAgent.Phone);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        /// <summary>
        /// DataObjectMethod DeleteAgent
        /// Removes an Agent record from the database.
        /// </summary>
        /// <param name="myAgent"></param>
        /// <returns>deleteCount</returns>
        #region DeleteAgent
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static int DeleteAgent(AgentLocation myAgent)
        {
            int deleteCount = 0;
            string sql = "DELETE FROM Locations "
                        + "WHERE Id = @Id "
                        + "AND FirstName = @FirstName "
                        + "AND LastName = @LastName "
                        + "AND Agency = @Agency "
                        + "AND Certifications = @Certifications "
                        + "AND Address = @Address "
                        + "AND Suite = @Suite "
                        + "AND City = @City "
                        + "AND State = @State "
                        + "AND Zip = @Zip "
                        + "AND Licenses = @Licenses "
                        + "AND Phone = @Phone";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("Id", myAgent.Id);
                    cmd.Parameters.AddWithValue("FirstName", myAgent.FirstName);
                    cmd.Parameters.AddWithValue("LastName", myAgent.LastName);
                    cmd.Parameters.AddWithValue("Agency", myAgent.Agency);
                    cmd.Parameters.AddWithValue("Certifications", myAgent.Certifications);
                    cmd.Parameters.AddWithValue("Address", myAgent.Address);
                    cmd.Parameters.AddWithValue("Suite", myAgent.Suite);
                    cmd.Parameters.AddWithValue("City", myAgent.City);
                    cmd.Parameters.AddWithValue("State", myAgent.State);
                    cmd.Parameters.AddWithValue("Zip", myAgent.Zip);
                    cmd.Parameters.AddWithValue("Licenses", myAgent.Licenses);
                    cmd.Parameters.AddWithValue("Phone", myAgent.Phone);

                    con.Open();
                    deleteCount = cmd.ExecuteNonQuery();
                }

            }
            return deleteCount;
        }
        #endregion

        /// <summary>
        /// DataObjectMethod UpdateAgent
        /// Updates an existing record in the database.
        /// </summary>
        /// <param name="original_Agent"></param>
        /// <param name="myAgent"></param>
        /// <returns>updateCount</returns>
        #region UpdateAgent
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int UpdateAgent(AgentLocation original_Agent, AgentLocation myAgent)
        {
            int updateCount = 0;
            string sql = "UPDATE Locations "
                        + "SET Id = @Id, "
                        + "FirstName = @FirstName, "
                        + "LastName = @LastName, "
                        + "Agency = @Agency, "
                        + "Certifications = @Certifications, "
                        + "Address = @Address, "
                        + "Suite = @Suite, "
                        + "City = @City, "
                        + "State = @State, "
                        + "Zip = @Zip, "
                        + "Licenses = @Licenses, "
                        + "Phone = @Phone "
                        + "WHERE Id = @original_Id "
                        + "AND FirstName = @original_FirstName "
                        + "AND LastName = @original_LastName "
                        + "AND Agency = @original_Agency "
                        + "AND Certifications = @original_Certifications "
                        + "AND Address = @original_Address "
                        + "AND Suite = @original_Suite "
                        + "AND City = @original_City "
                        + "AND State = @original_State "
                        + "AND Zip = @original_Zip "
                        + "AND Licenses = @original_Licenses "
                        + "AND Phone = @original_Phone";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("FirstName", myAgent.FirstName);
                    cmd.Parameters.AddWithValue("LastName", myAgent.LastName);
                    cmd.Parameters.AddWithValue("Agency", myAgent.Agency);
                    cmd.Parameters.AddWithValue("Certifications", myAgent.Certifications);
                    cmd.Parameters.AddWithValue("Address", myAgent.Address);
                    cmd.Parameters.AddWithValue("Suite", myAgent.Suite);
                    cmd.Parameters.AddWithValue("City", myAgent.City);
                    cmd.Parameters.AddWithValue("State", myAgent.State);
                    cmd.Parameters.AddWithValue("Zip", myAgent.Zip);
                    cmd.Parameters.AddWithValue("Licenses", myAgent.Licenses);
                    cmd.Parameters.AddWithValue("Phone", myAgent.Phone);

                    cmd.Parameters.AddWithValue("original_Id", original_Agent.Id);
                    cmd.Parameters.AddWithValue("original_FirstName", original_Agent.FirstName);
                    cmd.Parameters.AddWithValue("original_LastName", original_Agent.LastName);
                    cmd.Parameters.AddWithValue("original_Agency", original_Agent.Agency);
                    cmd.Parameters.AddWithValue("original_Certifications", original_Agent.Certifications);
                    cmd.Parameters.AddWithValue("original_Address", original_Agent.Address);
                    cmd.Parameters.AddWithValue("original_Suite", original_Agent.Suite);
                    cmd.Parameters.AddWithValue("original_City", original_Agent.City);
                    cmd.Parameters.AddWithValue("original_State", original_Agent.State);
                    cmd.Parameters.AddWithValue("original_Zip", original_Agent.Zip);
                    cmd.Parameters.AddWithValue("original_Licenses", original_Agent.Licenses);
                    cmd.Parameters.AddWithValue("original_Phone", original_Agent.Phone);

                    con.Open();
                    updateCount = cmd.ExecuteNonQuery();
                }
            }
            return updateCount;
        }
        #endregion
    }
    #endregion
}