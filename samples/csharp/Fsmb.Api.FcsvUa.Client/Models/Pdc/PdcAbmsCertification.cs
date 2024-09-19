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
    /// <summary>PDC ABMS certification/summary>
    public class PdcAbmsCertification
    {
        /// <summary>Report date/summary>
        public DateTime ReportDate { get; set; }

        /// <summary>Certifying board/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string BoardName { get; set; }

        /// <summary>Certificate name/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string CertificateName { get; set; }

        /// <summary>Meets MOC requirements (e.g. Yes, No, Not Required)/summary>
        [MaxLength(20)]
        public string MeetsMocRequirements { get; set; }

        /// <summary>Is certified?/summary>
        public bool IsCertified { get; set; }

        /// <summary>Status of certificate (e.g. Active, Inactive, Expired)/summary>
        [MaxLength(100)]
        public string CertificateStatus { get; set; }

        /// <summary>Type of certificate (e.g. General, Subspecialty)/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string CertificateType { get; set; }

        /// <summary>Duration of the certificate (e.g. Lifetime, MOC, Time Limited)/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(20)]
        public string CertificateDuration { get; set; }

        /// <summary>Type of occurrence (e.g. Initial, Recertification, Designation)/summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(20)]
        public string OccurrenceType { get; set; }

        /// <summary>Effective date/summary>
        public PartialDate EffectiveDate { get; set; }

        /// <summary>Expiration date/summary>
        public PartialDate ExpirationDate { get; set; }

        /// <summary>Reverification date/summary>        
        public DateTime? ReverificationDate { get; set; }

        /// <summary>MOC pathway Id/summary>
        [MaxLength(2)]
        public string MocPathwayId { get; set; }

        /// <summary>MOC pathway name/summary>
        [MaxLength(100)]
        public string MocPathwayName { get; set; }

        /// <summary>Occupation status (e.g. R)/summary>
        [MaxLength(2)]
        public string OccupationStatus { get; set; }

        /// <summary>Occupation status notification year/summary>
        [RegularExpression(@"\d{4}")]
        public string OccupationStatusNotifyYear { get; set; }
    }
}