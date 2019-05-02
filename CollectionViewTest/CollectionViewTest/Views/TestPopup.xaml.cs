using System.Collections.ObjectModel;
using CollectionViewTest.ViewModels;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace CollectionViewTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPopup : PopupPage
    {
        bool _isRunning;

        public TestPopup()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (_isRunning)
                return;

            _isRunning = true;

            try
            {
                await PopupNavigation.Instance.PopAsync();
            }
            finally
            {
                _isRunning = false;
            }
        }
    }
}