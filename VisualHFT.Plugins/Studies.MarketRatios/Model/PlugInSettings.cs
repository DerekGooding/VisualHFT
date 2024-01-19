﻿using VisualHFT.Commons.Model;
using VisualHFT.Commons.UserSettings;

namespace Studies.MarketRatios.Model;

public class PlugInSettings : ISetting
{
    public string Symbol { get; set; }
    public Provider Provider { get; set; }
    public AggregationLevel AggregationLevel { get; set; }
}
