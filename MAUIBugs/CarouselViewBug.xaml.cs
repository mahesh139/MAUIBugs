using MAUIBugs.ViewModels;

namespace MAUIBugs
{
    public partial class CarouselViewBug : ContentPage
    {
        public CarouselViewBug()
        {
            InitializeComponent();
            this.BindingContext = new ImageViewerViewModel();
        }

        private void DeletePhoto_Clicked(object sender, EventArgs e)
        {
            string url = (sender as Button).CommandParameter as string;

            var vm = this.BindingContext as ImageViewerViewModel;

            vm.ImageUrls.Remove(url);
        }

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
