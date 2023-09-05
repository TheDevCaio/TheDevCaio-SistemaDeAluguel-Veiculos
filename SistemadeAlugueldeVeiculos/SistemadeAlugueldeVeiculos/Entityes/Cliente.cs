using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeAlugueldeVeiculos.Entityes
{
    internal class Cliente
    {
        public string nome;
        public string cpf;
        public string email;
        public string telefone;
        public string endereço;
        public string celular;
        public string whatsapp;
        public string tempo;

        public string Nome
        {
            get { return Nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return CPF; }
            set { cpf = value; }
        }

        public string Email
        {
            get { return Email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereço
        {
            get { return endereço; }
            set { endereço  = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string WhatsApp
        {
            get { return whatsapp; }
            set { whatsapp = value; }
        }

        public string Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }


        public string Salvar()
        {
            //criar a conexão BD
            return "Os dados foram salvos com sucesso!";
        }

        
        public static List<Cliente>BuscarCpf(double cpf)
        {
            List<Cliente> clientes = new List<Cliente>();

            if (cpf == 1234567810)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = "João da Silva";
                clientes.Add(cliente);
            }
        return clientes;
        }

        public static List<Cliente> BuscarTempo(short tempo)
        {
            List<Cliente> tempoAluguel = new List<Cliente>();

            if(tempo != null)
            {
                Cliente tempoAlugar = new Cliente();
                tempoAlugar.Tempo = "Disponível";
                tempoAluguel.Add(tempoAlugar);
            }

            return tempoAluguel;
        }




    }

}


