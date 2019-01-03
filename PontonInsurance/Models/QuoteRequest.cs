/*
 * Filename:    Quote.cs
 * Date:        2.24.18
 * Author:      William Ponton
 * Description: Specification for the Quote Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PontonInsurance.Models
{
    #region QuoteRequest Class
    /// <summary>
    /// QuoteRequest Class
    /// Derived from Contact Class
    /// QuoteRequest Attributes: Birth Day, Gender
    /// Contact Attributes: First Name, Last Name, Email, Phone Number
    /// Public Properties
    /// Constructor/Destructors
    /// ToString() Method
    /// </summary>
    public class QuoteRequest : Contact
    {
        #region Private Data Members
        /// <summary>
        /// Backing Fields
        /// BirthDay, Gender
        /// </summary>
        private string _bday, _gender;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public QuoteRequest()
        {
            _bday = string.Empty;
            _gender = string.Empty;
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="pFirstName">First Name</param>
        /// <param name="pLastName">Last Name</param>
        /// <param name="pEmail">Email Address</param>
        /// <param name="pPhone">Phone Number</param>
        /// <param name="pBday">Date of Birth</param>
        /// <param name="pGender">Gender</param>
        public QuoteRequest(string pFirstName, string pLastName, string pEmail, string pPhone, string pBday, string pGender) :
                            base(pFirstName, pLastName, pEmail, pPhone)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            Email = pEmail;
            Phone = pPhone;
            Bday = pBday;
            Gender = pGender;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// Destructor
        /// </summary>
        ~QuoteRequest()
        {
            _bday = null;
            _gender = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Bday : string
        /// </summary>
        public string Bday
        {
            get { return _bday; }
            set { _bday = value.Trim(); }
        }

        /// <summary>
        /// Gender : string
        /// </summary>
        public string Gender
        {
            get { return _gender; }
            set { _gender = value.Trim(); }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// ToString() Override Method
        /// </summary>
        /// <returns>String representation of the Object's contents.</returns>
        public override string ToString()
        {
            string message;
            message = "<br />Name: " + FirstName + " " + LastName + "<br />Email: " + Email + "<br />Phone Number: " + Phone + 
                      "<br />Date of Birth: " + Bday + "<br /> Gender: " + Gender;
            return message;
        }
        #endregion
    }
    #endregion
}