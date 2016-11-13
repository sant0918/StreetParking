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

namespace Footprint
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel latitudeView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel longitudeView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

            if (latitudeView != null) {
                latitudeView.Dispose ();
                latitudeView = null;
            }

            if (longitudeView != null) {
                longitudeView.Dispose ();
                longitudeView = null;
            }

            if (pinView != null) {
                pinView.Dispose ();
                pinView = null;
            }

            if (radiusView != null) {
                radiusView.Dispose ();
                radiusView = null;
            }
        }
    }
}