using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class Produto : Entidade
    {
        public int Id { get; set; }
        public string NomeP { get; set; }
        public int Descricao { get; set; }
        public int Preco { get; set; }

        public override void Validade()
        {
            throw new NotImplementedException();
        }
    }
}
