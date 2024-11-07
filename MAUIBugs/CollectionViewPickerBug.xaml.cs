using MAUIBugs.ViewModels;

namespace MAUIBugs
{
    public partial class CollectionViewPickerBug : ContentPage
    {
        public CollectionViewPickerBug()
        {
            InitializeComponent();
            this.BindingContext = new BugViewModel();
        }
    }
}
