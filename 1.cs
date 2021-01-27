using MaterialSkin;
using MaterialSkin.Controls;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ColdhandsAKACaio


namespace try1
{
    public partial class Form1 : MaterialForm
    {
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;


        public Form1()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red600, Primary.Blue800, Accent.Blue700, TextShade.WHITE);

            InitializeComponent();





            string local;
            local = Application.StartupPath;
            local = local.Substring(0, local.LastIndexOf("\\"));
            local = local.Substring(0, local.LastIndexOf("\\"));


            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            if (audioFile == null)
            {
                local += "\\Resources\\Forever.mp3";
                audioFile = new AudioFileReader(local);
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }
     

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;

        }

        private void gerar_Click(object sender, EventArgs e)
        {

            txt1.Text = "";
            textBox1.Text = "";

            int resto1;
            int resto2;



            Random rd = new Random();

              int A = rd.Next(0, 9);
              int B = rd.Next(0, 9);
              int C = rd.Next(0, 9);
              int D = rd.Next(0, 9);
              int E = rd.Next(0, 9);
              int F = rd.Next(0, 9);
              int G = rd.Next(0, 9);
              int H = rd.Next(0, 9);
              int I = rd.Next(0, 9);


            int J = 0;
            int K = 0;

            int mult1 = (A * 10);
            int mult2 = (B * 9);
            int mult3 = (C * 8);
            int mult4 = (D * 7);
            int mult5 = (E * 6);
            int mult6 = (F * 5);
            int mult7 = (G * 4);
            int mult8 = (H * 3);
            int mult9 = (I * 2);



            resto1 = (mult1 + mult2 + mult3 + mult4 + mult5 + mult6 + mult7 + mult8 + mult9) % 11 ;



            if (resto1 == 0 || resto1 == 1 )
            {
                J = 0;
            }


            if(resto1 == 2 || resto1 == 3 || resto1 == 4 || resto1 == 5 || resto1 == 6 || resto1 == 7 || resto1 == 8 || resto1 == 9 || resto1 == 10)
            {
                J = (11 - resto1);
            }



            int mult10 = (A * 11);
            int mult11 = (B * 10);
            int mult12 = (C * 9);
            int mult13 = (D * 8);
            int mult14 = (E * 7);
            int mult15 = (F * 6);
            int mult16 = (G * 5);
            int mult17 = (H * 4);
            int mult18 = (I * 3);
            int mult19 = (J * 2);



            resto2 = (mult10 + mult11 + mult12 + mult13 + mult14 + mult15 + mult16 + mult17 + mult18 + mult19) % 11;



            if (resto2 == 0 || resto2 == 1)
            {
                 K = 0;
            }


            if (resto2 == 2 || resto2 == 3 || resto2 == 4 || resto2 == 5 || resto2 == 6 || resto2 == 7 || resto2 == 8 || resto2 == 9 || resto2 == 10)
            {
                K = (11 - resto2);
            }


            int[] CPF = { A, B, C, D, E, F, G, H, I, J, K };


            foreach (int i in CPF)
            {

                txt1.Text += i.ToString();


            }


            //43 6f 6c 64 68 61 6e 64 73 41 4b 41 43 61 69 6f







































            int resto1cn;
            int resto2cn;



            Random rdf = new Random();

            int Acn = rdf.Next(0, 9);
            int Bcn = rdf.Next(0, 9);
            int Ccn = rdf.Next(0, 9);
            int Dcn = rdf.Next(0, 9);
            int Ecn = rdf.Next(0, 9);
            int Fcn = rdf.Next(0, 9);
            int Gcn = rdf.Next(0, 9);
            int Hcn = rdf.Next(0, 9);
            int Icn = 0;
            int Lcn = 0;
            int Ncn = 0;
            int Ocn = 1;












         //   int Acn = 2;
         //   int Bcn = 7;
         //   int Ccn = 4;
         //   int Dcn = 8;
         //   int Ecn = 6;
         //   int Fcn = 3;
          //  int Gcn = 0;
        //    int Hcn = 9;
         //   int Icn = 0;
         //   int Lcn = 0;
        //    int Ncn = 0;
       //     int Ocn = 1;














            int Jcn = 0;
            int Kcn = 0;

            int mult1cn = (Acn * 5);
            int mult2cn = (Bcn * 4);
            int mult3cn = (Ccn * 3);
            int mult4cn = (Dcn * 2);
            int mult5cn = (Ecn * 9);
            int mult6cn = (Fcn * 8);
            int mult7cn = (Gcn * 7);
            int mult8cn = (Hcn * 6);
            int mult9cn =  (Icn * 5);
            int mult10cn = (Lcn * 4);
            int mult11cn = (Ncn * 3);
            int mult12cn = (Ocn * 2);






            resto1cn = (mult1cn + mult2cn + mult3cn + mult4cn + mult5cn + mult6cn + mult7cn + mult8cn + mult9cn + mult10cn + mult11cn + mult12cn) % 11 ;








            if (resto1cn < 2)
            {
                Jcn = 0;
            }


            if (resto1cn > 1)
            { 
                Jcn = (11 - resto1cn);
            }



            //43 6f 6c 64 68 61 6e 64 73 41 4b 41 43 61 69 6f
            int mult13cn = (Acn * 6);
            int mult14cn = (Bcn * 5);
            int mult15cn = (Ccn * 4);
            int mult16cn = (Dcn * 3);
            int mult17cn = (Ecn * 2);
            int mult18cn = (Fcn * 9);
            int mult19cn = (Gcn * 8);
            int mult20cn = (Hcn * 7);
            int mult21cn = (Icn * 6);
            int mult22cn = (Lcn * 5);
            int mult23cn = (Ncn * 4);
            int mult24cn = (Ocn * 3);
            int mult25cn = (Jcn * 2);



            resto2cn = (mult13cn + mult14cn + mult15cn + mult16cn + mult17cn + mult18cn + mult19cn + mult20cn + mult21cn + mult22cn + mult23cn + mult24cn + mult25cn) % 11;



            if (resto2cn < 2)
            {
                Kcn = 0;
            }


            if (resto2cn > 1)
            {
                Kcn = (11 - resto2cn);
            }




            int[] CNPJ = { Acn, Bcn, Ccn, Dcn, Ecn, Fcn, Gcn, Hcn, Icn, Lcn, Ncn, Ocn, Jcn, Kcn};


            foreach (int x in CNPJ)
            {

                textBox1.Text += x.ToString();


            }























        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt1.MaxLength = 11;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {

                string local;
                local = Application.StartupPath;
                local = local.Substring(0, local.LastIndexOf("\\"));
                local = local.Substring(0, local.LastIndexOf("\\"));


                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                }
                if (audioFile == null)
                {
                    local += "\\Resources\\Forever.mp3";
                    audioFile = new AudioFileReader(local);
                    outputDevice.Init(audioFile);
                }
                outputDevice.Play();

            }

      else
            {

                string local;
                local = Application.StartupPath;
                local = local.Substring(0, local.LastIndexOf("\\"));
                local = local.Substring(0, local.LastIndexOf("\\"));

                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                }
                if (audioFile == null)
                {
                    local += "\\Resources\\Forever.mp3";
                    audioFile = new AudioFileReader(local);
                    outputDevice.Init(audioFile);
                }
                outputDevice.Stop();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // 43 6f 6c 64 68 61 6e 64 73 41 4b 41 43 61 69 6f

        }




        //43 6f 6c 64 68 61 6e 64 73 41 4b 41 43 61 69 6f




        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string local1;
            local1 = Application.StartupPath;
            local1 = local1.Substring(0, local1.LastIndexOf("\\"));
            local1= local1.Substring(0, local1.LastIndexOf("\\"));

                local1 += "\\Resources\\oof.wav";
                SoundPlayer simpleSound = new SoundPlayer(local1);
                simpleSound.Play();
           


   



            System.Diagnostics.Process.Start("https://www.facebook.com/caio.henrique.adc/");
            System.Diagnostics.Process.Start("http://lhohq.info/bob.mp4");
            System.Diagnostics.Process.Start("http://lhohq.info");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

