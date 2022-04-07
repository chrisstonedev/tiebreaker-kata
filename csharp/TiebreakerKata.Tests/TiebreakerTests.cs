using System;
using System.Linq;
using NUnit.Framework;

namespace TiebreakerKata.Tests;

public class TiebreakerTests
{
    [Test]
    public void NoTiesToBreak()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2022, 3, 14));

        var expected = new[]
            {"MIA", "MIL", "PHI", "CHI", "BOS", "CLE", "TOR", "BKN", "ATL", "CHA", "WAS", "NYK", "IND", "DET", "ORL"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep1Test()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2022, 3, 14));
        
        var expected = new[]
            {"PHX", "MEM", "GSW", "UTA", "DAL", "DEN", "MIN", "LAC", "LAL", "NOP", "POR", "SAS", "SAC", "OKC", "HOU"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Western).ToArray();
        Assert.That(actual, Has.Length.EqualTo(15));
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep2Test()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2022, 1, 29));

        var expected = new[]
            {"MIA", "CHI", "PHI", "CLE", "MIL", "BKN", "CHA", "TOR", "BOS", "ATL", "WAS", "NYK", "IND", "DET", "ORL"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep3Test()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2022, 2, 14));

        var expected = new[]
            {"MIA", "CHI", "CLE", "PHI", "MIL", "BOS", "TOR", "BKN", "CHA", "ATL", "WAS", "NYK", "IND", "ORL", "DET"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep4Test()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2022, 2, 11));

        var expected = new[]
            {"MIA", "CLE", "CHI", "MIL", "PHI", "TOR", "BOS", "BKN", "CHA", "ATL", "WAS", "NYK", "IND", "ORL", "DET"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep5Test()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2021, 12, 22));

        var expected = new[]
            {"BKN", "CHI", "MIL", "CLE", "MIA", "WAS", "PHI", "BOS", "CHA", "TOR", "ATL", "NYK", "IND", "ORL", "DET"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep5Test2()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2021, 12, 21));

        var expected = new[]
            {"BKN", "CHI", "CLE", "MIA", "MIL", "PHI", "WAS", "CHA", "BOS", "TOR", "ATL", "NYK", "IND", "ORL", "DET"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TwoWayTieStep5Test3()
    {
        var playedGames = Evaluator.GetRecordsUntilDate(new DateTime(2021, 12, 20));

        var expected = new[]
            {"BKN", "CHI", "CLE", "MIL", "MIA", "PHI", "WAS", "CHA", "BOS", "TOR", "ATL", "NYK", "IND", "ORL", "DET"};
        var actual = Evaluator.GetStandings(playedGames, Conference.Eastern).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }
}