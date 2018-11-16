using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserDemo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            RegistrySetup.SetBrowserFeatureControl();
            Browser.Initialize(webBrowser1);
        }
        
        private void button1_Click(object sender, EventArgs e) {
            //Browser.Wait(3000);

            Browser.Navigate("https://stackoverflow.com/");
            Browser.WaitForId("search");

            var element = Browser.GetElementsByClass("js-search-field", "search")[0];
            Browser.Click(element);
            Browser.SetValue(element, "C# webbrowser");
            Browser.Click("search", "js-search-submit");


            //Browser.Navigate("facebook.pl");
            //Browser.WaitForId("js_3v");

            //var element = Browser.GetElementsByClass("_1mf", "js_3v")[0];
            //Browser.Click(element);
            //Browser.SetValue(element, "Sprzedam Alfę");
            ////Browser.Click("js_3v", "_1mf7");

            ////var elements = Browser.GetElementsByClass("UFILikeLink");
            ////foreach (var el in elements) {
            ////    Browser.Click(el);
            ////}
        }
    }
}
