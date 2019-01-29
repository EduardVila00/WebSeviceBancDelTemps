using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class UsersRepository
    {
        private static BancDelTempsEntities db = new BancDelTempsEntities();


        public static List<User> GetAllUsers()
        {
            var llistaUsers = db.Users.ToList();
            return llistaUsers;
        }

        public static List<User> GetFiltreNameLastNameUsers(string filtre)
        {
            var llistaUsers = db.Users.Where(x => x.name.Contains(filtre) || x.last_name.Contains(filtre)).ToList();
            return llistaUsers;
        }

        public static List<User> GetFiltreEmailUsers(string filtre)
        {
            var llistaUsers = db.Users.Where(x => x.email.Contains(filtre)).ToList();
            return llistaUsers;
        }
    }
}