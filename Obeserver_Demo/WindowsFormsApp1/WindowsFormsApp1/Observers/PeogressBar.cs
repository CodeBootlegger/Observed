using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Subjects;

namespace WindowsFormsApp1.Observers
{
    public class PeogressBar : iObserver
    {
        private int temperature;
        private int pressure;
        private int humidity;
        private iSubject weatherData;

        public PeogressBar(iSubject iSub)
        {
            weatherData = iSub;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            (weatherData as WeatherData).progressBar1.Value = this.temperature;
        }

        public void update(int temp, int humidity, int pressure)
        {
            temperature = temp;
            this.pressure = pressure;
            this.humidity = humidity;
            display();

        }
    }
}
