namespace FootballTeamGenerator.Common
{
    public static class ExceptionMessages
    {
        public static string InvalidStatExceptionMessage =
            "{0} should be between {1} and {2}.";
        public static string EmptyNameException =
            "A name should not be empty.";
        public static string RemovingMissingPlayerException =
            "Player {0} is not in {1} team.";
        public static string MissingTeamException =
            "Team {0} does not exist.";
    }
}