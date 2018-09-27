using Foundation;
using Syncfusion.ListView.XForms.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamarinFormsAcordeonListView.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            LoadApplication(new App());

            SfListViewRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
