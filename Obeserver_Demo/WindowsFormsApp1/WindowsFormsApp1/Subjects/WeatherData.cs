using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Observers;

namespace WindowsFormsApp1.Subjects
{
    public class WeatherData : iSubject
    {
        List<iObserver> observers;
        private int temperature;
        private int pressure;
        private int humidity;
        public GroupBox groupBox1 { get; set; }
        public ProgressBar progressBar1 { get; set; }
        public WeatherData()
        {
            observers = new List<iObserver>();
        }
        public void notifyObserver()
        {
            foreach (iObserver obs in observers)
            {
                obs.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(iObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(iObserver o)
        {
            observers.Remove(o);
        }

        public void messurementsChanges()
        {
            notifyObserver();
        }

        public void setMeasurments(int temp, int _humidity, int _pressure, GroupBox groupBox1,ProgressBar progressBar1)
        {
            temperature = temp;
            humidity = _humidity;
            pressure = _pressure;
            this.groupBox1 = groupBox1;
            this.progressBar1 = progressBar1;
            this.progressBar1.Maximum = 255;
            messurementsChanges();
            

        }
    }
}
