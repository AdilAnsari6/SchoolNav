using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SchoolNav.Models;
using SchoolNav.Views;
using SchoolNav.ViewModels;

namespace SchoolNav.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Floor1Page : ContentPage
    {
        Floor1ViewModel viewModel;

        public Floor1Page()
        {
            InitializeComponent();

            BindingContext = viewModel = new Floor1ViewModel();
        }

    }
}