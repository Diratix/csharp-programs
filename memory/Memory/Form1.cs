using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        bool[] is_button_set = new bool[17];
        Color[] colors = new Color[17];
        bool[] covered = new bool[17];
        bool first_click = true;
        int first_button_number = 0;
        int second_button_number = 0;
        int counter = 0;
        int start;
        int stop;
        int roznica;
        public Form1()
        {
            //start = Environment.TickCount & Int32.MaxValue;
            InitializeComponent();
            random_button(Color.Red);
            random_button(Color.Red);
            random_button(Color.Blue);
            random_button(Color.Blue);
            random_button(Color.Pink);
            random_button(Color.Pink);
            random_button(Color.Green);
            random_button(Color.Green);
            random_button(Color.LightCoral);
            random_button(Color.LightCoral);
            random_button(Color.LightCyan);
            random_button(Color.LightCyan);
            random_button(Color.Brown);
            random_button(Color.Brown);
            random_button(Color.Purple);
            random_button(Color.Purple);

            for(int i=1; i<17; i++)
            {
                covered[i] = true;
            }
            set_button_color();
        }




        //losowanie przycisków i kolorów
        private void random_button (Color color)
        {
            Random generator = new Random();
            int button_number = generator.Next(1, 17);
            while(is_button_set[button_number] == true)
            {
                button_number = generator.Next(1, 17);
            }
            is_button_set[button_number] = true;
            colors[button_number] = color;
        }

        private void check()
        {
            counter++;
            if (colors[first_button_number] == colors[second_button_number])
            {
                MessageBox.Show("Gratulacje, znalazłeś parę!!!");
                covered[first_button_number] = false;
                covered[second_button_number] = false;
            }
            else
            {
                MessageBox.Show("To nie te same kolory. Próbuj dalej.");
            }

            int uncovered = 0;

            for(int u=1; u<17; u++)
            {
                if(covered[u] == false)
                {
                    uncovered++;
                }
            }

            if(uncovered == 16)
            {
                /*stop = Environment.TickCount & Int32.MaxValue;
                roznica = stop - start;*/
                MessageBox.Show("Wielkie gratulacje!!! Odnalazłeś wszystkie pary. Wykonałeś " +counter+ " ruchów/ruchy."/* Twój czas gry wyniósł: "+roznica+" sekund"*/);
            }

        }

        private void set_button_color()
        {
            if (covered[1] == false) { button1.BackColor = colors[1]; } else { button1.BackColor = Color.Gray; }
            if (covered[2] == false) { button2.BackColor = colors[2]; } else { button2.BackColor = Color.Gray; }
            if (covered[3] == false) { button3.BackColor = colors[3]; } else { button3.BackColor = Color.Gray; }
            if (covered[4] == false) { button4.BackColor = colors[4]; } else { button4.BackColor = Color.Gray; }
            if (covered[5] == false) { button6.BackColor = colors[5]; } else { button6.BackColor = Color.Gray; }
            if (covered[6] == false) { button7.BackColor = colors[6]; } else { button7.BackColor = Color.Gray; }
            if (covered[7] == false) { button8.BackColor = colors[7]; } else { button8.BackColor = Color.Gray; }
            if (covered[8] == false) { button9.BackColor = colors[8]; } else { button9.BackColor = Color.Gray; }
            if (covered[9] == false) { button11.BackColor = colors[9]; } else { button11.BackColor = Color.Gray; }
            if (covered[10] == false) { button12.BackColor = colors[10]; } else { button12.BackColor = Color.Gray; }
            if (covered[11] == false) { button13.BackColor = colors[11]; } else { button13.BackColor = Color.Gray; }
            if (covered[12] == false) { button14.BackColor = colors[12]; } else { button14.BackColor = Color.Gray; }
            if (covered[13]== false) { button16.BackColor = colors[13]; } else { button16.BackColor = Color.Gray; }
            if (covered[14] == false) { button17.BackColor = colors[14]; } else { button17.BackColor = Color.Gray; }
            if (covered[15] == false) { button18.BackColor = colors[15]; } else { button18.BackColor = Color.Gray; }
            if (covered[16] == false) { button19.BackColor = colors[16]; } else { button19.BackColor = Color.Gray; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ( button1.BackColor != colors[1] && covered[1] == true)
            {
                button1.BackColor = colors[1];
                if (first_click == true)
                {
                    first_button_number = 1;
                    first_click = false;
                }
                else
                {
                    second_button_number = 1;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != colors[2] && covered[2] == true)
            {
                button2.BackColor = colors[2];
                if (first_click == true)
                {
                    first_button_number = 2;
                    first_click = false;
                }
                else
                {
                    second_button_number = 2;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( button3.BackColor != colors[3] && covered[3] == true)
            {
                button3.BackColor = colors[3];
                if (first_click == true)
                {
                    first_button_number = 3;
                    first_click = false;
                }
                else
                {
                    second_button_number = 3;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( button4.BackColor != colors[4] && covered[4] == true)
            {
                button4.BackColor = colors[4];
                if (first_click == true)
                {
                    first_button_number = 4;
                    first_click = false;
                }
                else
                {
                    second_button_number = 4;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ( button6.BackColor != colors[5])
            {
                button6.BackColor = colors[5];
                if (first_click == true)
                {
                    first_button_number = 5;
                    first_click = false;
                }
                else
                {
                    second_button_number = 5;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(button7.BackColor != colors[6])
            {
                button7.BackColor = colors[6];
                if (first_click == true)
                {
                    first_button_number = 6;
                    first_click = false;
                }
                else
                {
                    second_button_number = 6;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ( button8.BackColor != colors[7])
            {
                button8.BackColor = colors[7];
                if (first_click == true)
                {
                    first_button_number = 7;
                    first_click = false;
                }
                else
                {
                    second_button_number = 7;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ( button9.BackColor != colors[8])
            {
                button9.BackColor = colors[8];
                if (first_click == true)
                {
                    first_button_number = 8;
                    first_click = false;
                }
                else
                {
                    second_button_number = 8;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor != colors[9])
            {
                button11.BackColor = colors[9];
                if (first_click == true)
                {
                    first_button_number = 9;
                    first_click = false;
                }
                else
                {
                    second_button_number = 9;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor != colors[10])
            {
                button12.BackColor = colors[10];
                if (first_click == true)
                {
                    first_button_number = 10;
                    first_click = false;
                }
                else
                {
                    second_button_number = 10;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor != colors[11])
            {
                button13.BackColor = colors[11];
                if (first_click == true)
                {
                    first_button_number = 11;
                    first_click = false;
                }
                else
                {
                    second_button_number = 11;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor != colors[12])
            {
                button14.BackColor = colors[12];
                if (first_click == true)
                {
                    first_button_number = 12;
                    first_click = false;
                }
                else
                {
                    second_button_number = 12;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor != colors[13])
            {
                button16.BackColor = colors[13];
                if (first_click == true)
                {
                    first_button_number = 13;
                    first_click = false;
                }
                else
                {
                    second_button_number = 13;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor != colors[14])
            {
                button17.BackColor = colors[14];
                if (first_click == true)
                {
                    first_button_number = 14;
                    first_click = false;
                }
                else
                {
                    second_button_number = 14;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor != colors[15])
            {
                button18.BackColor = colors[15];
                if (first_click == true)
                {
                    first_button_number = 15;
                    first_click = false;
                }
                else
                {
                    second_button_number = 15;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor != colors[16])
            {
                button19.BackColor = colors[16];
                if (first_click == true)
                {
                    first_button_number = 16;
                    first_click = false;
                }
                else
                {
                    second_button_number = 16;
                    first_click = true;
                    check();
                    set_button_color();
                }
            }
        }
    }
}
