using MAUIBugs.ViewModels;

namespace MAUIBugs
{
    public partial class DrawingViewBug : ContentPage
    {
        public DrawingViewBug()
        {
            InitializeComponent();
            this.BindingContext = new TestViewModel();
        }

        private async void pickerBug_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(BindableLayoutPickerBug));
        }

        private async void carouselBug_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CarouselViewBug));
        }

        private async void collectionViewPickerBug_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CollectionViewPickerBug));
        }
    }
}
