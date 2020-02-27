namespace StudentSystem
{
    using System;

    public class ConsoleInputOutputProvider : IInputOutputProvider
    {
        public string GetInput() => Console.ReadLine();

        public void ShowOutput(string data) => Console.WriteLine(data);
    }
}