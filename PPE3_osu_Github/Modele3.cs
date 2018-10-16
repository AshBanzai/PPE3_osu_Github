using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_osu_Github
{
    class Modele3
    {
        
        private static OSUppe3Entities1  maConnexion;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new OSUppe3Entities1();
        }
        public static List<fichefrais> listefrais()
        {
            return maConnexion.fichefrais.ToList();


        }
        public static Object DonneNomVisiteur(string idVisiteur)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.nom,x.prenom });
            return LQuery.ToList();
        }

    }
}
