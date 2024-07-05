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

namespace Fsmb.Api.Unified.Ama
{
    /// <summary>Medical training</summary>
    public class AmaMedicalTraining
    {
        /// <summary>Name of the program</summary>
        public string ProgramName { get; set; }

        /// <summary>Type of training</summary>
        public string TrainingType { get; set; }

        /// <summary>Name of the institution</summary>
        public string InstitutionName { get; set; }

        /// <summary>State where the institution is located</summary>
        public string InstitutionState { get; set; }

        /// <summary>Date physician entered residency training program</summary>
        public DateTime? BeginDate { get; set; }

        /// <summary>Date physician completed or will complete training program</summary>
        public DateTime? EndDate { get; set; }

        /// <summary>Physician's primary medical specialty based upon accredited graduate medical training program information</summary>
        public string PrimarySpecialty { get; set; }

        /// <summary>Indicates that current residency training is (Being Verified, Not Yet Verified, Being Reverified or Verified by primary source)</summary>
        public string ConfirmationStatus { get; set; }

        /// <summary>Extra messaging pertaining to this medical training record</summary>
        public string AdditionalMessage { get; set; }
    }
}