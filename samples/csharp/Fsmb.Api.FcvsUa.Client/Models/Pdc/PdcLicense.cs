﻿/*
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

namespace Fsmb.Api.FcvsUa.Client.Models.Pdc
{
    /// <summary>PDC license</summary>
    public class PdcLicense
    {
        /// <summary>Report date</summary>
        public DateTime ReportDate { get; set; }

        /// <summary>Type of license/summary>
        [MaxLength(100)]
        public string LicenseType { get; set; }

        /// <summary>Issuer of license/summary>
        [Required]
        public LicensingEntity Issuer { get; set; }

        /// <summary>License status/summary>
        [MaxLength(100)]
        public string Status { get; set; }

        /// <summary>License number/summary>
        [MaxLength(20)]
        public string LicenseNumber { get; set; }

        /// <summary>Issue date/summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>Expiration date/summary>
        public DateTime? ExpirationDate { get; set; }
    }
}