**BeatLeaderLib is a wrapper around the BeatLeader API.**

The BeatLeaderLib is easy to use and consists currently of the following categories of endpoints:

**How to use?**\
Install the package from NuGet

**Some examples of getting data:**
```
var beatleaderClient= new BeatLeaderClient()

//Gives all players from the country NL
var player = beatleaderClient.GetPlayersAsync("76561198187936410");

//Gives a specific leaderboard
var leaderboard = beatleaderClient.GetLeaderboardsByHashAsync("4E19C93FF2D7E086536AEAB2F551C2E184160640");
```

