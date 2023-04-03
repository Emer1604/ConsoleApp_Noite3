using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Vendas
    {
        public int Id;
        public string Data;

        public Vendas(int id, string data)
        { 
            Id = id;
            Data = data;
        }
        public int getId()
        { return Id; }

        public string getData()
        { return Data; }
        public string ExibirDadosV()
        {
            return "Código da venda: " + Id + "Data da venda: " + Data;
        }
    }
}
