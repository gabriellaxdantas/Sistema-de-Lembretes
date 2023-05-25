using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lembretes
{

    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<LembreteItem> Lembretes { get; set; }

        public string ArquivoLembretes { get; set; }

        public void SalvarDadosXML()
        {

        }
    }
}
