using System;

namespace HelloWorld
{
    class Program
    {
        public class Dog
        {
            string Name = "spot";

            public void sayName()
            {
                Console.WriteLine(Name);
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            
            dog.sayName();
            Random rnd = new Random();
            int num = rnd.Next(1, 11);

            
            bool playing = true;

            while (playing)
            {
                Console.WriteLine("Guess a number!");
                string guess = Console.ReadLine();
                if (int.TryParse(guess, out int x))
                {
                    if (x == num)
                    {
                        Console.WriteLine("Correct");
                        num = rnd.Next(1, 11);
                    }
                    else if (x > num)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (x < num)
                    {
                        Console.WriteLine("Higher");
                    }

                }else{
                    playing = false;
                }
            }

            //if (guess = num){
            //    Console.WriteLine("Correct");
            //}else{
            //    Console.WriteLine("Try Again");
            //}

        }
    }

    
    
}