using System.Collections.Generic;

namespace PetVet.Models
{
    public static class Dados
    {
        public static Servico ServicoAtual {get; set;}
        static Dados()
        {
            ServicoAtual = new Servico();
        }
        public static void Incluir(ItemServico servico)
        {
            ServicoAtual.AdicionaServico(servico);
        }
        public static List<ItemServico> Mostrar()
        {
            return ServicoAtual.Lista();
        }
    }
}