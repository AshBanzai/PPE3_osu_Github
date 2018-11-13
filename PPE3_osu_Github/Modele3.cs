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
        public static Object DonneNomVisiteur()
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Select(x => new { x.nom})
                           .OrderBy(x => x.nom);
            return LQuery.ToList();
        }
        public static Object DonneIdVisiteur(string nom)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                .Where(x => x.nom == x.nom)
                .Select(x => new { x.idVisiteur });
            return LQuery.ToList();

        }
        /*public static Object ListeFraisForfais(string idVisiteur)
        {
            var LQuery = maConnexion.fichefrais.ToList()
                           .Where(x => x.idVisiteur == idVisiteur and x.idVisiteur)
                           .Select(x => new { x. })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }*/



    }
}
