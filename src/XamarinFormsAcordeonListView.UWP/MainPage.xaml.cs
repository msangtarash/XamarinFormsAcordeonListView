using Syncfusion.ListView.XForms.UWP;

namespace XamarinFormsAcordeonListView.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new XamarinFormsAcordeonListView.App());

            SfListViewRenderer.Init();
        }
    }
}
