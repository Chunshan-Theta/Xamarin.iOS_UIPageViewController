// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace UIPageViewControllertest
{
    [Register ("ContentForPageView")]
    partial class ContentForPageView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl PageControl1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PageControl1 != null) {
                PageControl1.Dispose ();
                PageControl1 = null;
            }
        }
    }
}