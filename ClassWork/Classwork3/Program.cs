﻿using System;

namespace Classwork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int b =1;
            for (int i = 5; i >=1; i--)
            {
            b = b *i;
            }
          #region Sonsuz saat dovru  
            for(; ;)
            // ve ya for (; 1==1;)
            // ve ya (; true;)
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
             # endregion
                 
           #region while Loop
               double i = 5;
                           
               while (i>=0)
               {
               Console.WriteLine(i);
                   i = i -1.5;
               }
               
            #endregion
                
            #region do while loop
                double i=0;
               do
               {
                 Console.WriteLine (i );
               } while (i>0)
            
             #endregion
                   
                   
           #region example1
                   
            // 4reqemli eded verilib, bu ededin evveline 7 reqemini , axirina 8 reqemini artir, mes: 3333 = 73338
                   
           int x = 3333; 
            
           // 4reqemli oldugunu yoxlayaq
            
           if (x >=1000 && a< 10000)
           {
            x = 70000+x; // 73333
            x = x *10; // 733330
            x = x + 8; 
            // bu ikisini qisaldib bele yazmaq olar: x *= 10
          // x += 8;
           }                   
           #endregion
               
               
          #region example2
            
          // 3 reqemli eded verilib. Bu ededin axirina hemin ededin ozunu yapishdir. example: 333 = 333333     
               
         //3reqemli oldugunu yoxlayaq
               
           int t = 333;
            int e = 0;
            if (t>=100 && t<1000)
            {
                e *= 1000;
                e = e+t
               // asagi xette dusende t-nin qiymeti deyiser deye t = t *1000 +t  olarsa onda istenilen cavab alinacaq. amma t = t *1000 yazib asagi xette dusub t = t + t yazsaydiq ferqli cavab alacaydiq
                    Console.WriteLine(e)
            }
               
               
          #endregion
                   
          #region istifadeci terefinden daxil edilmesi
              Console.Write("Adinizi daxil edin");
              string name = Console.ReadLine()
              Console.Write("Soyadinizi daxil edin")
              string surname = Console.ReadLine()
              string message = $"salam {name} {surname}!";
            Console.Clear();
            
            Console.WriteLine (message);
            
           #endregion
               
        #region basicCalc
               
           Console.Write ("a-ni daxil edin");
         double k = Convert.ToDouble (Console.ReadLine());
            
            Console.Write ("Emeliyyati Secin: ( +, -, *, / ) ");
            string @operator = Console.ReadLine();
            
            
            Console.Write ("b-ni daxil edin");
            double y = Convert.ToDouble(Console.ReadLine());
            
            
            double z = 0;
            
            
            if (@operator == "+")
            {
              z = k + y;  
            }
             
             else if (@operator == "-")
            {
              z = k - y;  
            }
            
            else if (@operator == "/")
            {
              z = k / y;  
            }
            
            else if (@operator == "*")
            {
              z = k * y;  
            }
            
            else {
               Console.WriteLine ("duzgun secim deyil");
            }
            
            Console.WriteLine ($"{k} {@operator} {y} = {z}")
                
         #endregion
               
               
               
        }
    }
}
