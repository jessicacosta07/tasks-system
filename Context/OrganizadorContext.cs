using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tasks_system.Models;
using Microsoft.EntityFrameworkCore;

namespace tasks_system.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}