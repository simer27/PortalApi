using smartfy.portal_api.domain.Entities;
using smartfy.portal_api.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartfy.portal_api.presentation.UI.Web.Models
{
    public class AlunoVM
    {
        public List<Aluno> Alunos { get; set; }

        //Filtros
        public string FilterNome { get; set; }
        public string FilterIdade { get; set; }
        public string FilterMatricula { get; set; }
        
    }
}
