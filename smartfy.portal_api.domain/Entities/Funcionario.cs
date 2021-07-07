using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace smartfy.portal_api.domain.Entities
{
    public class Funcionario : Entity, IEntityTypeConfiguration<Funcionario>
    {
        
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Funcao { get; set; }


        public Funcionario() { }

        public Funcionario(int matricula, string nome, int idade, string funcao )
        {
            Matricula = matricula;
            Nome = nome;
            Idade = idade;
            Funcao = funcao;
        }

       
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(c => c.Matricula).HasMaxLength(3);//Não deu certo, VERIFICAR!!!
        }

    }
}
