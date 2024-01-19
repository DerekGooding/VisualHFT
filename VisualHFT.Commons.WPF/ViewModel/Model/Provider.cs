using PropertyChanged;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using VisualHFT.Commons.Helpers;

namespace VisualHFT.Commons.WPF.ViewModel.Model;

[AddINotifyPropertyChangedInterface]
public class Provider : Commons.Model.Provider, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public static ObservableCollection<Provider> CreateObservableCollection()
    {

        return new ObservableCollection<Provider>(HelperProvider.Instance.ToList().Select(x => new Provider(x)));

    }
    public Provider()
    {

    }
    public Provider(Commons.Model.Provider p)
    {
        ProviderID = p.ProviderID;
        ProviderCode = p.ProviderCode;
        ProviderName = p.ProviderName;
        Status = p.Status;
        LastUpdated = p.LastUpdated;
        Plugin = p.Plugin;
    }
    public void UpdateUI()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Status"));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StatusImage"));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tooltip"));
    }
}
