namespace StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            var studentData = new StudentData();
            var inputOutputPrvider = new ConsoleInputOutputProvider(); 

            var engine = new Engine(studentData, inputOutputPrvider);

            engine.Process();
        }
    }
}