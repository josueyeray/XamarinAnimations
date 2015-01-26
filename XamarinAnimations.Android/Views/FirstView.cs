using Android.App;
using Android.OS;
using Android.Views.Animations;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;

namespace XamarinAnimations.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            Animation textAnimation = AnimationUtils.LoadAnimation(Application.ApplicationContext, 
                                                                    Resource.Drawable.TextAnimation);
            TextView textHello = FindViewById<TextView>(Resource.Id.TextHello);
            textHello.StartAnimation(textAnimation);
        }
    }
}