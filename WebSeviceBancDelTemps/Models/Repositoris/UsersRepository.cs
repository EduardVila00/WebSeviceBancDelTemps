using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class UsersRepository
    {
        private static BancDelTempsEntities1 db = new BancDelTempsEntities1();


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

        public static User GetSingleUser(int id)
        {

            var user = db.Users.SingleOrDefault(x => x.Id_User == id);
            return user;
        }

        public static User InsertUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                var sortida = GetSingleUser(user.Id_User);

                return sortida;
            }
            catch (Exception e)
            {
               // Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static User UpdateUser(int id, User user)
        {
            try
            {
                var u0 = db.Users.SingleOrDefault(x => x.Id_User == id);
                if (u0 == null) return null;
                u0.name = user.name;
                u0.last_name = user.last_name;
                u0.email = user.email;
                u0.register_date = user.register_date;
                u0.time_hours = user.time_hours;
                u0.password = user.password;
                u0.date_of_birth = user.date_of_birth;
                u0.gender = user.gender;
                u0.picture_path = user.picture_path;
                db.SaveChanges();
                return GetSingleUser(u0.Id_User);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteUser(int id)
        {
            var u = db.Users.SingleOrDefault(x => x.Id_User == id);
            if (u == null) return;
            db.Users.Remove(u);
            db.SaveChanges();
        }
    }
}