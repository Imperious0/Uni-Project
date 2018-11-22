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
            RelativeLayout rl = new RelativeLayout();
            Button bt = new Button();
            bt.Text = "Holy Fuck İt Works!";
            bt.BackgroundColor = Color.Green;
            bt.TextColor = Color.Goldenrod;
            bt.WidthRequest = 100;
            bt.HeightRequest = 100;
            rl.Children.Add(bt,
                    Constraint.RelativeToParent((x) => { return (x.Width / 2) - 50; }),
                    Constraint.RelativeToParent((x) => { return (x.Height / 2) - 50; }));
            this.Content = rl;

        }
    }
}
