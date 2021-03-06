using Foundation;
using System;
using System.Linq;
using UIKit;

namespace UIPageViewControllertest
{
    public partial class MainView : UIPageViewController
    {
        public MainView (IntPtr handle) : base (handle)
        {
        }
        


        public override void ViewDidLoad()
        {

            base.ViewDidLoad();


            HogeDataSource dataSource = new HogeDataSource();
            DataSource = dataSource;
            

            SetViewControllers(new[] { dataSource.Pages.ElementAt(0) }, UIPageViewControllerNavigationDirection.Forward, true, null);
            changeDot();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
        private void changeDot()
        {
            UIPageControl.UIPageControlAppearance pageControl = UIPageControl.AppearanceWhenContainedIn();

            pageControl.CurrentPageIndicatorTintColor = UIColor.Blue;
            pageControl.PageIndicatorTintColor = UIColor.Green;
            pageControl.BackgroundColor = UIColor.Orange;


        }


    }
}
