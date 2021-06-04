using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicMvvm
{
    public class MainPageViewModel : BaseViewModel
    {

        private readonly ApiClient _myApiClient;

        public ObservableCollection<MyDataViewModel> Items = new();

        public MainPageViewModel()
        {
            _myApiClient = new ApiClient();
        }


        public async Task Appearing()
        {
            IsBusy = true;
            var data = await _myApiClient.GetItemsAsync();
            if (data is null)
            {
                return;
            }

            Device.BeginInvokeOnMainThread(() =>
            {
                Items.Clear();
                foreach (var item in data)
                {
                    Items.Add(new MyDataViewModel(item.Key, item.Value));
                }
                IsBusy = false;
            });
        }

    }
}
