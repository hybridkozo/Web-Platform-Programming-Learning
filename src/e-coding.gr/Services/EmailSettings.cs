﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_coding.gr.Services
{
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string BaseUri { get; set; }
        public string RequestUri { get; set; }
        public string From { get; set; }
    }
}
