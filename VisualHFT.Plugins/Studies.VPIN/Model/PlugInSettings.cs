using VisualHFT.Commons.Model;
using VisualHFT.Commons.UserSettings;

namespace Studies.VPIN.Model;

public class PlugInSettings : ISetting
{
    public double BucketVolSize { get; set; }
    public string Symbol { get; set; }
    public Provider Provider { get; set; }
    public AggregationLevel AggregationLevel { get; set; }
}
