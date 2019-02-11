using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class PactsRepository
    {
        private static BancDelTempsEntities db = new BancDelTempsEntities();

        public static List<Pact> GetAllPacts()
        {
            var llista = db.Pacts.ToList();
            return llista;
        }

        public static Pact GetSinglePact(int id)
        {
            var pact = db.Pacts.FirstOrDefault(x => x.Id_Pact == id);
            return pact;
        }

        public static List<Pact> GetAllPactsPerDesc(string desc)
        {
            var llista = db.Pacts.Where(x => x.description.Contains(desc)).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerTitle(string title)
        {
            var llista = db.Pacts.Where(x => x.title.Contains(title)).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateCreatedMateix(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_created == date).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateCreatedAbans(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_created < date).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateCreatedDespres(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_created > date).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateFinishedMateix(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_finished == date).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateFinishedAbans(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_finished < date).ToList();
            return llista;
        }

        public static List<Pact> GetAllPactsPerDateFinishedDespres(DateTime date)
        {
            var llista = db.Pacts.Where(x => x.date_finished > date).ToList();
            return llista;
        }
    }
}