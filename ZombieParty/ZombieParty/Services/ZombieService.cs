using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;

namespace ZombieParty.Services
{
    public class ZombieService : ServiceBaseAsync<Zombie>, IZombieService
    {
        /* Ici, on passe le dbContext au constructeur de la classe parente ServiceBaseAsync avec base. C’est nécessaire, parce que la classe ZombieTypeService hérite de ServiceBaseAsync qui a une le context en paramètre. */
        public ZombieService(ZombiePartyDbContext dbContext) : base(dbContext) { }
        public List<Zombie> GetAllByZombieTypeAsync(int id)
        {
            List<Zombie> zombies = _dbContext.Zombies.Where(z => z.ZombieTypeId == id).ToList();
            return zombies;
        }
    }
}
