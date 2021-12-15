﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Logger
{
    public class NormativeCalculatorLoggerDbContext : DbContext
    {
        public NormativeCalculatorLoggerDbContext( DbContextOptions<NormativeCalculatorLoggerDbContext> options) : base(options)
        {
        }
        public DbSet<Log> Logs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
