﻿using System;

namespace loopsForBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            int sayac=int.Parse(Console.ReadLine());

            for (int i = 1 ; i<= sayac; i++){
                if(i%2 ==1){
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0 ;
            for(int i = 1 ; i<=1000; i++){
                if(i%2 ==1){
                    tekToplam+=i;

                }
                else{
                    ciftToplam+=i;
                }

            }
            Console.WriteLine("tekToplam : " + tekToplam);
            Console.WriteLine("Çift Toplam : " + ciftToplam );


            for (int i =1 ; i<10 ; i++){
                if(i==4)
                    continue;
                    //break;
                Console.WriteLine(i);
            }
        }
    }
}
