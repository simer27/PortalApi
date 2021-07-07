using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace smartfy.portal_api.domain.Entities
{
    public class Aluno : Entity, IEntityTypeConfiguration<Aluno>
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno() { }

        public Aluno(int matricula, string nome, int idade)
        {
            Matricula = matricula;
            Nome = nome;
            Idade = idade;
        }

        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
              builder.HasKey(c => c.Id);
            builder.Property(x => x.Id).IsRequired();
        builder.Property(c => c.Matricula).HasMaxLength(3); }//Não deu certo, VERIFICAR!!!
    }
}
