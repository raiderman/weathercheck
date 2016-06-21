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

namespace App1.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn_get_weather { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_humidity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_location { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_sunrise { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_sunset { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_temperature { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_visibility { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbl_wind_speed { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_zip { get; set; }

        [Action ("Btn_get_weather_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btn_get_weather_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btn_get_weather != null) {
                btn_get_weather.Dispose ();
                btn_get_weather = null;
            }

            if (lbl_humidity != null) {
                lbl_humidity.Dispose ();
                lbl_humidity = null;
            }

            if (lbl_location != null) {
                lbl_location.Dispose ();
                lbl_location = null;
            }

            if (lbl_sunrise != null) {
                lbl_sunrise.Dispose ();
                lbl_sunrise = null;
            }

            if (lbl_sunset != null) {
                lbl_sunset.Dispose ();
                lbl_sunset = null;
            }

            if (lbl_temperature != null) {
                lbl_temperature.Dispose ();
                lbl_temperature = null;
            }

            if (lbl_visibility != null) {
                lbl_visibility.Dispose ();
                lbl_visibility = null;
            }

            if (lbl_wind_speed != null) {
                lbl_wind_speed.Dispose ();
                lbl_wind_speed = null;
            }

            if (txt_zip != null) {
                txt_zip.Dispose ();
                txt_zip = null;
            }
        }
    }
}