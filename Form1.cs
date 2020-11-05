using System;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        cGracz Gracz_1 = new cGracz();
        cGracz Gracz_2 = new cGracz();
        int n = 0;
        cGracz[] Kolejka = new cGracz[2];
        symbol[,] punktacja = new symbol[3, 3];
        bool botGra = false;

        public void fKoniec()
        {
            G1.Enabled = false;
            G2.Enabled = false;
            G3.Enabled = false;
            G4.Enabled = false;
            G5.Enabled = false;
            G6.Enabled = false;
            G7.Enabled = false;
            G8.Enabled = false;
            G9.Enabled = false;

        }

        public void fStart()
        {
            G1.Text = "";
            G1.Enabled = true;
            G2.Text = "";
            G2.Enabled = true;
            G3.Text = "";
            G3.Enabled = true;
            G4.Text = "";
            G4.Enabled = true;
            G5.Text = "";
            G5.Enabled = true;
            G6.Text = "";
            G6.Enabled = true;
            G7.Text = "";
            G7.Enabled = true;
            G8.Text = "";
            G8.Enabled = true;
            G9.Text = "";
            G9.Enabled = true;
        }

        public void fRestart()
        {
            punktacja[0, 0] = 0;
            punktacja[0, 1] = 0;
            punktacja[0, 2] = 0;
            punktacja[1, 0] = 0;
            punktacja[1, 1] = 0;
            punktacja[1, 2] = 0;
            punktacja[2, 0] = 0;
            punktacja[2, 1] = 0;
            punktacja[2, 2] = 0;

        }

        public void fWygrana()
        {
            if (punktacja[0, 0] == punktacja[0, 1] && punktacja[0, 2] == punktacja[0, 0] && punktacja[0, 0] != 0 && punktacja[0, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();
                fKoniec();

            }
            if (punktacja[1, 0] == punktacja[1, 1] && punktacja[1, 0] == punktacja[1, 2] && punktacja[1, 0] != 0 && punktacja[1, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[2, 0] == punktacja[2, 1] && punktacja[2, 0] == punktacja[2, 2] && punktacja[2, 0] != 0 && punktacja[2, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[0, 0] == punktacja[1, 0] && punktacja[2, 0] == punktacja[0, 0] && punktacja[0, 0] != 0 && punktacja[1, 0] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[0, 1] == punktacja[1, 1] && punktacja[2, 1] == punktacja[0, 1] && punktacja[0, 1] != 0 && punktacja[1, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[0, 2] == punktacja[1, 2] && punktacja[2, 2] == punktacja[0, 2] && punktacja[0, 2] != 0 && punktacja[1, 2] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[0, 0] == punktacja[1, 1] && punktacja[2, 2] == punktacja[0, 0] && punktacja[0, 0] != 0 && punktacja[1, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
            if (punktacja[2, 0] == punktacja[1, 1] && punktacja[0, 2] == punktacja[2, 0] && punktacja[2, 0] != 0 && punktacja[1, 1] != 0)
            {
                MessageBox.Show("Wygral gracz " + Kolejka[n].getNazwa());
                Kolejka[n].fIlosc_pkt_1();

                fKoniec();
            }
        }

        public void fBot()
        {

            if (botGra == true)
            {
                Random z1 = new Random();
                Random z2 = new Random();
                for (int i=0;i<9 ;i++ )
                {
                    if (n == 1)
                    {
                        int x = z1.Next(0,3);
                        int y = z2.Next(0,3);


                        if (punktacja[x, y] != Gracz_1.GetSymbol())
                        {

                            if (G1.Text == "" && punktacja[x, y] == punktacja[0, 0])
                            {
                                G1.Text = Gracz_2.GetSymbol().ToString();
                                G1.Enabled = false;
                                break;
                            }
                            else if (G2.Text == "" && punktacja[x, y] == punktacja[0, 1])
                            {
                                G2.Text = Gracz_2.GetSymbol().ToString();
                                G2.Enabled = false;
                                break;
                            }
                            else if (G3.Text == "" && punktacja[x, y] == punktacja[0, 2])
                            {
                                G3.Text = Gracz_2.GetSymbol().ToString();
                                G3.Enabled = false;
                                break;
                            }
                            else if (G4.Text == "" && punktacja[x, y] == punktacja[1, 0])
                            {
                                G4.Text = Gracz_2.GetSymbol().ToString();
                                G4.Enabled = false;
                                break;
                            }
                            else if (G5.Text == "" && punktacja[x, y] == punktacja[1, 1])
                            {
                                G5.Text = Gracz_2.GetSymbol().ToString();
                                G5.Enabled = false;
                                break;
                            }
                            else if (G6.Text == "" && punktacja[x, y] == punktacja[1, 2])
                            {
                                G6.Text = Gracz_2.GetSymbol().ToString();
                                G6.Enabled = false;
                                break;
                            }
                            else if (G7.Text == "" && punktacja[x, y] == punktacja[2, 0])
                            {
                                G7.Text = Gracz_2.GetSymbol().ToString();
                                G7.Enabled = false;
                                break;
                            }
                            else if (G8.Text == "" && punktacja[x, y] == punktacja[2, 1])
                            {
                                G8.Text = Gracz_2.GetSymbol().ToString();
                                G8.Enabled = false;
                                break;
                            }
                            else if (G9.Text == "" && punktacja[x, y] == punktacja[2, 2])
                            {
                                G9.Text = Gracz_2.GetSymbol().ToString();
                                G9.Enabled = false;
                                break;
                            }

                        }

                    }
                    else
                    {
                        break;
                    }
                }
                n = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Gracz_1.setNazwa(textBox1.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Gracz_2.setNazwa(textBox2.Text);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)//USTAW
        {

            TEST.Text = "Gracz 1: " + Gracz_1.getNazwa() + " " + Gracz_1.GetSymbol() +
            "\nGracz 2: " + Gracz_2.getNazwa() + " " + Gracz_2.GetSymbol();

            if (Gracz_1.GetSymbol() == Gracz_2.GetSymbol())
            {
                MessageBox.Show("Gracze muszą mieć rozne symbole!");
            }
            else
            {
                if (Gracz_1.getNazwa() != null && Gracz_1.GetSymbol() != 0 && Gracz_2.getNazwa() != null && Gracz_2.GetSymbol() != 0)
                {
                    Start.Visible = true;
                }
                else
                {
                    TEST.Text = "Gracz 1: " + Gracz_1.getNazwa() + " " + Gracz_1.GetSymbol() +
            "\nGracz 2: " + Gracz_2.getNazwa() + " " + Gracz_2.GetSymbol() + "\nNazwy graczy sa wymagane";
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Gracz_1.setSymbol(symbol.X);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Gracz_1.setSymbol(symbol.O);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Gracz_2.setSymbol(symbol.X);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Gracz_2.setSymbol(symbol.O);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            TEST.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            ustaw.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            Start.Visible = false;
            BOT.Visible = false;


            G1.Visible = true;
            G2.Visible = true;
            G3.Visible = true;
            G4.Visible = true;
            G5.Visible = true;
            G6.Visible = true;
            G7.Visible = true;
            G8.Visible = true;
            G9.Visible = true;
            restart.Visible = true;
            PKT.Visible = true;

            PKT.Text = Gracz_1.getNazwa() + " " + Gracz_1.GetSymbol().ToString() + " " + Gracz_1.getIlosc_wygranych()
        + "\n" + Gracz_2.getNazwa() + " " + Gracz_2.GetSymbol().ToString() + " " + Gracz_2.getIlosc_wygranych();

            Kolejka[0] = Gracz_1;
            Kolejka[1] = Gracz_2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void G1_Click(object sender, EventArgs e)
        {
            G1.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[0, 0] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G1.Enabled = false;
            fBot();

        }
        private void G2_Click(object sender, EventArgs e)
        {
            G2.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[0, 1] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G2.Enabled = false;
            fBot();

        }
        private void G3_Click(object sender, EventArgs e)
        {
            G3.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[0, 2] = Kolejka[n].GetSymbol();
            fWygrana();

            n++;
            if (n == 2) { n = 0; }
            G3.Enabled = false;
            fBot();

        }
        private void G4_Click(object sender, EventArgs e)
        {
            G4.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[1, 0] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G4.Enabled = false;
            fBot();

        }
        private void G5_Click(object sender, EventArgs e)
        {
            G5.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[1, 1] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G5.Enabled = false;
            fBot();

        }
        private void G6_Click(object sender, EventArgs e)
        {
            G6.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[1, 2] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G6.Enabled = false;
            fBot();

        }
        private void G7_Click(object sender, EventArgs e)
        {
            G7.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[2, 0] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G7.Enabled = false;
            fBot();

        }
        private void G8_Click(object sender, EventArgs e)
        {
            G8.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[2, 1] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G8.Enabled = false;
            fBot();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            G9.Text = Kolejka[n].GetSymbol().ToString();
            punktacja[2, 2] = Kolejka[n].GetSymbol();
            fWygrana();
            n++;
            if (n == 2) { n = 0; }
            G9.Enabled = false;
            fBot();

        }

        private void restart_Click(object sender, EventArgs e)
        {
            fStart();
            fRestart();
            PKT.Text = Gracz_1.getNazwa() + " " + Gracz_1.GetSymbol().ToString() + " " + Gracz_1.getIlosc_wygranych()
        + "\n" + Gracz_2.getNazwa() + " " + Gracz_2.GetSymbol().ToString() + " " + Gracz_2.getIlosc_wygranych();

        }

        private void PKT_Click(object sender, EventArgs e)
        {

        }

        private void BOT_Click(object sender, EventArgs e)
        {
            botGra = true;
            Gracz_2.setNazwa("Bot");

            if (Gracz_1.GetSymbol() == symbol.X)
            {
                Gracz_2.setSymbol(symbol.O);
            }
            if (Gracz_1.GetSymbol() == symbol.O)
            {
                Gracz_2.setSymbol(symbol.X);
            }

            textBox2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}
