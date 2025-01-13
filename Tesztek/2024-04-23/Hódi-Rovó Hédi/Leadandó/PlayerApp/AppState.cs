namespace PlayerApp;

public static class AppState
{
    private static Player selectedPlayer;

    public static void SetPlayer(Player player) => selectedPlayer = player;

    public static void Clear() => selectedPlayer = null;

    public static Player GetPlayer() => selectedPlayer;

    public static void Update(Player player)
    {
        selectedPlayer.Name = string.IsNullOrEmpty(player.Name) ?
                                    selectedPlayer.Name :
                                    player.Name;
        //ha entert nyomunk beiras nelkul, megtartja az eredeti ertekeket, ha irunk be valamit, akkor az ujra valt

        selectedPlayer.ImageLink = string.IsNullOrEmpty(player.ImageLink) ?
                                    selectedPlayer.ImageLink :
                                    player.ImageLink;

        selectedPlayer.Club = string.IsNullOrEmpty(player.Club) ?
                                    selectedPlayer.Club :
                                    player.Club;

        selectedPlayer.Birthday = string.IsNullOrEmpty(player.Birthday) ?
                            selectedPlayer.Birthday :
                            player.Birthday;

        selectedPlayer.Description = string.IsNullOrEmpty(player.Description) ?
                            selectedPlayer.Description :
                            player.Description;

        selectedPlayer.Position = string.IsNullOrEmpty(player.Position) ?
                                    selectedPlayer.Position :
                                    player.Position;
    }

    public static int GetId() => selectedPlayer.Id;
}