using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_osu_Github
{
    public static class Modele2
    {
        private static OSUppe3Entities1 maConnexion;

        public static void init()
        {
            maConnexion = new OSUppe3Entities1();
        }


        public static Object Suivi(string idVisiteur)
        {
            var LQuery = maConnexion.Suivi.ToList()
                           .Where(x => x.identifiant == idVisiteur)
                           .Select(x => new { x.nom_prenom });
            return LQuery.ToList();
        }

        public static Object ListeRapport(string idVisiteur)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.idRapport,  x.dateRapport, x.MOTIF.libMotif, x.bilan})
                           .OrderBy(x => x.idRapport);
            return LQuery.ToList();
        }
    }
}
