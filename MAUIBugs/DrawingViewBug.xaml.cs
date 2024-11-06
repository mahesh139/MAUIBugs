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
    }
}
