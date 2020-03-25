namespace Logger.Models.Files
{    
    using System;    
    using System.IO;
    using System.Linq;
    using System.Globalization;
    
    using global::Logger.Models.IOManagement;
    using global::Logger.Models.Contracts;
    using global::Logger.Models.Enumerations;

    public class LogFile : IFile
    {
        private IOManager IOManager;

        public LogFile(string folderName, string fileName)
        {
            this.IOManager = new IOManager(folderName, fileName);
            this.IOManager.EnsureDirectoryAndFileExist();
        }

        public string Path => this.IOManager.CurrentFilePath;

        public long Size => this.GetFileSize();

        /// <summary>
        /// Returns formated message in provided layout with provided error's data
        /// </summary>
        /// <param name="layout"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;

            DateTime dateTime = error.DateTime;

            string message = error.Message;

            Level level = error.Level;

            string formatedMessage = String.Format(format,
                dateTime.ToString("M/dd/yyyy H:mm:ss tt",
                CultureInfo.InvariantCulture),
                message,
                level.ToString());

            return formatedMessage;
        }

        private long GetFileSize()
        {
            string text = File.ReadAllText(this.Path);

            long size = text
                .Where(ch => Char.IsLetter(ch))
                .Sum(ch => ch);

            return size;        
        }
    }
}