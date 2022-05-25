using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XMobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            //bt.Text = "owo";
            toast.Source = "toast2";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            toast.Source = "toast5";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            toast.Source = "toast4";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            toast.Source = "toast6";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            toast.Source = "toast1";
        }
    }
}
