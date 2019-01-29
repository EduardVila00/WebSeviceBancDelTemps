using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class UsersRepository
    {
        private  static BancDelTempsEntities db = new BancDelTempsEntities();
        

        public static List<User> GetAllUsers()
        {
            //db.Configuration.ProxyCreationEnabled = false;
            var llistaUsers = db.Users.ToList();
            return llistaUsers;
        }
    }
}