using System.Collections.ObjectModel;
using VisualHFT.Commons.Model;

namespace VisualHFT.Commons.DataTradeRetriever;

public interface IDataTradeRetriever
{
    event EventHandler<IEnumerable<Order>> OnInitialLoad;
    event EventHandler<IEnumerable<Order>> OnDataReceived;
    DateTime? SessionDate { get; set; }

    ReadOnlyCollection<Order> Orders { get; }
    ReadOnlyCollection<Position> Positions { get; }
}
