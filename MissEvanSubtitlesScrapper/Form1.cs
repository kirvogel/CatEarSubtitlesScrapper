using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MissEvanSubtitlesScrapper
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            InitializeComponent();
        }

        private void selectID_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            var link = "https://www.missevan.com/sound/getdm?soundid=" + this.numericUpDown.Value;
            this.PostRequest(link);
        }

        private void PostRequest(string link)
        {
            WebRequest request = WebRequest.Create(link);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            string result = "";
            var dict = new List<Tuple<float, string>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(responseText);
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("d");
            foreach (XmlNode node in nodes)
            {
                string p = node.Attributes["p"].Value;
                string[] numbers = p.Split(',');
                if (numbers[5] != "195") continue;
                float time = float.Parse(numbers[0]);
                dict.Add(Tuple.Create(time, node.InnerText));
            }

            dict.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            foreach(var tuple in dict)
            {
                result += tuple.Item1 + "\r\n\t" + tuple.Item2 + "\r\n\r\n";
            }

            this.resultingText.Text = "";
            this.resultingText.Text = result;
        }
    }
}
