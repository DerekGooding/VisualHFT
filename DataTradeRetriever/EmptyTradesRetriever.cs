using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using VisualHFT.Helpers;
using QuickFix.Fields;
using QuickFix.DataDictionary;
using System.Windows.Shapes;
using VisualHFT.Commons.DataTradeRetriever;
using VisualHFT.Commons.Model;


namespace VisualHFT.DataTradeRetriever
{
    public class EmptyTradesRetriever : IDataTradeRetriever, IDisposable
    {
        private List<Position> _positions;
        private List<Order> _orders;
        int _providerId;
        string _providerName;
        DateTime? _sessionDate = null;

        private bool _disposed = false;

        public event EventHandler<IEnumerable<Order>> OnInitialLoad;
        public event EventHandler<IEnumerable<Order>> OnDataReceived;
        protected virtual void RaiseOnInitialLoad(IEnumerable<Order> ord) => OnInitialLoad?.Invoke(this, ord);
        protected virtual void RaiseOnDataReceived(IEnumerable<Order> ord) => OnDataReceived?.Invoke(this, ord);
        public EmptyTradesRetriever()
        {
            _positions = new List<Position>();
            _orders = new List<Order>();
        }
        ~EmptyTradesRetriever()
        {
            Dispose(false);
        }
        public DateTime? SessionDate
        {
            get { return _sessionDate; }
            set
            {
                if (value != _sessionDate)
                {
                    _sessionDate = value;
                    _orders.Clear();
                    RaiseOnInitialLoad(this.Orders);
                }
            }
        }
        public ReadOnlyCollection<Order> Orders
        {
            get { return _orders.AsReadOnly(); }
        }
        public ReadOnlyCollection<Position> Positions
        {
            get { return _positions.AsReadOnly(); }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {}
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
