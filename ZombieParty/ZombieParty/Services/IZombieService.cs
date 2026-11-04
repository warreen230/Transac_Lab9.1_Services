using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieService: IServiceBaseAsync<Zombie>
    {
        public List<Zombie> GetAllByZombieTypeAsync(int id);
    }
}
