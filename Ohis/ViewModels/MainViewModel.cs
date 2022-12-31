using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Ohis.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        public void Add()
        {
            Text = "Clicked";
        }

        public MainViewModel()
        {
        }
    }
}
