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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Api.Unified.Client.Models
{
    /// <summary>Applicant Details</summary>
    public class Applicant
    {
        /// <summary>FID of applicant</summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(9)]
        public string Fid { get; set; }

        /// <summary>Application information</summary>
        [Required]
        public Application Application { get; set; }

        /// <summary>FCVS profile status</summary>
        [Required(AllowEmptyStrings = false)]
        public string FcvsProfileStatus { get; set; }

        /// <summary>FCVS profile information, if available</summary>
        public FcvsProfileReport FcvsProfile { get; set; }

        /// <summary>UA status</summary>
        [Required(AllowEmptyStrings = false)]
        public string UaStatus { get; set; }

        /// <summary>UA submission information, if available</summary>
        public UaSubmission UaSubmission { get; set; }

        /// <summary>Identity information</summary>
        [Required]
        public Identification Identity { get; set; }

        /// <summary>Names</summary>
        [Required]
        public Names Names { get; set; }

        /// <summary>Mailing addresses</summary>
        [Required]
        public Addresses Addresses { get; set; }

        /// <summary>Email addresses</summary>
        [Required]
        public EmailAddresses EmailAddresses { get; set; }

        /// <summary>Phone numbers</summary>
        [Required]
        public Phones Phones { get; set; }

        /// <summary>Medical education</summary>
        public MedicalEducationTraining MedicalEducation { get; set; }

        /// <summary>Postgraduate training</summary>
        public PostGraduateTraining PostGraduateTraining { get; set; }

        /// <summary>Exams</summary>
        public IEnumerable<Exam> Exams { get; set; }

        /// <summary>Licenses</summary>
        public IEnumerable<License> Licenses { get; set; }

        /// <summary>Malpractice information</summary>
        public IEnumerable<Malpractice> Malpractice { get; set; }

        /// <summary>Chronology of activity</summary>
        public IEnumerable<Activity> Activities { get; set; }

        /// <summary>NPDB report status (`NotAvailable`, `Available`, `Pending`)</summary>
        public string NpdbReportStatus { get; set; }

        /// <summary>NPDB report, if available (only available for physicians who have submitted to an NPDB-supported board)</summary>
        public Npdb.NpdbReport NpdbReport { get; set; }

        /// <summary>PDC report status (`NotAvailable`, `Available`, `Pending`)</summary>
        public string PdcReportStatus { get; set; }

        /// <summary>PDC report, if available</summary>
        public Pdc.PdcReport PdcReport { get; set; }
        
        /// <summary>AMA report status (`NotAvailable`, `Available`, `Pending`, `NotReleased`)</summary>
        public string AmaReportStatus { get; set; }

        /// <summary>AMA information, if available</summary>
        public Ama.AmaReport Ama { get; set; }

        /// <summary>State addendum</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateAddendum", Required = Newtonsoft.Json.Required.Default)]
        public Addendum.StateAddendum StateAddendum { get; set; }
    }
}
