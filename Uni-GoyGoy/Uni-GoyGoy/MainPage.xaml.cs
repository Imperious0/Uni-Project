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
        Button[] btns = new Button[4];
        public MainPage()
        {

            InitializeComponent();
            this.BackgroundColor = Color.White;
            RelativeLayout rl = new RelativeLayout();

            

            RelativeLayout rl_btns = new RelativeLayout();
            rl_btns.HeightRequest = 100;
            


            for (int i = 0; i < btns.GetLength(0); i++)
            {
                btns[i] = new Button
                {
                    Text = "Holy Fuck İt Works! " + i,
                    BackgroundColor = Color.Green,
                    TextColor = Color.Goldenrod,
                    WidthRequest = 80,
                    HeightRequest = 100
                };
            }

            int button_pad = 10;

            for (int i = 0; i < btns.GetLength(0); i++)
            {
                int c = (i * (int)btns[i].WidthRequest);
                int v = i * button_pad;
                rl_btns.Children.Add(btns[i],
                Constraint.RelativeToParent((x) => { return c+v; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            }




            rl.Children.Add(rl_btns,
            Constraint.RelativeToParent((x) => { return 0; }),
            Constraint.RelativeToParent((x) => { return x.Height - 100; }));


            this.Content = rl;
        }
    }
}
