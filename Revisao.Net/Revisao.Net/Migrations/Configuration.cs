namespace Revisao.Net.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Revisao.Net.Models.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Revisao.Net.Models.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Tarefas.AddOrUpdate(
              p => p.Titulo,
                new Tarefas { Titulo = "Minha Tarefa nº 1", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 1" },
                new Tarefas { Titulo = "Minha Tarefa nº 2", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 2" },
                new Tarefas { Titulo = "Minha Tarefa nº 3", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 3" },
                new Tarefas { Titulo = "Minha Tarefa nº 11", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 11" },
                new Tarefas { Titulo = "Minha Tarefa nº 21", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 21" },
                new Tarefas { Titulo = "Minha Tarefa nº 31", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 31" },
                new Tarefas { Titulo = "Minha Tarefa nº 12", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 12" },
                new Tarefas { Titulo = "Minha Tarefa nº 22", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 22" },
                new Tarefas { Titulo = "Minha Tarefa nº 32", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 32" },
                new Tarefas { Titulo = "Minha Tarefa nº 13", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 13" },
                new Tarefas { Titulo = "Minha Tarefa nº 23", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 23" },
                new Tarefas { Titulo = "Minha Tarefa nº 33", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 33" },
                new Tarefas { Titulo = "Minha Tarefa nº 14", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 14" },
                new Tarefas { Titulo = "Minha Tarefa nº 24", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 24" },
                new Tarefas { Titulo = "Minha Tarefa nº 34", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 34" },
                new Tarefas { Titulo = "Minha Tarefa nº 15", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 15" },
                new Tarefas { Titulo = "Minha Tarefa nº 25", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 25" },
                new Tarefas { Titulo = "Minha Tarefa nº 35", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 35" },
                new Tarefas { Titulo = "Minha Tarefa nº 16", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição da minha tarefa nº 16" },
                new Tarefas { Titulo = "Minha Tarefa nº 26", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição um pouco mais longa da minha tarefa nº 26" },
                new Tarefas { Titulo = "Minha Tarefa nº 36", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descrição bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa nº 36" }
            );

        }
    }
}
