namespace HttpServices
{
    public class PlayerService : BaseService
    {
        public static async Task<Player> GetByIdAsync(int id)
        {
            Player player = await SendGetRequestAsync<Player>("api/player/get", id);

            return player;
        }
        public static async Task<bool> DeleteAsync(int id)
        {
            bool result = await SendDeleteRequestAsync("api/player/delete", id);
            return result;
        }

        public static async Task UpdateAsync(Player player)
        {
            await SendPutRequestAsync("api/player/update", player);
        }

        public static async Task AddAsync(Player player)
        {
            await SendPostRequestAsync("api/player/create", player);
        }
    }

}