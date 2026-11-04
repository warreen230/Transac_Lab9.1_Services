using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieTypeService : IServiceBaseAsync<ZombieType>
    {
        public bool HasAssociatedZombies(int id);
    }
}
