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

namespace Fsmb.Api.Unified.Client.Models
{
    /// <summary>Malpractice information/summary>
    public class Malpractice
    {
        /// <summary>State/province of malpractice/summary>
        [Required]        
        public StateOrProvince State { get; set; }

        /// <summary>Date of event/summary>
        public DateTime EventDate { get; set; }

        /// <summary>Name of patient/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(100)]
        public string PatientName { get; set; }

        /// <summary>Name of court/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(100)]
        public string CourtName { get; set; }

        /// <summary>Case number/summary>
        [MaxLength(50)]
        public string CaseNumber { get; set; }

        /// <summary>Role of practitioner in claim/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(100)]
        public string Role { get; set; }

        /// <summary>Date of lawsuit/summary>
        public DateTime LawsuitDate { get; set; }

        /// <summary>Status of claim/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(100)]
        public string ClaimStatus { get; set; }

        /// <summary>Name of insurance/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(100)]
        public string InsuranceName { get; set; }

        /// <summary>Amount of judgement/summary>
        public decimal? JudgementAmount { get; set; }

        /// <summary>Behalf amount/summary>
        public decimal? BehalfAmount { get; set; }

        /// <summary>Explanation/summary>
        [Required(AllowEmptyStrings = false)]        
        [MaxLength(2000)]
        public string Explanation { get; set; }
    }
}