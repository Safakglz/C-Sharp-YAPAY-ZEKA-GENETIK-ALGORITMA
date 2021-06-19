using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Genetik_Algoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double pi11;
        double pi12;
        double pc;
        double pm;
        int iterasyon;
        int seckinsayi;
        List<double> toplamm;
        double buyuk1 = 0;
        double buyuk2 = 0;
       
        
        List<double> seckinsayıı;
        List<int>seckinindis;
        List<double> kucuksayı;
        List<int> kucukindiss;
        List<string> seckinlist;
        List<string> kucuklist;
        int yer1 = 0;
        int yer2 = 0;
       
        
        double toplam = 0;
        
        public void kontrol()
        {
            if ((pi11 < -30 || pi11 > 30))
            {
                pi11 = pi11 * pm;
            }
            if ((pi12 < -30 || pi12 > 30))
            {
                pi12 = pi12 * pm;
            }
           
        }
        public void kucukindis()
        {
          

            for (int i = 0; i < seckinsayi; i++)
            {
                gen.List1.RemoveAt(kucukindiss[i]);
                gen.List1.Add(seckinlist[i]);
                listBox1.Items.RemoveAt(kucukindiss[i]);
                listBox1.Items.Add(seckinlist[i]);

            }
           

        }
        public void degersiz()//seçkinlik sayısı kadar küçük bul
        {
            List<string> gecici = new List<string>();

           

            gecici.AddRange(gen.List2);
            
            for (int i = 0; i < seckinsayi; i++)
            {
                double kucuk = Convert.ToDouble(gecici[0]);
                for (int j = 0; j < gecici.Count; j++)//buyuk bul
                {
                    

                    if (kucuk > Convert.ToDouble(gecici[j]))
                    {

                        kucuk = Convert.ToDouble(gecici[j]);
                        gecici.RemoveAt(j);
                        
                    }


                }
                 //MessageBox.Show("Kucuk:"+kucuk.ToString());
                kucuksayı.Add(kucuk);

            }
            //MessageBox.Show(kucuksayı.Count.ToString());
            for (int i = 0; i < seckinsayi; i++)
            {
                for (int j = 0; j < gen.List2.Count; j++)//buyuk indis bul
               {

                    if (Convert.ToDouble(gen.List2[j]) == kucuksayı[i])
                    {
                       kucukindiss.Add(j);
                       kucuklist.Add(gen.List1[j]);
                        break;
                    }



                }

            }

           // MessageBox.Show(kucukindiss.Count.ToString());
            gecici.Clear();
        }
        public void buyukindisler()
        {
            for (int i = 0; i < gen.List2.Count; i++)//buyuk bul
            {
                double sayı = Convert.ToDouble(gen.List2[i]);

                if (sayı > buyuk1)
                {
                    buyuk2 = buyuk1;
                    buyuk1 = sayı;
                }
                else if (sayı > buyuk2 && sayı < buyuk1)
                {
                    buyuk2 = sayı;
                }
            }
           // MessageBox.Show("Buyuk1:" + buyuk1.ToString());
           // MessageBox.Show("Buyuk2:" + buyuk2.ToString());
            for (int i = 0; i < gen.List2.Count; i++)//buyuk indis bul
            {
                if (Convert.ToDouble(gen.List2[i]) == buyuk1)
                {
                    yer1 = i;

                   
                }
                if (Convert.ToDouble(gen.List2[i]) == buyuk2)
                {
                    yer2 = i;

                }
               

            }
           // MessageBox.Show("Buyuk1 indis:" + yer1.ToString());
           // MessageBox.Show("Buyuk2 indis:" + yer2.ToString());
        }
        public void seckinn()//seçkinlik sayısı kadar büyük bul
        {
            List<string> gecici = new List<string>();

            

            gecici.AddRange(gen.List2);
            for (int i = 0; i < seckinsayi; i++)
            {
                double sayı = Convert.ToDouble(gecici[0]);

                for (int j = 0; j < gecici.Count; j++)//buyuk bul
                {
                    

                    if (sayı < Convert.ToDouble(gecici[j]))
                    {

                        sayı = Convert.ToDouble(gecici[j]);
                        gecici.RemoveAt(j);
                       
                    }


                }
                seckinsayıı.Add(sayı);
                //MessageBox.Show("seçkin:" + sayı.ToString());


            }
            //MessageBox.Show(seckinsayıı.Count.ToString());
            for (int i = 0; i < seckinsayi; i++)
            {
                for (int j = 0; j < gen.List2.Count; j++)//buyuk indis bul
                {
                    
                    if (Convert.ToDouble(gen.List2[j]) == seckinsayıı[i])
                    {
                        seckinindis.Add(j);
                        seckinlist.Add(gen.List1[j]);
                        break;
                    }
                    


                }

            }
            //MessageBox.Show(seckinindis.Count.ToString());
            gecici.Clear();
        }

        public double toplambul()
        {

             toplam = 0;
             for (int i = 0; i< gen.List2.Count; i++)
             {
                 
                toplam += Convert.ToDouble(gen.List2[i]);
                    
             }
             
             return toplam;   
                
        }
        List<double> random;
        public void caprazlama()
        {
            random = new List<double>();
            Random p = new Random();
            for (int i = 0; i < 30; i++)
            {
                
                double P1 = p.NextDouble();
                random.Add(P1);
            }
            
                string gec1 = "";
                string gec2 = "";
                for (int i = 0; i < 30; i++)
                {
                    
                    pi11 = random[i] * (Convert.ToDouble(gen.List1[yer2].ToString().Split(' ')[i])) + (1 - random[i]) * (Convert.ToDouble(gen.List1[yer1].ToString().Split(' ')[i]));
                    pi12 = random[i] * (Convert.ToDouble(gen.List1[yer1].ToString().Split(' ')[i])) + (1 - random[i]) * (Convert.ToDouble(gen.List1[yer2].ToString().Split(' ')[i]));
                    kontrol();
                    if (((pi11 >= -30 && pi11 <= 30) && (pi12 >= -30 && pi12 <= 30)))
                    {
                        
                        pi11 = Math.Round(pi11, 2);
                        pi12 = Math.Round(pi12, 2);
                        gec1 += pi11 + " ";
                        gec2 += pi12 + " ";
                    //MessageBox.Show(P1.ToString() + "   " + P2.ToString() + "   " + pi11.ToString() + "   " + pi12.ToString() + "   " + y11.ToString() + "   " + y12.ToString());

                    

                    }
                    
                    if(i==29)
                    {
                        
                        gen.List1.RemoveAt(0);
                        gen.List1.RemoveAt(1);
                        gen.List1.Add(gec1);
                        gen.List1.Add(gec2);

                        listBox1.Items.RemoveAt(0);
                        listBox1.Items.RemoveAt(1);
                        listBox1.Items.Add(gec1);
                        listBox1.Items.Add(gec2);
                   
                    
                    kucukindis();
                   

                }
                   
                 }
      }
        private void cozbutton_Click(object sender, EventArgs e)//çözüm işlemi yapılmakta
        {
            pm = Convert.ToDouble(numericUpDown4.Value);
            pc = Convert.ToDouble(numericUpDown5.Value);
            seckinsayi = Convert.ToInt32(numericUpDown3.Value);
            iterasyon = Convert.ToInt32(numericUpDown1.Value);
            toplamm = new List<double>();
            seckinsayıı = new List<double>();
            seckinindis = new List<int>();
            kucuksayı = new List<double>();
            kucukindiss = new List<int>();
            seckinlist = new List<string>();
            kucuklist = new List<string>();
            for (int it = 0; it < iterasyon; it++)
            {
                
                gen.List2.Clear();
                listBox2.Items.Clear();
                gen.formulhesap(Convert.ToInt32(numericUpDown2.Value));
                foreach (var item in gen.List2)
                {
                    
                    listBox2.Items.Add(item);
                }
               
                buyukindisler();
                degersiz();
                seckinn();
                toplambul();
                
                toplamm.Add(toplam);
                if(pc>=0.6&&pc<=0.8)
                {
                    caprazlama();
                }

                seckinindis.Clear();
                seckinsayıı.Clear();
                kucukindiss.Clear();
                kucuksayı.Clear();
                seckinlist.Clear();
                kucuklist.Clear();
            }


            cizbutton.Enabled = true;
            cozbutton.Enabled = false;
        }
        Genetik gen = new Genetik();
        private void Form1_Load(object sender, EventArgs e)//random sayı üret
        {
            
           
            cozbutton.Enabled = false;
            cizbutton.Enabled = false;
            degerbutton.Enabled = false;
        }
        int sayı = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sayı == iterasyon-1)
            {
                timer1.Stop();
            }
           
            chart1.Series["Toplam"].Points.AddXY("Toplam" + (sayı+1) + "", toplamm[sayı]);
            
            sayı++;
        }

        private void cizbutton_Click(object sender, EventArgs e)//Grafiği çizdirir
        {
            
            timer1.Start();
            degerbutton.Enabled = true;
            cizbutton.Enabled = false;
        }

        private void degerbutton_Click(object sender, EventArgs e)//kümenin toplam değerindeki minimum maksimum ve en sondaki seckin değerini veriyor
        {
            toplamm.Sort();
            textBox3.Text = toplamm[toplamm.Count - 1].ToString();
            textBox4.Text = toplamm[0].ToString();
            
        degerbutton.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)//formdan çıkar
        {
            Application.Exit();
        }

        private void renk(object sender, EventArgs e)//mouse hover olayı
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aquamarine;
            btn.ForeColor = Color.DimGray;
        }

        private void renk2(object sender, EventArgs e)//mouse leave olayı
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DimGray;
            btn.ForeColor = Color.Aquamarine;
        }

        

        private void button4_Click_1(object sender, EventArgs e)//formu minimize eder
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void doldur_Click(object sender, EventArgs e)
        {
            cozbutton.Enabled = true;
            doldur.Enabled = false;
            gen.randomdeger(Convert.ToInt32(numericUpDown2.Value));
            foreach (var item in gen.List1)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
