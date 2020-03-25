namespace Logger.Models.Layouts
{
    using System.Text;

    using global::Logger.Models.Contracts;     

    public class XmlLayout : ILayout
    {
        public string Format => this.GetDataFormat();

        private string GetDataFormat()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine("<log>")
                .AppendLine("<date>{0}</date>")
                .AppendLine("<level>{1}</level>")
                .AppendLine("<message>{2}</message>")
                .AppendLine("</log>");

            return sb.ToString().TrimEnd();
        }
    }
}