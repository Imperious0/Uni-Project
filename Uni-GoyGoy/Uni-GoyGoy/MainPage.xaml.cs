using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Uni_GoyGoy
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();
            this.BackgroundColor = Color.White;
            UI screen = new UI();

            this.Content = screen.getRing_UI();
        }
    }
}
