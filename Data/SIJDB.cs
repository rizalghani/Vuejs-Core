using Microsoft.EntityFrameworkCore;
using SIJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIJ.Data
{
    public class SIJDB : DbContext
    {
        public SIJDB(DbContextOptions<SIJDB> options) : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
    }
}
