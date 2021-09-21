using System;

namespace Session13First
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius;
            string color;
            double buckets;
            int coverage;
            int cost;
            

            Console.WriteLine("What is the radius of your circle in feet?");
            radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"The area of your circle is {circleArea} feet.");
       
            Console.WriteLine("What color paint would you like to use?");
            color = Console.ReadLine();
            if (color == "red")
            {
                coverage = 100;
                cost = 25;
                buckets = Math.Ceiling(circleArea / coverage);
                Console.WriteLine($"You need {buckets} buckets of {color} paint. It will cost {buckets * cost} dollars.");
            }
            if (color == "blue")
            {
                coverage = 120;
                cost = 28;
                buckets = Math.Ceiling(circleArea / coverage);
                Console.WriteLine($"You need {buckets} buckets of {color} paint. It will cost {buckets * cost} dollars.");
            }
            if (color == "green")
            {
                coverage = 90;
                cost = 33;
                buckets = Math.Ceiling(circleArea / coverage);
                Console.WriteLine($"You need {buckets} buckets of {color} paint. It will cost {buckets * cost} dollars.");
            }
            if (color == "yellow")
            {
                coverage = 70;
                cost = 22;
                buckets = Math.Ceiling(circleArea / coverage);
                Console.WriteLine($"You need {buckets} buckets of {color} paint. It will cost {buckets * cost} dollars.");
            }




            string name;
            string inputAge;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Nice to meet you!");

            if (name.Contains("d") || name.Contains("D"))
            {
                Console.WriteLine("Your name has a D in it.");
            }

            if (name.Length > 10)
            {
                Console.WriteLine("Wow! Your name is long!");
            }

            if (name.Length < 4)
            {
                Console.WriteLine("What a short name.");
            }

            Console.WriteLine($"How old are you {name}?");
            inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);
            Console.WriteLine($"Wow! In 5 years you'll be {age + 5}!");

            int length;
            int width;
            Console.WriteLine($"Hello {name}! What is the length of your garden box?");
            length = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("What is the width of your garden box?");
            width = Convert.ToInt32(Console.ReadLine());

            int perimeter;
            int area;
            perimeter = (length * 2) + (width * 2);            
            area = length * width;
            Console.WriteLine($"The perimeter is {perimeter} feet!");
            Console.WriteLine($"The area is {area} square feet!");

            int carrots = (area * 16/16);
            int corn = (area * 3/16);
            int beets = (area * 9/16);

            Console.WriteLine($"You can plant {carrots} carrots, {corn} corn, or {beets} beets in your garden box.");
        }

    }
}
