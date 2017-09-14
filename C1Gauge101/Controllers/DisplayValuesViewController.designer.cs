// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace C1Gauge101
{
    [Register ("DisplayValuesViewController")]
    partial class DisplayValuesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        C1Gauge101.iOS.C1TextField Entry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        C1.iOS.Gauge.C1LinearGauge LinearGauge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        C1.iOS.Gauge.C1RadialGauge RadialGauge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper Stepper { get; set; }

        [Action ("OnValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnValueChanged (UIKit.UIStepper sender);

        void ReleaseDesignerOutlets ()
        {
            if (Entry != null) {
                Entry.Dispose ();
                Entry = null;
            }

            if (LinearGauge != null) {
                LinearGauge.Dispose ();
                LinearGauge = null;
            }

            if (RadialGauge != null) {
                RadialGauge.Dispose ();
                RadialGauge = null;
            }

            if (Stepper != null) {
                Stepper.Dispose ();
                Stepper = null;
            }
        }
    }
}