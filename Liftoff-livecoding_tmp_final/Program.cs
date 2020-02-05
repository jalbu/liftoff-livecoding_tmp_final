using System;

namespace Liftoff_livecoding_tmp_final
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Halloween is coming, and you need to figure out how much candy to buy.
             Luckily you have tracked the weather, temperature, and number of tricker treaters from years past.
             From your research you have tracked 4 different types of weather: "Clear", "Cloudy", "Raining", "Full Moon"
             From your research you have tracked 4 differnt types of temperature 40s, 50s, 60s, 70s
             
            You get 10% more trick or treaters if the weather is clear
            You get 0% more trick or treaters if the weather is cloudy
             You get 25% less trick or treaters if the weather is rainy
             You get 25% more trick or treaters if the weather is Full Moon
             You get more trick or treaters the warmer the weather
             You get 5% less trick or treaters if it's in the 40s
             You get 0% more trick or treaters if it's in the 50s
             You get 5% more trick or treaters if it's in the 60s
             You get 20% more trick or treaters if its' in the 70s
            
            On average you get 250 trick or treaters, and you want to give each kid 3 pieces of candy.
             
            How much candy do you need to buy if it's clear, and in the 50s?825
            How much candy do you need to buy if it's a full moon, and in the 40s?900
            How much candy do you need to buy if it's raining, and in the 70s?712.5
             */

            double avg = 750;

            double clr = .1;
            double cloudy = 0;
            double rainy = -.25;
            double full = .25;

            double fourties = -.05;
            double fifties = 0;
            double sixties = .05;
            double seventies = .20;

            double total = 0;

            //1
            total = ((avg * clr) + (avg * fifties)) + avg;
            Console.WriteLine("1. Total " + total);

            //2
            total = ((avg * full) + (avg * fourties)) + avg;
            Console.WriteLine("2. Total " + total);

            //3
            total = ((avg * seventies) + (avg * rainy)) + avg;
            Console.WriteLine("3. Total " + total);

            Console.ReadLine();
        }
    }
}
