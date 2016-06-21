using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "4e798cb014a4001e48492d1db9fe9127";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
                + zipCode + ",us&appid=" + key + "&units=imperial";

            dynamic results = await DataServices.getDataFromService(queryString).ConfigureAwait(false);

            Utils util = new Utils();

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                string temperatura = (string)results["main"]["temp"];
                double celcius = util.Celcius(Double.Parse(temperatura));

                string velocidad_viento = (string)results["wind"]["speed"];
                double kilometros = util.Kilometers(Double.Parse(velocidad_viento));

                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F, " + celcius.ToString("0.0#") + " C";
                weather.Wind = (string)results["wind"]["speed"] + " mph, " + kilometros.ToString("0.0#") + " kmh";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }

    }
}
