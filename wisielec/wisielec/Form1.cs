using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wisielec
{
    public partial class Form1 : Form
    {
        //zmienne publiczne
        string word;
        int zle = 0;
        int wygrana = 0;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo(); //wpierdolenie tej funkcji w wywołanie
        }

        //skrypt losowania
        void losuj_slowo()
        {
            string[] words = { "KALETA", "PROFIL", "MIŁOŚĆ", "MALARZ", "KOCIAK", "ZESPÓŁ", "LITERA", "JESIEŃ", "LONDYN", "NIEMCY", "POLSKA", "WŁOCHY", "AMANDA", "PRANIE", "SPANIE" };
            int ile_wyrazow = words.Length;
            Random losuj = new Random();
            int ktore_slowo = losuj.Next(0, ile_wyrazow);
            word = words[ktore_slowo];
            //wypisanie 1 i ostatniej
            label1.Text = word.Substring(0, 1);
            label6.Text = word.Substring(5, 1);
        }


        //przycisk
        private void button1_Click(object sender, EventArgs e)
        {
            string zboxa = textBox1.Text;
            bool traf = false;
            int ktora_litera = 0;

            
            for(int i=1; i<5; i++)
            {
                //sprawdzenie czy jest dana litera
                if (Convert.ToString(word[i]) == zboxa)
                {
                    traf = true;
                    ktora_litera = i;
                    wygrana = wygrana + 1;
                }

                //przypisanie trafionej litery
                if (ktora_litera == 1)
                {
                    label2.Text = zboxa;
                }

                if (ktora_litera == 2)
                {
                    label3.Text = zboxa;
                }

                if (ktora_litera == 3)
                {
                    label4.Text = zboxa;
                }

                if (ktora_litera == 4)
                {
                    label5.Text = zboxa;
                }

                
            }

            //wyświetlenie ekranu WON
            if (wygrana == 4)
            {
                pictureBox1.Image = wisielec.Properties.Resources.won;
            }

            //obrazki wisielca
            if (traf == false)
            {
                zle = zle + 1;
                if(zle == 1)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_1;
                }
                if (zle == 2)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_2;
                }
                if (zle == 3)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_3;
                }
                if (zle == 4)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_4;
                }
                if (zle == 5)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_5;
                }
                if (zle == 6)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_6;
                }
                if (zle == 7)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.w_7;
                }
                if(zle >= 8)
                {
                    pictureBox1.Image = wisielec.Properties.Resources.defeat;
                }
            }
        }
    }
}
