using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeAlugueldeVeiculos.Entityes
{
    internal class Carro
    {
        public string marca;
        public string modelo;
        public string potencia;
        public string cor;


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Salvar()
        {
            //criar a conexão BD
            return "Os dados foram salvos com sucesso!";
        }

        public static List<Carro> BuscarPlaca(string placa)
        {
            List<Carro> listaCarros = new List<Carro>();

            if(placa == "PL123")
            {
                Carro carro = new Carro();
                carro.Marca = "Tesla";
                listaCarros.Add(carro);
            }

            return listaCarros;
        }


    }
}
