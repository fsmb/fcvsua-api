/*
 * Copyright © Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Api.Unified.Ama
{
    /// <summary>Physician demographic information</summary>
    public class AmaDemographics
    {
        /// <summary>Legal name prefix</summary>
        public string Prefix { get; set; }

        /// <summary>Legal first name</summary>
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        /// <summary>Legal middle name</summary>
        public string MiddleName { get; set; }

        /// <summary>Legal last name</summary>
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        /// <summary>Legal name suffix</summary>
        public string Suffix { get; set; }

        /// <summary>Date of birth</summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>Date that physician was confirmed deceased</summary>
        public DateTime? DeathDate { get; set; }

        /// <summary>Indicates if the profile is for a medical student</summary>
        public bool? IsStudent { get; set; }

        /// <summary>Membership status (e.g. 'Member')</summary>
        public string AmaMembershipStatus { get; set; }

        /// <summary>Indicates what degree a physician was licensed as ('MD', 'DO')</summary>    
        public string DegreeCode { get; set; }
    }
}