//ColdhandsAKACaio









//01101000 01110100 01110100 01110000 01110011 00111010 00101111 00101111 01100111 01101001 01110100 01101000 01110101 01100010 00101110 01100011 01101111 01101101 00101111 01000011 01101111 01101100 01100100 01101000 01100001 01101110 01100100 01110011 01000001 01001011 01000001 01000011 01100001 01101001 01101111 00101111 01000011 01010000 01000110 00101110 01000011 01001110 01010000 01001010 00101110 01000111 01000101 01001110 01000101 01010010 01000001 01010100 01001111 01010010 00101111 01110100 01110010 01100101 01100101 00101111 01101101 01100001 01101001 01101110 01110100



//68 74 74 70 73 3a 2f 2f 67 69 74 68 75 62 2e 63 6f 6d 2f 43 6f 6c 64 68 61 6e 64 73 41 4b 41 43 61 69 6f 2f 43 50 46 2e 43 4e 50 4a 2e 47 45 4e 45 52 41 54 4f 52 2f 74 72 65 65 2f 6d 61 69 6e 74







//01000011 01101111 01101100 01100100 01101000 01100001 01101110 01100100 01110011 01000001 01001011 01000001 01000011 01100001 01101001 01101111 00001101 00001010





//01000011 01101111 01101100 01100100 01101000 01100001 01101110 01100100 01110011 01000001 01001011 01000001 01000011 01100001 01101001 01101111 00001101 00001010