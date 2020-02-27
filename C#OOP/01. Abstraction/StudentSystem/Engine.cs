namespace StudentSystem
{    
    public class Engine
    {
        private readonly StudentData studentData;
        private readonly IInputOutputProvider inputOutputProvider;

        public Engine(StudentData studentData, IInputOutputProvider inputOutputProvider)
        {
            this.studentData = studentData;
            this.inputOutputProvider = inputOutputProvider;
        }

        public void Process()
        {
            var end = false;

            while (!end)
            {
                var line = this.inputOutputProvider.GetInput();

                var command = Command.Parse(line);
                

                end = this.ExecuteCommand(command);
            }
        }

        private bool ExecuteCommand(Command command)
        {
            var name = command.Name;
            var arguments = command.Arguments;

            switch (name)
            {
                case "Create":
                    this.studentData.AddStudent(arguments[0], int.Parse(arguments[1]), double.Parse(arguments[2]));
                    break;
                case "Show":
                    var details = this.studentData.GetStudentDetails(arguments[0]);
                    this.inputOutputProvider.ShowOutput(details);
                    break;
                case "Exit":
                    return true;
            }

            return false;
        }
    }
}