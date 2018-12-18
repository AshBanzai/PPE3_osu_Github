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
        public static Object listefrais(string idVisiteur)
        {

            var LQuery = maConnexion.lesfraisforfaitaires.AsNoTracking().ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.libelle, x.quantite, x.montant, x.total })
                           .OrderBy(x => x.libelle);
            return LQuery.ToList();
        }
        public static Object retournefrais(string idVisiteur)
        {

            var LQuery = maConnexion.lesfraisforfaitaires.AsNoTracking().ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.libelle, x.quantite, x.montant, x.total })
                           .OrderBy(x => x.libelle);
            return LQuery.ToList();
        }
        public static Object listeautresfrais(string idVisiteur)
        {

            var LQuery = maConnexion.lesautresfrais.AsNoTracking().ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.libelle, x.montant, x.date})
                           .OrderBy(x => x.libelle);
            return LQuery.ToList();
        }
        public static Object totalfrais(string idVisiteur)
        {

            var LQuery = maConnexion.total.ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.total1 });
            return LQuery.ToList();
        }
        public static string RenvoyerNomVisiteur(string idVisiteur)
        {
            string vretour = "";
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Select(x => new { x.nom, x.prenom });
            foreach (var v in LQuery)
            {
                vretour = v.nom.ToString() + " " + v.prenom.ToString();
            }

            return vretour;
        }




    }
}
