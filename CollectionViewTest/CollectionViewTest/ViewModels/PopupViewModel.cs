using System.Collections.ObjectModel;

namespace CollectionViewTest.ViewModels
{
    public class PopupViewModel : BaseViewModel
    {
        public ObservableCollection<BaseViewModel> Items { get; set; }

        public PopupViewModel()
        {
            Items = new ObservableCollection<BaseViewModel>
            {
                new BaseViewModel{ Title ="Text 1"},
                new BaseViewModel{ Title ="Text 2"},
                new BaseViewModel{ Title ="Text 3"},
                new BaseViewModel{ Title ="Text 4"},
                new BaseViewModel{ Title ="Text 5"},
                new BaseViewModel{ Title ="Text 6"},
                new BaseViewModel{ Title ="Text 7"},
            };
        }
    }
}