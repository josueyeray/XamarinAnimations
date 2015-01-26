using Cirrious.MvvmCross.WindowsCommon.Views;
using Windows.UI.Xaml.Media.Animation;

namespace XamarinAnimations.Win.Views
{
    public sealed partial class FirstView : MvxWindowsPage
    {
        public FirstView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var animation = (Storyboard)this.Resources["TextBlockAnimation"];
            animation.Begin();
        }
    }
}
