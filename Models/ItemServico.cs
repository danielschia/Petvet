using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetVet.Models
{
    public class ItemServico
    {
        public string nome {get; set;}
        public string telefone {get; set;}
        public string data {get; set;}
        public string animal {get; set;}
        public string necessidade {get; set;}

    }
}