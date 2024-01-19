using PropertyChanged;

namespace VisualHFT.ViewModel.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Trade : Commons.Model.Trade
    {
        public Trade(Commons.Model.Trade t)
        {
            if (t == null)
                return;
            this.ProviderId = t.ProviderId;
            this.ProviderName = t.ProviderName;
            this.IsBuy = t.IsBuy;
            this.Symbol = t.Symbol;
            this.Size = t.Size;
            this.Price = t.Price;
            this.Flags = t.Flags;
            this.Timestamp = t.Timestamp;
        }
    }
}
