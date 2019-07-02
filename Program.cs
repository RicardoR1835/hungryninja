using System;
using System.Collections.Generic;

namespace hungryninja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cals, bool spice, bool sweets){
            Name = name;
            Calories = cals;
            IsSpicy = spice;
            IsSweet = sweets;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Burrito", 1000, true, false),
                new Food("Pasghetti", 1200, true, true),
                new Food("Icecream Sundae", 1000, false, true),
                new Food("Sammich", 2000, true, true),
                new Food("Hot Cheeto tacos", 1000, true, false),
                new Food("Sushi", 1000, true, false),
                new Food("Crazy noodles", 1000, false, true),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            int x = rand.Next(Menu.Count);
            // Console.WriteLine(Menu[x].Name);
            return Menu[x];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // add a public "getter" property called "IsFull"
        public bool isFull 
        {
            get {
                if(calorieIntake > 1200){
                    return true;
                } else {
                    return false;
                }
            }

        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if(isFull == false){
                Console.WriteLine(calorieIntake);
                FoodHistory.Add(item);
                Console.WriteLine($"Ninja ate {item.Name}");
                calorieIntake += item.Calories;
                Console.WriteLine(calorieIntake);
                Console.WriteLine($"Yoo dis ninja ate {item.Name}, if you're wondering if it's spicy: {item.IsSpicy}, and if you're wondering if its sweet: {item.IsSweet}");
            } else {
                Console.WriteLine("Ninja too fullllll");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Buffet menu = new Buffet();
            Food x = menu.Serve();
            Ninja rick = new Ninja();
            Console.WriteLine(rick.isFull);
            rick.Eat(x);
            rick.Eat(x);
            rick.Eat(x);
        
        }
    }
}
