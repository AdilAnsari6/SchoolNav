using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SchoolNav.ViewModels
{
    public class Floor3ViewModel : BaseViewModel
    {
        public Floor3ViewModel()
        {
            Title = "Floor 3";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
