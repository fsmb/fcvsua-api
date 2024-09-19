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

namespace Fsmb.Api.FcvsUa.Client.Models
{
    /// <summary>Represents the UCs for an institution or program.</summary>
    /// <summary>Unusual circumstances/summary>
    public class UnusualCircumstances
    {
        /// <summary>Has an interruption/summary>
        public bool HasInterruptions { get; set; }

        /// <summary>Interruption description/summary>
        public string InterruptionsDescription { get; set; }

        /// <summary>Interruption start month/summary>
        public int? InterruptionStartMonth { get; set; }

        /// <summary>Interruption start year/summary>
        public int? InterruptionStartYear { get; set; }

        /// <summary>Interruption end month/summary>
        public int? InterruptionEndMonth { get; set; }

        /// <summary>Interruption end year/summary>
        public int? InterruptionEndYear { get; set; }

        /// <summary>Has a probation/summary>
        public bool HasProbation { get; set; }

        /// <summary>Probation description/summary>
        public string ProbationDescription { get; set; }

        /// <summary>Has an investigation/summary>
        public bool HasInvestigation { get; set; }

        /// <summary>Investigation description/summary>
        public string InvestigationDescription { get; set; }

        /// <summary>Has negative behavior/summary>
        public bool HasBehavior { get; set; }

        /// <summary>Behavior description/summary>
        public string BehaviorDescription { get; set; }

        /// <summary>Has special requirements/summary>
        public bool HasRequirements { get; set; }

        /// <summary>Special requirements description/summary>
        public string RequirementsDescription { get; set; }
    }
}