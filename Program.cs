using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = {"Robster Miano", "Smashed Potato Miano","Vegan Sushi" , "Grilled Saimon" };
            double[] price = {256.4, 102.1 , 152.8, 93.9 };
            int john = 150;
            int counter1 = 0;
            int counter2= 0;
            foreach (var food in foods)
            {
                Console.WriteLine($"Food : {food} - Price : {price[counter1++]}$");
                
            }
            Console.WriteLine("John can afford:");
            foreach (var food in foods)
            {
                if(price[counter2++]<john)
                    {   
                        Console.WriteLine(food);
                    }
            }
            
        }
    }
}
