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
    /// <summary>State medical license information</summary>
    public class AmaLicense
    {
        /// <summary>License number</summary>
        [Required(AllowEmptyStrings = false)]
        public string LicenseNumber { get; set; }

        /// <summary>Issue date</summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>Expiration date</summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>Last reported date</summary>
        public DateTime? LastReportedDate { get; set; }

        /// <summary>Type of license (e.g. 'Limited', 'Pending', 'Restricted', 'Temporary', 'Unlimited')</summary>
        public string TypeDescription { get; set; }

        /// <summary>State issuing the license</summary>
        public string StateDescription { get; set; }

        /// <summary>Licensing degree code (e.g. 'MD', 'DO')</summary>
        public string DegreeCode { get; set; }

        /// <summary>Status of license (e.g. 'Active', 'Inactive', 'Denied', 'Unknown')</summary>
        public string LicenseStatus { get; set; }

        /// <summary>Renewal date</summary>
        public DateTime? RenewalDate { get; set; }

        /// <summary>Physician name</summary>
        public AmaName PhysicianName { get; set; }
    }
}