namespace Logger.Models.Contracts
{
    using global::Logger.Models.Enumerations;   

    public interface IAppender
    {
        ILayout Layout { get; }

        Level Level { get; }

        long MessagesAppended { get; }         

        void Append(IError error); 
    }
}