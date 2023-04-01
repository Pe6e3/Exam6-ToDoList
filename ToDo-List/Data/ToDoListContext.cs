using ToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data;

public class ToDoListContext : DbContext
{
    public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options) { }

    public DbSet<MyTask> Tasks { get; set; }
    public DbSet<Priority> Priorities { get; set; }
}
