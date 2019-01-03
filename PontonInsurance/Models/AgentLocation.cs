/*
 * Filename:    AgentLocation.cs
 * Date:        3.19.18
 * Author:      William Ponton
 * Description: Specification for the AgentLocation Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace PontonInsurance.Models
{
    #region AgentLocation Class 
    /// <summary>
    /// AgentLocation Class
    /// Business Class Specification to be used with an ObjectDataSource.
    /// </summary>
    public class AgentLocation
    {
        #region Private Data Members
        /// <summary>
        /// Private Data Members
        /// </summary>
        private int _id;
        private string _firstName, _lastName, _agency, _certifications,
            _address, _suite, _city, _state, _zip, _licenses, _phone;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public AgentLocation()
        {
            Clear();
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="pId">ID</param>
        /// <param name="pFirstName">First Name</param>
        /// <param name="pLastName">Last Name</param>
        /// <param name="pAgency">Agency</param>
        /// <param name="pCertifications">Certifications</param>
        /// <param name="pAddress">Address</param>
        /// <param name="pSuite">Suite</param>
        /// <param name="pCity">City</param>
        /// <param name="pState">State</param>
        /// <param name="pZip">Zip Code</param>
        /// <param name="pLicenses">Licenses</param>
        /// <param name="pPhone">Phone Number</param>
        public AgentLocation(int pId, string pFirstName, string pLastName, string pAgency,
            string pCertifications, string pAddress, string pSuite, string pCity, string pState,
            string pZip, string pLicenses, string pPhone)
        {
            Id = pId;
            FirstName = pFirstName;
            LastName = pLastName;
            Agency = pAgency;
            Certifications = pCertifications;
            Address = pAddress;
            Suite = pSuite;
            City = pCity;
            State = pState;
            Zip = pZip;
            Licenses = pLicenses;
            Phone = pPhone;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// Destructor
        /// </summary>
        ~AgentLocation()
        {
            _firstName = null;
            _lastName = null;
            _agency = null;
            _certifications = null;
            _address = null;
            _suite = null;
            _city = null;
            _state = null;
            _zip = null;
            _licenses = null;
            _phone = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Id : int
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// FirstName : string
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value.Trim(); }
        }

        /// <summary>
        /// LastName : string
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value.Trim(); }
        }

        /// <summary>
        /// Agency : string
        /// </summary>
        public string Agency
        {
            get { return _agency; }
            set { _agency = value.Trim(); }
        }

        /// <summary>
        /// Certifications : string
        /// </summary>
        public string Certifications
        {
            get { return _certifications; }
            set { _certifications = value.Trim(); }
        }

        /// <summary>
        /// Address : string
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value.Trim(); }
        }

        /// <summary>
        /// Suite : string
        /// </summary>
        public string Suite
        {
            get { return _suite; }
            set { _suite = value.Trim(); }
        }

        /// <summary>
        /// City : string
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = value.Trim(); }
        }

        /// <summary>
        /// State : string
        /// </summary>
        public string State
        {
            get { return _state; }
            set { _state = value.Trim(); }
        }

        /// <summary>
        /// Zip : string
        /// </summary>
        public string Zip
        {
            get { return _zip; }
            set { _zip = value.Trim(); }
        }

        /// <summary>
        /// Licenses : string
        /// </summary>
        public string Licenses
        {
            get { return _licenses; }
            set { _licenses = value.Trim(); }
        }

        /// <summary>
        /// Phone : string
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value.Trim(); }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Clear Method
        /// Clears string members upon instantiation.
        /// </summary>
        public void Clear()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _agency = string.Empty;
            _certifications = string.Empty;
            _address = string.Empty;
            _suite = string.Empty;
            _city = string.Empty;
            _state = string.Empty;
            _zip = string.Empty;
            _licenses = string.Empty;
            _phone = string.Empty;
        }

        /// <summary>
        /// ToString() Override method
        /// Displays the contents of the object after instantiation.
        /// </summary>
        /// <returns>String representation of the object's contents.</returns>
        public override string ToString()
        {
            string message;
            message = "<br />Name: " + FirstName + " " + LastName + "<br />Email: " + Agency + "<br />Certifications: " + Certifications +
                      "<br />Address: " + Address + "<br />Suite: " + Suite + "<br />City: " + City + " " +
                      "<br />State: " + State + "<br />Zip Code: " + Zip + "<br />Licenses (if any): " + Licenses +
                      "<br />Phone Number: " + Phone;
            return message;
        }
        #endregion
    }
    #endregion

    
}
