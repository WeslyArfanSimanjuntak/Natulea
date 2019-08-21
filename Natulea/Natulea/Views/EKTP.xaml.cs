using Natulea.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Natulea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EKTP : ContentPage
    {
        EKTPViewModel viewModel;
        public EKTP()
        {
            InitializeComponent();
            BindingContext = viewModel = new EKTPViewModel();
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            var nik = EntryNIK.Text;
            if (nik.Count() >= 3)
            {
                if (viewModel == null) {
                    viewModel.LoadItemsCommand.Execute(null);
                }
                viewModel.LoadItemsCommand.Execute(null);
                BindingContext = viewModel;
            }
        }
    }
}