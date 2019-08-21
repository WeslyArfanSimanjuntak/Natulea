using Natulea.Models;
using Natulea.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Natulea.ViewModels
{
    public class EKTPViewModel : BaseViewModel
    {
        public Content Content { get; set; }
        public Command LoadItemsCommand { get; set; }

        public EKTPViewModel()
        {
            Title = "Browse";
            Content = new Content();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var item = await this.EKTPDataStore.GetEKTPItemAsync("1212231402940001");
                this.Content = item;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
