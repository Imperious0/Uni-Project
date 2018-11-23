using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Uni_GoyGoy
{
    public class UI
    {
        /* UI Decleration */
        RelativeLayout[] rl_ui;
        RelativeLayout rl_btns;

        Button[] btns;

        int button_padleft = 10;
        int button_padbot = 10;
        int buttons_height = 80;
        int buttons_width;

        public UI()
        {

            rlUI_Init();

            btns = new Button[5];
            btns_Init();


            /***** Initialize Ui for First use *****/
            Login_UI();
            ringTrack_UI();
            hashtagNews();
            studyExams();
            confessions();
            complaints();

        }


        /*********** UI Initialize **********/

        private void rlUI_Init()
        {
            /* rl_ui[0] = Login UI - 
             * rl_ui[1] = ring UI - 
             * rl_ui[2] = hastags UI - 
             * rl_ui[3] = studyexams UI - 
             * rl_ui[4] = hastags UI - 
             * rl_ui[5] = studyexams UI*/

            rl_ui = new RelativeLayout[6];
            for (int i = 0; i < rl_ui.GetLength(0); i++)
                rl_ui[i] = new RelativeLayout();


            rl_btns = new RelativeLayout();
            rl_btns.HeightRequest = 100;

        }

        /*********** end of UI Initialize **********/


        /*********** UI Buttons Initialize **********/

        private void btns_Init()
        {

            buttons_width = ((int)Ekran.Android_Width - (button_padleft * (btns.GetLength(0) + 1))) / btns.GetLength(0);

            Console.WriteLine("width: " + buttons_width);

            for (int i = 0; i < btns.GetLength(0); i++)
            {
                btns[i] = new Button
                {
                    Text = "Holy Fuck! İt Works! " + i,
                    FontSize = 13,
                    BackgroundColor = Color.Green,
                    TextColor = Color.Goldenrod,
                    WidthRequest = buttons_width,
                    HeightRequest = buttons_height
                };
            }

           

            for (int i = 0; i < btns.GetLength(0); i++)
            {
                int c = buttons_width * i;
                int v = (i+1) * button_padleft;
                int k = buttons_height + button_padbot;

                rl_btns.Children.Add(btns[i],
                Constraint.RelativeToParent((x) => { return c + v; }),
                Constraint.RelativeToParent((x) => { return x.Height - k ; }));
            }

        }

        /*********** End of UI Buttons Initialize **********/


        /*********************** Giriş Sistemi Arayüzü ***************************/
        private void Login_UI()
        {

        }

        public RelativeLayout getLogin_UI()
        {
            return rl_ui[0];
        }

        /***********************    Giriş Sistemi Arayüzü Sonu       ***************************/


        /*********************** Ring Takip Sistemi Arayüzü ***************************/

        private void ringTrack_UI()
        {

            rl_ui[1].Children.Add(rl_btns,
            Constraint.RelativeToParent((x) => { return 0; }),
            Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        public RelativeLayout getRing_UI()
        {
            return rl_ui[1];
        }

        /***********************    Ring Takip Sistemi Arayüzü Sonu       ***************************/

        /*********************** Gündem Sistemi Arayüzü ***************************/
        private void hashtagNews()
        {

        }

        public RelativeLayout hashtagNews_UI()
        {
            return rl_ui[0];
        }


        /***********************    Gündem Sistemi Arayüzü Sonu       ***************************/


        /*********************** Ders Notu Sistemi Arayüzü ***************************/
        private void studyExams()
        {

        }

        public RelativeLayout studyExams_UI()
        {
            return rl_ui[0];
        }

        /***********************    Ders Notu Paylaşım Sistemi Arayüzü Sonu       ***************************/


        /*********************** İtiraf Sistemi Arayüzü ***************************/
        private void confessions()
        {

        }

        public RelativeLayout confessions_UI()
        {
            return rl_ui[0];
        }

        /***********************    İtiraf Sistemi Arayüzü Sonu       ***************************/


        /*********************** Şikayet Sistemi Arayüzü ***************************/
        private void complaints()
        {

        }

        public RelativeLayout complaints_UI()
        {
            return rl_ui[0];
        }

        /***********************    Şikayet Sistemi Arayüzü Sonu       ***************************/
    }
}
