using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SchoolNav.ViewModels
{
    public class Floor2ViewModel : BaseViewModel
    {
        public Floor2ViewModel()
        {
            Title = "Floor 2";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}