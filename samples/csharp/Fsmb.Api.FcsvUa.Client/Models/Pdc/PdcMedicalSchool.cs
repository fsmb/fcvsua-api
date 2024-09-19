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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Api.FcsvUa.Client.Models.Pdc
{
    /// <summary>PDC medical school</summary>
    public class PdcMedicalSchool
    {
        /// <summary>School name</summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>Alternate school names</summary>
        [MaxLength(100)]
        public List<string> AlternateNames { get; set; }

        /// <summary>CIBIS code</summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(6)]
        public string CibisCode { get; set; }

        /// <summary>Type of school</summary>
        [Required]
        public SchoolType SchoolType { get; set; }

        /// <summary>City</summary>
        [MaxLength(50)]
        public string City { get; set; }

        /// <summary>State or province</summary>
        public StateOrProvince StateOrProvince { get; set; }
    }
}