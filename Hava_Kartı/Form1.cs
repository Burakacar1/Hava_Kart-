using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Hava_Kartı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string api = "1615dd7af0bb6f3bbb1cd60c81512db5";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=şırnak&mode=xml&lang=tr&units=metrics&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar= hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label4.Text = sicaklik.ToString();
            label7.Text = ruzgar +" m/s";
            label8.Text = nem + " %";
            label10.Text = durum;
            label11.Text = sicaklik.ToString();


                    
            
        }
    }
}
