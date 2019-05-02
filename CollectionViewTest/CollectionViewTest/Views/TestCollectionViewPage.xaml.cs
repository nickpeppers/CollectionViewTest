using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestCollectionViewPage : ContentPage
    {
        bool _isRunning;

        public TestCollectionViewPage()
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
                await Navigation.PopAsync();
            }
            finally
            {
                _isRunning = false;
            }
        }
    }
}