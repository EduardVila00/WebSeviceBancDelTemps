using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class CategoriesRepository
    {
        private static BancDelTempsEntities1 db = new BancDelTempsEntities1();


        public static List<Category> GetAllCategories()
        {
            var llistaCategorys = db.Categories.ToList();
            return llistaCategorys;
        }

        public static Category GetSingleCategory(int id)
        {

            var user = db.Categories.SingleOrDefault(x => x.Id_Category == id);
            return user;
        }

        public static List<Category> GetFiltreCategories(string filtre)
        {
            var llistaUsers = db.Categories.Where(x => x.name.Contains(filtre)).ToList();
            return llistaUsers;
        }

        public static Category InsertCategory(Category user)
        {
            try
            {
                db.Categories.Add(user);
                db.SaveChanges();
                var sortida = GetSingleCategory(user.Id_Category);

                return sortida;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static Category UpdateCategory(int id, Category user)
        {
            try
            {
                var u0 = db.Categories.SingleOrDefault(x => x.Id_Category == id);
                if (u0 == null) return null;
                u0.name = user.name;
                u0.description = user.description;
                db.SaveChanges();
                return GetSingleCategory(u0.Id_Category);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteCategory(int id)
        {
            var u = db.Categories.SingleOrDefault(x => x.Id_Category == id);
            if (u == null) return;
            db.Categories.Remove(u);
            db.SaveChanges();
        }


    }
}