using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XamarinAnimations.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
                EdgesForExtendedLayout = UIRectEdge.None;
            }

            var label = new UILabel(new CGRect(10, 100, 300, 60));
            label.Alpha = 0f;
            label.TextColor = UIColor.Blue;
            Add(label);

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(label).To(vm => vm.Hello);
            set.Apply();

            CreateLabelAnimation(label);
        }

        private void CreateLabelAnimation(UILabel label)
        {
            UIView.Animate(0.75, 0, UIViewAnimationOptions.CurveLinear,
            () =>
            {
                label.Alpha = 1f;
            }, null);
            UIView.Animate(1, 0, UIViewAnimationOptions.CurveLinear,
            () =>
            {
                label.Transform = CGAffineTransform.MakeScale(2f, 2f);
            }, null);
            UIView.Animate(0.5, 1, UIViewAnimationOptions.CurveLinear,
            () =>
            {
                label.Transform = CGAffineTransform.MakeScale(1f, 1f);
            }, null);
        }
    }
}