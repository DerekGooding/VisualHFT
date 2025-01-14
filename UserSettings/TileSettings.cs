﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualHFT.Commons.Model;
using VisualHFT.Commons.UserSettings;

namespace VisualHFT.UserSettings
{
    public class TileSettings : ISetting
    {
        public string Symbol { get; set; }
        public Provider Provider { get; set; }
        public AggregationLevel AggregationLevel { get; set; }
    }
}
