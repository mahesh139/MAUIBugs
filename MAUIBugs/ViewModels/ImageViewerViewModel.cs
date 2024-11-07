using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUIBugs.ViewModels
{
    public partial class ImageViewerViewModel : ObservableObject
    {
        public ImageViewerViewModel()
        {
            this.ImageUrls = new MvvmHelpers.ObservableRangeCollection<string>();

            this.ImageUrls.Add("https://farm2.staticflickr.com/1533/26541536141_41abe98db3_z_d.jpg");
            this.ImageUrls.Add("https://farm4.staticflickr.com/3075/3168662394_7d7103de7d_z_d.jpg");
            this.ImageUrls.Add("https://farm9.staticflickr.com/8505/8441256181_4e98d8bff5_z_d.jpg");
            this.ImageUrls.Add("https://i.imgur.com/OnwEDW3.jpg");
            this.ImageUrls.Add("https://farm3.staticflickr.com/2220/1572613671_7311098b76_z_d.jpg");
        }

        public MvvmHelpers.ObservableRangeCollection<string> ImageUrls { get; set; }
    }
}
