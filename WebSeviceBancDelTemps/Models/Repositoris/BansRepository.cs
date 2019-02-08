using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class BansRepository
    {
        private static BancDelTempsEntities1 db = new BancDelTempsEntities1();


        public static List<Ban> GetAllBans()
        {
            var llistaBans = db.Bans.ToList();
            return llistaBans;
        }


        //public static List<Ban> GetFiltreEmailBans(string filtre)
        //{
        //    var llistaBans = db.Bans.Where(x => x.email.Contains(filtre)).ToList();
        //    return llistaBans;
        //}

        public static Ban GetSingleBan(int id)
        {

            var user = db.Bans.SingleOrDefault(x => x.Id_Ban == id);
            return user;
        }

        public static Ban InsertBan(Ban user)
        {
            try
            {
                db.Bans.Add(user);
                db.SaveChanges();
                var sortida = GetSingleBan(user.Id_Ban);

                return sortida;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static Ban UpdateBan(int id, Ban user)
        {
            try
            {
                var u0 = db.Bans.SingleOrDefault(x => x.Id_Ban == id);
                if (u0 == null) return null;
                u0.ban_date = user.ban_date;
                u0.ban_finish_date = user.ban_finish_date;
                db.SaveChanges();
                return GetSingleBan(u0.Id_Ban);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteBan(int id)
        {
            var u = db.Bans.SingleOrDefault(x => x.Id_Ban == id);
            if (u == null) return;
            db.Bans.Remove(u);
            db.SaveChanges();
        }
    }
}