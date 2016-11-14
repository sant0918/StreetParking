<<<<<<< Updated upstream
﻿// WARNING
=======
// WARNING
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        UIKit.UILabel latitudeView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel longitudeView { get; set; }

        void ReleaseDesignerOutlets ()
        {
=======
        UIKit.UILabel gpsView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (gpsView != null) {
                gpsView.Dispose ();
                gpsView = null;
            }

>>>>>>> Stashed changes
            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

<<<<<<< Updated upstream
            if (latitudeView != null) {
                latitudeView.Dispose ();
                latitudeView = null;
            }

            if (longitudeView != null) {
                longitudeView.Dispose ();
                longitudeView = null;
            }

=======
>>>>>>> Stashed changes
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