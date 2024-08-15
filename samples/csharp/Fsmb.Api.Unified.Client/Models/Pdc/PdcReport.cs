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

namespace Fsmb.Api.Unified.Client.Models.Pdc
{
    /// <summary>PDC report</summary>
    public class PdcReport
    {
        /// <summary>Date the report was generated</summary>
        public DateTime AsOfDate { get; set; }

        /// <summary>Board action status</summary>
        [MaxLength(20)]
        public string BoardActionStatus { get; set; }

        /// <summary>Names</summary>
        [Required]
        public PdcNames Names { get; set; }

        /// <summary>Birth date</summary>
        public PartialDate BirthDate { get; set; }

        /// <summary>Medical education</summary>
        [Required]
        public PdcMedicalEducation MedicalEducation { get; set; }

        /// <summary>License information</summary>
        public List<PdcLicense> Licenses { get; set; }

        /// <summary>NPI information</summary>
        public List<PdcNpi> Npi { get; set; }

        /// <summary>ABMS information</summary>
        public PdcAbms Abms { get; set; }

        /// <summary>AOA information</summary>
        public PdcAoa Aoa { get; set; }
    }
}