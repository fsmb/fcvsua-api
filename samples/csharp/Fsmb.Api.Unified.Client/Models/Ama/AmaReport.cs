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

namespace Fsmb.Api.Unified.Ama
{
    /// <summary>Physician profile</summary>
    public class AmaReport
    {
        /// <summary>AMA unique ID</summary>
        public long Id { get; set; }

        /// <summary>Date the report was generated</summary>
        public DateTime AsOfDate { get; set; }

        /// <summary>Demographic information</summary>
        public AmaDemographics Demographics { get; set; }

        /// <summary>Medical education</summary>
        public List<AmaMedicalSchool> MedicalSchools { get; set; }

        /// <summary>Medical training</summary>
        public List<AmaMedicalTraining> MedicalTraining { get; set; }

        /// <summary>NPI information</summary>
        public List<AmaNpi> Npi { get; set; }

        /// <summary>Medical licenses</summary>
        public List<AmaLicense> Licenses { get; set; }
    }
}