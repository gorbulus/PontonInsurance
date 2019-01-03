/*
 * Filename:    Contact.cs
 * Date:        1.22.18
 * Author:      William Ponton
 * Description: Specification for the Contact Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PontonInsurance.Models
{
    #region Contact Class
    /// <summary>
    /// Contact Class
    /// Firs tName, Last Name, Email, Phone Number
    /// Public Properties
    /// Constructor/Destructors
    /// ToString() Method
    /// </summary>
    public class Contact
    {
        #region Private Member Variables
        /// <summary>
        /// Private Member variables
        /// </summary>
        private string _firstName, _lastName, _email, _phone;
        #endregion

        #region Constructors
        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="pFirstName">First Name</param>
        /// <param name="pLastName">Last Name</param>
        /// <param name="pEmail">Email Address</param>
        /// <param name="pPhone">Phone Number</param>
        public Contact(string pFirstName, string pLastName, string pEmail, string pPhone)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            Email = pEmail;
            Phone = pPhone;
        }

        /// <summary>
        /// Default Constructor
        /// Calls Clear() method
        /// </summary>
        public Contact()
        {
            Clear();
        }
        #endregion

        #region Destructor
        /// <summary>
        /// Destructor
        /// Sets all string Private Member Variables to null
        /// </summary>
        ~Contact()
        {
            _firstName = null;
            _lastName = null;
            _email = null;
            _phone = null;
        }
        #endregion

        #region Public Properties
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
        /// Email : string
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value.Trim(); }
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
        /// Clear() method
        /// Sets all string Private Member Variables to string.Empty
        /// </summary>
        public void Clear()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _email = string.Empty;
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
            message = "<br />Name: " + FirstName + " " + LastName + "<br />Email: " + Email + "<br />Phone Number: " + Phone;
            return message;
        }
        #endregion
    }
    #endregion
}