namespace P18.Login
{
    using System;

    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string correctPassword = "";
            
            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }            
                       
            int counter = 1;

            while (true)
            {
                string password = Console.ReadLine();

                if (password == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                counter++;   
                
            }            
        }
    }
}