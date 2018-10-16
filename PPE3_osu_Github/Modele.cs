using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_osu_Github
{


    class Modele
    {
        private static OSUppe3Entities1 maConnexion;

        public static void init()
        {
            maConnexion = new OSUppe3Entities1();
        }

        private static string test(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static bool valideConnexion(string id, string mp)
        {
            bool vRetour =false;
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant==id)
                           .Select(x => new { x.identifiant, x.password });
            
            foreach (var v in LQuery)
            {
                if (v.password == mp)
                { vRetour = true; }
            }
         return vRetour;
        }

        public static Object TestConnexion()
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Select(x => new { x.identifiant, x.password })
                           .OrderBy(x=> x.identifiant);
            return LQuery.ToList();
        }

    }  


}


