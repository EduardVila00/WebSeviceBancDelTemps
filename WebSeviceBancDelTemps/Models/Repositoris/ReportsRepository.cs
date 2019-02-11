using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class ReportsRepository
    {
        private static BancDelTempsEntities db = new BancDelTempsEntities();


        public static List<Report> GetAllReports()
        {
            var llista = db.Reports.ToList();
            return llista;
        }
        public static List<Report> GetAllReportsDesc(string desc)
        {
            var llista = db.Reports.Where(x => x.description.Contains(desc)).ToList();
            return llista;
        }
        public static List<Report> GetAllReportsPerPost(Post post)
        {
            var llista = db.Reports.Where(x => x.Post.Id_Post == post.Id_Post).ToList();
            return llista;
        }
        public static List<Report> GetAllReportsPerUser(User user)
        {
            var llista = db.Reports.Where(x => x.Post.User.Id_User == user.Id_User).ToList();
            return llista;
        }
        public static List<Report> GetAllReportsPerRevised(bool revised)
        {
            var llista = db.Reports.Where(x => x.is_revised == revised).ToList();
            return llista;
        }
        public static Report UpdateReport(int id, Report report)
        {
            try
            {
                var r = db.Reports.SingleOrDefault(x => x.Id_Report == id);
                if (r == null) return null;
                r.description = report.description;
                r.is_revised = report.is_revised;
                db.SaveChanges();
                return r;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteReport(int id)
        {
            var r = db.Reports.FirstOrDefault(x => x.Id_Report == id);
            if(r == null) return;
            db.Reports.Remove(r);
            db.SaveChanges();
        }



    }
}