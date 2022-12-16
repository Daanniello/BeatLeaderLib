**BeatLeaderLib is a wrapper around the BeatLeader API.**

The BeatLeaderLib is easy to use and consists currently of the following categories of endpoints:

(Included)
- Clan
- Leaderboard
- Players

(Not includes yet)
- MiniRanking
- Playlist
- Rank
- Score
- Song
- Stats

**How to use?**\
Install the package from NuGet

**Some examples of getting data:**
```
var beatleaderApi = new BeatLeaderApi()

//Gives all players from the country NL
var players = beatleaderApi.Players.GetPlayers(country: "nl");

//Gives a specific leaderboard
var leaderboard = beatleaderApi.Leaderboard.GetLeaderboardByHash("4E19C93FF2D7E086536AEAB2F551C2E184160640");
```

