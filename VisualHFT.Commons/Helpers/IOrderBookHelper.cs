using VisualHFT.Commons.Model;

namespace VisualHFT.Commons.Helpers;

public interface IOrderBookHelper
{
    //event EventHandler<OrderBook> OnDataReceived;
    void Subscribe(Action<OrderBook> processor);
    void UpdateData(IEnumerable<OrderBook> data);
}
