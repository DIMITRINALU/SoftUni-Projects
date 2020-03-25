namespace Logger.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Logger.Models.Contracts;

    public class LayoutFactory
    {
        public ILayout ProduceLayout(string layoutType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == layoutType.ToLower());

            if (type == null)
            {
                throw new ArgumentException("Invalid layout type!");
            }

            object[] arguments = new object[] { };

            ILayout layout = (ILayout)Activator.CreateInstance(type, arguments);

            return layout;
        }
    }
}