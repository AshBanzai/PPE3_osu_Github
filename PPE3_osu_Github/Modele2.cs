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

        public static Object MedecinsSuivis(string idVisiteur)
        {
            var LQuery = maConnexion.MEDECIN.ToList()
                           .Where(x => x.idMedecin == x.idMedecin)
                           .Select(x => new { x.nom, x.prenom });
            return LQuery.ToList();
        }
    }
}
