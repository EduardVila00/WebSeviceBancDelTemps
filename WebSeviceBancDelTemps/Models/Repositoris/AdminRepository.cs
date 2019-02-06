using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class AdminRepository : ApiController
    {
        private static BancDelTempsEntities1 db = new BancDelTempsEntities1();



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
    }
}