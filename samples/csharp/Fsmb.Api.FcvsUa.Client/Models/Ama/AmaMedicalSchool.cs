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

namespace Fsmb.Api.FcvsUa.Ama
{
    /// <summary>Medical education</summary>
    public class AmaMedicalSchool
    {
        /// <summary>Name of the medical school</summary>
        [Required(AllowEmptyStrings = false)]
        public string SchoolName { get; set; }

        /// <summary>Type of medical education (Degree or Certificate)</summary>
        public string EducationType { get; set; }

        /// <summary>Indicates if a degree was awarded (Yes, No, Enrolled, or 5th Pathway)</summary>
        public string DegreeAwarded { get; set; }

        /// <summary>Graduation year</summary>    
        public string GraduationYear { get; set; }

        /// <summary>Graduation year and optionally month in format 'yyyy-mm'</summary>
        public string GraduationDateString { get; set; }

        /// <summary>Degree code (e.g. 'MD', 'DO')</summary>
        public string DegreeCode { get; set; }

        /// <summary>Enrollment year and optionally month in format 'yyyy-mm'</summary>
        public string EnrollmentDateString { get; set; }
    }
}