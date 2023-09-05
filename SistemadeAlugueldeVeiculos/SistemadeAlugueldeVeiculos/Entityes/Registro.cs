using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeAlugueldeVeiculos.Entityes
{
    internal class Registro
    {
        public string marca;
        public string nome;
        public DateTime datainicial;
        public DateTime datafinal;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataInicial
        {
            get { return datainicial; }
            set { datainicial = value; }
        }

        public DateTime DataFinal
        {
            get { return datafinal;  }
            set { datafinal = value; }
        }

        public string Salvar()
        {
            //criar a conexão BD
            return "Os dados foram salvos com sucesso!";
        }
    }
}
