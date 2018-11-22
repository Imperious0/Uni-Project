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

            

            RelativeLayout rl_btns = new RelativeLayout();
            rl_btns.HeightRequest = 100;
            

            Button[] btns = new Button[4];
            for (int i = 0; i < btns.GetLength(0); i++)
            {
                btns[i] = new Button();
                btns[i].Text = "Holy Fuck İt Works!";
                btns[i].BackgroundColor = Color.Green;
                btns[i].TextColor = Color.Goldenrod;
                btns[i].WidthRequest = 100;
                btns[i].HeightRequest = 100;
            }
            int button_pad = 10;
            int buttons_width = ((int)this.Width - (btns.GetLength(0)* button_pad)) / btns.GetLength(0);
            
            Console.WriteLine("btn: "+buttons_width + " rl: " + rl.Width);
            for (int i = 0; i < btns.GetLength(0); i++)
            {
                Console.WriteLine("i1: " + i + "\n");
                rl_btns.Children.Add(btns[i],
                Constraint.RelativeToParent((x) => { return x.Width - ((i+1) * btns[i].Width) - (i * button_pad); }),
                Constraint.RelativeToParent((x) => { return 0; }));
                Console.WriteLine("i2: " + i +"\n");
            }




                rl.Children.Add(rl_btns,
        Constraint.RelativeToParent((x) => { return 0; }),
        Constraint.RelativeToParent((x) => { return x.Height - 100; }));

            

            Console.WriteLine("rl next: " + rl.WidthRequest + " rl.wd: " + rl.Width + " rl_btn: " + rl_btns.Width + " rl btns_w: " + rl_btns.WidthRequest);

            this.Content = rl;
        }
    }
}
