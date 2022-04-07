# Tiebreaker Kata

There are no ties in basketball. Not only will a game go into multiple overtime periods in order to determine a winner,
but ties in the standings have a very methodical way of being broken. Two teams with the same record? No! There's always
a hierarchy to determine which team is better than another!

## Mission

Implement the tie-breaking rules as found on [nba.com/standings](https://www.nba.com/standings). A summary is below.

### Tiebreaker basis for two-way ties:

0. Tie breaker not needed (better overall winning percentage)
1. Head-to-head won-lost percentage
2. Division leader wins tie from team not leading a division
3. Division won-lost percentage for teams in the same division
4. Conference won-lost percentage
5. W-L Percentage vs. Playoff teams, own conference
6. W-L Percentage vs. Playoff teams, other conference
7. Net Points, all games

### Tiebreaker basis for multi-way ties

0. Tie breaker not needed (better overall winning percentage)
1. Division leader wins tie from team not leading a division
2. Head-to-head won-lost percentage
3. Division won-lost percentage for teams in the same division
4. Conference won-lost percentage
5. W-L Percentage vs. Playoff teams, own conference
6. W-L Percentage vs. Playoff teams, other conference
7. Net Points, all games

## Ideas

- Use the test cases to use specific game data for specific situations, or use your own mock data.