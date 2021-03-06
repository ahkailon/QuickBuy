﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario: Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        // Um usuario pode ter nenhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            throw new System.NotImplementedException();
        }
    }
}
