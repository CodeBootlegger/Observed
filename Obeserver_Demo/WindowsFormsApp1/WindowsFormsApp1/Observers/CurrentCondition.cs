using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Subjects;
using System.Drawing;

namespace WindowsFormsApp1.Observers
{
    public class CurrentCondition : iObserver
    {
        private int temperature;
        private int pressure;
        private int humidity;
        private iSubject weatherData;

        public CurrentCondition(iSubject iSub)
        {
            weatherData = iSub;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            (weatherData as WeatherData).groupBox1.BackColor = Color.FromArgb(temperature, pressure, humidity);
        }

        public void update(int temp, int humidity, int pressure)
        {
             temperature = temp;
             this.pressure=pressure;
             this.humidity=humidity;
             display();
     
        }
}
}
