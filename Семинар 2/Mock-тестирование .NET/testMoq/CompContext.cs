using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class CompContext : DbContext
{
    public DbSet<Computer> Computers { get; set; }
}