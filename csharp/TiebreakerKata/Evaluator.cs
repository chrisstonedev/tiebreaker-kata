namespace TiebreakerKata;

public static class Evaluator
{
    public static IEnumerable<string[]> GetRecordsUntilDate(DateTime dateTime)
    {
        var lines = File.ReadAllLines("2021-22-season.csv");
        var records = lines.Skip(1).ToArray();
        var separated = records.Select(x => x.Split(','));
        return separated.Where(x => string.CompareOrdinal(x[0], dateTime.ToString("yyyy-MM-dd")) <= 0);
    }

    public static IEnumerable<string> GetStandings(IEnumerable<string[]> allGames, Division division)
    {
        var teamsToReport = TeamMethods.GetTeams(division);

        return GetStandings(allGames, teamsToReport);
    }

    public static IEnumerable<string> GetStandings(IEnumerable<string[]> allGames, Conference conference)
    {
        var teamsToReport = TeamMethods.GetTeams(conference);

        return GetStandings(allGames, teamsToReport);
    }

    private static IEnumerable<string> GetStandings(IEnumerable<string[]> gameRecords, IEnumerable<string> teamsToReport)
    {
        return teamsToReport;
    }
}

public enum Division
{
    Atlantic,
    Central,
    Southeast,
    Northwest,
    Pacific,
    Southwest,
}

public enum Conference
{
    Western,
    Eastern,
}

public static class TeamMethods
{
    private static readonly List<(string Team, Division Division, Conference Conference)> Teams = new()
    {
        ("BOS", Division.Atlantic, Conference.Eastern),
        ("BKN", Division.Atlantic, Conference.Eastern),
        ("NYK", Division.Atlantic, Conference.Eastern),
        ("PHI", Division.Atlantic, Conference.Eastern),
        ("TOR", Division.Atlantic, Conference.Eastern),
        ("CHI", Division.Central, Conference.Eastern),
        ("CLE", Division.Central, Conference.Eastern),
        ("DET", Division.Central, Conference.Eastern),
        ("IND", Division.Central, Conference.Eastern),
        ("MIL", Division.Central, Conference.Eastern),
        ("ATL", Division.Southeast, Conference.Eastern),
        ("CHA", Division.Southeast, Conference.Eastern),
        ("MIA", Division.Southeast, Conference.Eastern),
        ("ORL", Division.Southeast, Conference.Eastern),
        ("WAS", Division.Southeast, Conference.Eastern),
        ("DEN", Division.Northwest, Conference.Western),
        ("MIN", Division.Northwest, Conference.Western),
        ("OKC", Division.Northwest, Conference.Western),
        ("POR", Division.Northwest, Conference.Western),
        ("UTA", Division.Northwest, Conference.Western),
        ("GSW", Division.Pacific, Conference.Western),
        ("LAC", Division.Pacific, Conference.Western),
        ("LAL", Division.Pacific, Conference.Western),
        ("PHX", Division.Pacific, Conference.Western),
        ("SAC", Division.Pacific, Conference.Western),
        ("DAL", Division.Southwest, Conference.Western),
        ("HOU", Division.Southwest, Conference.Western),
        ("MEM", Division.Southwest, Conference.Western),
        ("NOP", Division.Southwest, Conference.Western),
        ("SAS", Division.Southwest, Conference.Western),
    };

    public static IEnumerable<string> GetTeams(Conference conference)
    {
        return Teams.Where(x => x.Conference == conference).Select(x => x.Team);
    }

    public static IEnumerable<string> GetTeams(Division division)
    {
        return Teams.Where(x => x.Division == division).Select(x => x.Team);
    }
}