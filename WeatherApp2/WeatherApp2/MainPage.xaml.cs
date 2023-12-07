using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WeatherApp2.Models;

namespace WeatherApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Weather> Weathers { get=>WeatherData(); }
        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "22", Date = "Domingo 16", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Lunes 17", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Martes 18", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "12", Date = "Miercoles 19", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "17", Date = "Jueves 20", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Viernes 21", Icon = "weather.png" });

            return tempList;
        }
    }    
}
