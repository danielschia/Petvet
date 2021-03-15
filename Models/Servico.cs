using System;
using System.Collections.Generic;

namespace PetVet.Models
{
    public class Servico
    {
        List<ItemServico> itemServico;

        public Servico()
        {
            itemServico = new List<ItemServico>();
        }
        public List<ItemServico> Lista()
        {
            return itemServico;
        }
        public void AdicionaServico(ItemServico servico)
        {
            itemServico.Add(servico);
        }
    }
}