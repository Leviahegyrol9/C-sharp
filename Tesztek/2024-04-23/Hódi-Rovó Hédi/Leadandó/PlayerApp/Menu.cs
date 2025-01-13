using HttpServices;
using IO_Library;
using PlayerApp;

namespace PlayerApp;

public static class Menu
{
    public static async Task Main()
    {


        int choice = ExtendedConsole.ReadInteger("1 - Játékos azonosítójának megadása\n2 - Új játékos hozzáadása\nVálasz:", 1, 2);

        if (choice == 1)
        {
            int id = ExtendedConsole.ReadInteger("Adja meg a játékos azonosítóját:", 1, 1000000);

            Player player = await PlayerService.GetByIdAsync(id);
            
            AppState.SetPlayer(player);

            if (player is null)
            {
                Console.WriteLine("Ezzel az azonositoval nem letezik adat.");
                await Main();
            }

        }
        else
        {
            
            await AddAsync();
        }

        await UpdateOrDelete();
    }

    public static async Task UpdateOrDelete()
    {
        Console.Clear();

        Player player = AppState.GetPlayer();
        player.WriteToConsole();

        Console.WriteLine();
        Console.WriteLine("1 - Törlés");
        Console.WriteLine("2 - Szerkesztés");
        int option = ExtendedConsole.ReadInteger("Válasszon műveletet:", 1, 2);

        switch (option)
        {
            case 1:
                await DeleteAsync();
                break;
            case 2:
                await UpdateAsync();
                break;
        }
    }

    private static async Task DeleteAsync()
    {

        char option = ExtendedConsole.ReadCharWithCriteria("Biztos benne (Y/N): ", ['y', 'n', 'Y', 'N']);

        if (option == 'n' || option == 'N')
            return;

        bool isSuccess = await PlayerService.DeleteAsync(AppState.GetId());

        if (isSuccess)
        {
            AppState.Clear();
        }

        Console.WriteLine($"{(isSuccess ? "Sikerült" : "Nem sikerült")} a törlés.");
        await Task.Delay(3000);

        await Main();
    }

    private static async Task UpdateAsync()
    {
        Console.Clear();


        Player updatedPlayerData = GetUpdatedPlayerData();
        await PlayerService.UpdateAsync(AppState.GetPlayer());

        Console.WriteLine("Sikerült a módosítás.");
        await Task.Delay(3000);

        await Main();

    }

    private static Player GetUpdatedPlayerData()
    {
        Player player = new Player();

        Console.Write("Nev (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.Name = Console.ReadLine();
        Console.Write("Kép (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.ImageLink = Console.ReadLine();
        Console.Write("Klub (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.Club = Console.ReadLine();
        Console.Write("Születésnap (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.Birthday = Console.ReadLine();
        int weight = ExtendedConsole.ReadInteger("Testsúly (ha nem szeretné megváltoztatni, nyomjon egy enter gombot):", 0, 100000000);
        player.Weight = weight;
        double height = ExtendedConsole.ReadDouble("Magasság: cm (ha nem szeretné megváltoztatni, nyomjon egy enter gombot):", 0, 100000000);
        player.Height = height;
        Console.Write("Leírás (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.Description = Console.ReadLine();
        Console.Write("Pozíció (ha nem szeretné megváltoztatni, nyomjon egy enter gombot): ");
        player.Position = Console.ReadLine();
        return player;
    }

    private static async Task AddAsync()
    {
        Console.WriteLine("Adja meg az új adatokat: ");

        Player newPlayerData = GetUpdatedPlayerData();
        await PlayerService.AddAsync(AppState.GetPlayer());

        Console.Clear();

        await Main();



        //Console.WriteLine("Adja meg az új adatokat: ");
        //Player newPlayer = GetUpdatedPlayerData();

        //newPlayer = await PlayerService.SendPostRequestAsync<Player>("api/player/create", newPlayer);
        //AppState.SetPlayer(newPlayer);

        //Console.Clear();

        //await Main();
    }
}
