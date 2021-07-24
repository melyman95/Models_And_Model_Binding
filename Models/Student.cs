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
        /// The legal first and last name of the student, with middle initial optional.
        /// </summary>
        [Display(Name = "Full Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Student's full name is required.")]
        public string FullName { get; set; }

        /// <summary>
        /// MM/DD/YYYY
        /// </summary>
        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "Student's date of birth is required.")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Student (not personal) email address. Ends with @student.cptc.edu
        /// </summary>
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Student's email is required.")]
        public string Email { get; set; }

        /// <summary>
        /// Personal phone number of the student, could be home or cell
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Student's phone number is required.")]
        public string Phone { get; set; }
    }
}
