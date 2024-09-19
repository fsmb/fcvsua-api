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

namespace Fsmb.Api.FcsvUa.Client.Models.Pdc
{
    /// <summary>PDC AOA certification</summary>
    public class PdcAoaCertification
    {
        /// <summary>AOA ID/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(6)]
        public string AoaId { get; set; }

        /// <summary>Report date/summary>
        public DateTime ReportDate { get; set; }

        /// <summary>Board name/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string BoardName { get; set; }

        /// <summary>Certification name/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string CertificationName { get; set; }

        /// <summary>Certification status (e.g. Active, Inactive, Retired, Deceased)/summary>
        [MaxLength(20)]
        public string CertificationStatus { get; set; }

        /// <summary>Certification type (e.g. Primary, Subspecialty)/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string CertificationType { get; set; }

        /// <summary>Is OCC participating/summary>
        public bool IsOccParticipating { get; set; }

        /// <summary>Is OCC required/summary>
        public bool IsOccRequired { get; set; }

        /// <summary>Certification issue date/summary>
        public DateTime? CertificationIssueDate { get; set; }

        /// <summary>Certification end date/summary>
        public DateTime? CertificationEndDate { get; set; }

        /// <summary>Recertification issue date/summary>
        public DateTime? RecertificationIssueDate { get; set; }

        /// <summary>Recertification expire date/summary>
        public DateTime? RecertificationExpireDate { get; set; }
    }
}