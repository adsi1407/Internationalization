using System;
using CoreGraphics;
using Internationalization.Core;
using UIKit;

namespace Internationalization.Touch
{
    public class MainViewController: UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            Title = "Internationalization";
            SetupViews();
        }

        private void SetupViews()
        {
            UILabel labelInternationalization = new UILabel();
            labelInternationalization.Frame = new CGRect(10, 100, 300, 50);
            labelInternationalization.Text = CommonStrings.Hello;
            View.AddSubview(labelInternationalization);
        }
    }
}
