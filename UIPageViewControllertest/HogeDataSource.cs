using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UIKit;


namespace UIPageViewControllertest
{
    class HogeDataSource : UIPageViewControllerDataSource
    {
        public List<UIViewController> Pages = new List<UIViewController>();
        public HogeDataSource()
        {
            var redVC = new UIViewController();
            redVC.View.BackgroundColor = UIColor.Red;
            AddDot(redVC);
            Pages.Add(redVC);

            var blueVC = new UIViewController();
            blueVC.View.BackgroundColor = UIColor.Blue;
            AddDot(redVC);
            Pages.Add(blueVC);

            var yellowVC = new UIViewController();
            yellowVC.View.BackgroundColor = UIColor.Yellow;
            AddDot(redVC);
            Pages.Add(yellowVC);

            

        }
        
        public override UIViewController GetPreviousViewController(
            UIPageViewController pageViewController, UIViewController referenceViewController)
        {

            var index = Pages.IndexOf(referenceViewController) - 1;
            if (index < 0)
            {
                //index = (Pages.Count - 1);
                return null;
            }

            return Pages.ElementAt(index);
           
        }
        
        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            var index = Pages.IndexOf(referenceViewController) + 1;
            if (index >= Pages.Count)
            {
                //index = 0;
                return null;
            }

            return Pages.ElementAt(index);
            
        }

        public override nint GetPresentationCount(UIPageViewController pageViewController)
        {
            return Pages.Count;
        }

        public override nint GetPresentationIndex(UIPageViewController pageViewController)
        {

            return Pages.IndexOf(Pages.First());
            //return 0;
        }

        private void AddDot(UIViewController v) {
            UIPageControl pageControl = new UIPageControl();

            pageControl.CurrentPageIndicatorTintColor = UIColor.Blue;
            pageControl.PageIndicatorTintColor = UIColor.Green;
            pageControl.BackgroundColor = UIColor.Orange;

            v.View.AddSubview(pageControl);
        }
    }
}
