using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class AdminRepository
    {
        private static BancDelTempsEntities db = new BancDelTempsEntities();



        public static List<Admin> GetAllAdmins()
        {
            var llistaAdmins = db.Admins.ToList();
            return llistaAdmins;
        }


        public static string InsertAdmin(Admin admin)
        {
            try
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return admin.Id_Admin.ToString()/* GetSingleUser(user.Id_User)*/;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.ToString());
                return e.ToString();
            }
        }

        public static Admin UpdateAdmin(int id, Admin admin)
        {
            try
            {
                var a = db.Admins.FirstOrDefault(x => x.Id_Admin == id);
                if (a == null) return null;
                a.password = admin.password;
                a.username = admin.username;
                db.SaveChanges();
                return a;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public static void DeleteAdmin(int id)
        {
            var a = db.Admins.FirstOrDefault(x => x.Id_Admin == id);
            if (a == null) return;
            db.Admins.Remove(a);
            db.SaveChanges();
            
        }

        public static Admin LoginAdmin(Admin admin)
        {
            var obj = db.Admins.FirstOrDefault(x => x.username.Equals(admin.username) && x.password == admin.password);
            return obj;
        }
    }
}