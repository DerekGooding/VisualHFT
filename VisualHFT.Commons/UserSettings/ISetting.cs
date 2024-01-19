using VisualHFT.Commons.Model;

namespace VisualHFT.Commons.UserSettings;

public interface ISetting
{
    string Symbol { get; set; }
    Provider Provider { get; set; }
    AggregationLevel AggregationLevel { get; set; }
}
