using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_osu_Github
{
    class ModeleMenu
    {
        private static OSUppe3Entities1 maConnexion;
        public static void init()
        {
            maConnexion = new OSUppe3Entities1();
        }
        public static string RenvoyerIdVisiteur(string idVisiteur)
        {
            string vretour = "";
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == idVisiteur)
                           .Select(x => new { x.idVisiteur });
            foreach (var v in LQuery)
            {
                vretour = v.idVisiteur.ToString();
            }
            return vretour;
        }
    }
}
