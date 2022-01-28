using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace ForecastUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        const string APP_ID = "518a19df22eb5a31043e51c28c80db40";
        void GetWeatherForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", SearchCity.Text, APP_ID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInformations.root>(json);

                WeatherInformations.root output = result;

                CityName.Text = output.name;
                Country.Text = output.sys.country;

                WeatherMessage.Text = output.weather[0].description;
                Temperature.Text = output.main.temp.ToString() + "\u00B0C";
                Wind.Text = "Wind: " + output.wind.speed.ToString() + " km/h";
                Humidity.Text = "Humidity: " + output.main.humidity.ToString() + "%";


                ShowWeatherImage(output.weather[0].id);
            }
        }

        private void ShowWeatherImage(int weatherId)
        {
            BitmapImage image = new BitmapImage(new Uri("../../../Images/thunderstorm.pg", UriKind.Relative));
            if (weatherId >= 200 && weatherId <= 232)
            {
                image = new BitmapImage(new Uri("../../../Images/thunderstorm.png", UriKind.Relative));
            }
            else if (weatherId >= 300 && weatherId <= 321)
            {
                image = new BitmapImage(new Uri("../../../Images/raindrops.png", UriKind.Relative));
            }
            else if (weatherId >= 500 && weatherId <= 531)
            {
                image = new BitmapImage(new Uri("../../../Images/rain.png", UriKind.Relative));
            }
            else if (weatherId >= 600 && weatherId <= 622)
            {
                image = new BitmapImage(new Uri("../../../Images/snow.png", UriKind.Relative));
            }
            else if (weatherId >= 700 && weatherId <= 781)
            {
                image = new BitmapImage(new Uri("../../../Images/refresh.png", UriKind.Relative));
            }
            else if (weatherId == 800)
            {
                image = new BitmapImage(new Uri("../../../Images/clear_night.png", UriKind.Relative));
            }
            else if (weatherId >= 801 && weatherId <= 804)
            {
                image = new BitmapImage(new Uri("../../../Images/clouds.png", UriKind.Relative));
            }
            WeatherFoto.Source = image;
        }

        private void SearchTask_Click(object sender, RoutedEventArgs e)
        {
            GetWeatherForecast();
        }
    }
}

       
    
