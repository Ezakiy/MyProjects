using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp3;


namespace JOGO_DO_REI
{
    public partial class Form1 : Form
    {
        int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Dado D1 = new Dado();
            string x = D1.lancaDado();
            Dado calc = new Dado();
            label6.Text = x;
            String faceSuperior = D1.lancaDado();
            int pontuação = D1.calcPontos();
            String novaFaceSuperior = D1.lancaDado();
            label5.Text = "Ultimo lançamento" + faceSuperior + " (" + (+pontuação + pontuação) + ")";




                switch (x){

                    case "AS":
                        pictureBox1.Image = JOGO_DO_REI.Properties.Resources.AS;
                    break;

                    case "REI":
                         pictureBox1.Image = JOGO_DO_REI.Properties.Resources.s_rei;
                    break;

                    case "DAMA":
                        pictureBox1.Image = JOGO_DO_REI.Properties.Resources.DAMA;
                        break;

                    case "VALETE":
                        pictureBox1.Image = JOGO_DO_REI.Properties.Resources.s_Valete;
                        break;

                    case "DEZ":
                        pictureBox1.Image = JOGO_DO_REI.Properties.Resources.dez;
                        break;

                    case "NOVE":
                        pictureBox1.Image = JOGO_DO_REI.Properties.Resources.nove;
                        break;

                            default: break;

                }

            int calc1 = calc.calcPontos();
            label1.Text = "Face Superior " + faceSuperior;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dado D2 = new Dado();
            string y = D2.lancaDado();
            Dado calc = new Dado();
            label7.Text = y;
            String faceSuperior = D2.lancaDado();
            int pontuação = D2.calcPontos();
            String novaFaceSuperior = D2.lancaDado();
            label5.Text = "Ultimo lançamento" + faceSuperior + " (" + (+pontuação + pontuação) + ")";

            switch (y)
            {

                case "AS":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.AS;
                    break;

                case "REI":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.s_rei;
                    break;

                case "DAMA":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.DAMA;
                    break;

                case "VALETE":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.s_Valete;
                    break;

                case "DEZ":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.dez;

                    break;

                case "NOVE":
                    pictureBox2.Image = JOGO_DO_REI.Properties.Resources.nove;
                    
                    break;
                default:  break;

            }

            int calc1 = calc.calcPontos();
            label2.Text = "Face Superior " + faceSuperior;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Dado D3 = new Dado();
            string z = D3.lancaDado();
            Dado calc = new Dado();
            label8.Text = z;
            String faceSuperior = D3.lancaDado();
            int pontuação = D3.calcPontos();
            String novaFaceSuperior = D3.lancaDado();
            label5.Text = "Ultimo lançamento" + faceSuperior + " (" + (+pontuação + pontuação) + ")";

            switch (z)
            {

                case "AS":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.AS;
                    
                    break;

                case "REI":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.s_rei;
                    
                    break;

                case "DAMA":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.DAMA;
                   
                    break;

                case "VALETE":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.s_Valete;
                    break;

                case "DEZ":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.dez;
                    break;

                case "NOVE":
                    pictureBox3.Image = JOGO_DO_REI.Properties.Resources.nove;
                    break;
                default: break;
            }
            int calc1 = calc.calcPontos();
            label4.Text = "Face Superior " + faceSuperior;

        }



    }
}

   