namespace MAUIBugs
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(BindableLayoutPickerBug), typeof(BindableLayoutPickerBug));
            Routing.RegisterRoute(nameof(CarouselViewBug), typeof(CarouselViewBug));
            Routing.RegisterRoute(nameof(CollectionViewPickerBug), typeof(CollectionViewPickerBug));
        }
    }
}
