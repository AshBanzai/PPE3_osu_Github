﻿using System;
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
                           .Where(x => x.idVisiteur == idVisiteur);
            return LQuery.ToList();
        }

        public static Object ListeRapport(string idVisiteur, int idMedecin)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idVisiteur == idVisiteur)
                           .Where(x => x.idMedecin == idMedecin)
                           .Select(x => new { x.idRapport,  x.dateRapport, x.MOTIF.libMotif, x.bilan})
                           .OrderBy(x => x.idRapport);
            return LQuery.ToList();
        }

        public static Object ListeMedicament(int idRapport)
        {
            var LQuery = maConnexion.MedicamentOffert.ToList()
                           .Where(x => x.idRapport == idRapport);
            return LQuery.ToList();
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
