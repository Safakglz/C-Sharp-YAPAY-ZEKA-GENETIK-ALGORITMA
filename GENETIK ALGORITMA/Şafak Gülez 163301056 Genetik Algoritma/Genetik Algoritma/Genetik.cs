using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Genetik_Algoritma
{
    
    public class Genetik
    {
        private double x;
        
        private double formul;
      
        private List<string> list1;
        private List<string> list2;

      
        public double X { get => x; set => x = value; }
        
        public double Formul { get => formul; set => formul = value; }
       
        public  List<string> List1 { get => list1; set => list1 = value; }
        public List<string> List2 { get => list2; set => list2 = value; }
        

        public Genetik()
        {
            List1 = new List<string>();
            List2 = new List<string>();
        }
        public Genetik(List<string> List1)
        {
            this.List1 = List1;
        }

        public void formulhesap(int pop)
        {



            for (int i = 0; i < List1.Count; i++)
            {
                Formul = 0;
                for (int j = 1; j < 30; j++)
                {
                    Formul += (100 * Math.Pow((Convert.ToDouble(List1[i].ToString().Split(' ')[j-1])-Math.Pow((Convert.ToDouble(List1[i].ToString().Split(' ')[j])),2)),2)+
                     Math.Pow((Convert.ToDouble(List1[i].ToString().Split(' ')[j])-1), 2));
                }
                
                List2.Add(Formul.ToString());
            }
               
        }



        
        
                
               
                
                
                

            
     public void randomdeger(int pop)//belirtilen aralıkta random deger üret
        {
           
            Random rnd = new Random();
           
            
            for (int i = 0; i < pop; i++)
            {
                string gec = "";
                for (int j = 0; j < 30; j++)
                {
                    double x = rnd.NextDouble();
                    double gx = -30 +x * (30 - (-30));
                    gx = Math.Round(gx, 2);
                    gec += gx + " ";
                }
               

                
                List1.Add(gec);
                
            }
           
        }

        
    }
}
