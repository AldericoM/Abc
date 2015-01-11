using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OCC.controle
{
    class Validacao
    {
        public bool validaEmail(string email)
        {
            try
            {
                string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                    + @"[a-zA-Z]{2,}))$";
                Regex reStrict = new Regex(patternStrict);
                bool isStrictMatch = reStrict.IsMatch(email);
                return isStrictMatch;
            }
            catch (Exception e)
            {
                return false;
                e.ToString();
            }
            
        }
        public bool validarNome(string nome)
        {
            string n = @"[a-zA-z]";
            Regex nn = new Regex(n);
            bool nnn = nn.IsMatch(nome);
            return nnn;
        }
    }
}
