using Minimal.Web.API;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}