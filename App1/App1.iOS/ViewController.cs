using System;

using UIKit;

namespace App1.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			/*Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!", count++);
				Button.SetTitle (title, UIControlState.Normal);
			};*/
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        private async void Btn_get_weather_Click(UIButton sender)
        {
            if (!String.IsNullOrEmpty(txt_zip.Text))
            {
                Weather weather = await Core.GetWeather(txt_zip.Text);
                lbl_location.Text = weather.Title;
                lbl_temperature.Text = weather.Temperature;
                lbl_wind_speed.Text = weather.Wind;
                lbl_visibility.Text = weather.Visibility;
                lbl_humidity.Text = weather.Humidity;
                lbl_sunrise.Text = weather.Sunrise;
                lbl_sunset.Text = weather.Sunset;

                btn_get_weather.SetTitle("Search Again", UIControlState.Normal);
            }

        }

        partial void Btn_get_weather_TouchUpInside(UIButton sender)
        {
            Btn_get_weather_Click(sender);
        }
    }
}

