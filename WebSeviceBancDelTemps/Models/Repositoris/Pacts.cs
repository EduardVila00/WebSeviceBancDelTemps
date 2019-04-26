using System.Collections.Generic;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class Pacts
    {
        public List<Pact> pacts { get; set; }

        public Pacts(List<Pact> pacts)
        {
            this.pacts = pacts;
        }
    }
}