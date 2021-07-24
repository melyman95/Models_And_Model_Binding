using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models_And_Model_Binding.Models
{
    /// <summary>
    /// Represents an individual student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Unique identifier for the student.
        /// </summary>
        public int StudentID { get; set; }
        
        /// <summary>
        /// The legal first and last name of the student, with middle initial.
        /// </summary>
        [Display(Name = "Full Name")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        /// <summary>
        /// MM/DD/YYYY
        /// </summary>
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Student (not personal) email address. Ends with @student.cptc.edu
        /// </summary>
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Personal phone number of the student, could be home or cell
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
