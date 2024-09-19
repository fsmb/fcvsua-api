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

namespace Fsmb.Api.FcsvUa.Client.Models
{
    /// <summary>FCVS profile information/summary>
    public class FcvsProfileReport
    {
        /// <summary>Profile ID/summary>
        public long ProfileId { get; set; }

        /// <summary>Profile status/summary>
        public string ProfileStatus { get; set; }

        /// <summary>Profile submission date/time, in UTC/summary>
        public DateTime ProfileSubmitDateUtc { get; set; }

        /// <summary>Profile sent date/time, in UTC, if any/summary>
        public DateTime? ProfileSentDateUtc { get; set; }

        /// <summary>Determines if the profile has been sent/summary>
        public bool HasBeenSent { get; set; }
    }
}