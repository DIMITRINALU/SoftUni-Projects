namespace P45.CakeIngredients
{
    using System;

    class Program
    {
        static void Main()
        {
            var ingredient = Console.ReadLine();

            var ingredientsCount = 0;

            while (ingredient != "Bake!")
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}