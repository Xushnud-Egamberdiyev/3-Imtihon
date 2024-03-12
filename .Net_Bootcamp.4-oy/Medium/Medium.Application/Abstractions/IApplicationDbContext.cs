﻿using Medium.Domain.Entity;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Abstractions
{
    public interface IApplicationDbContext
    {
       
        public DbSet<User> Users { get; set; }

        Task<int> SavaChagesAsync(CancellationToken cancellationToken = default);
    }
}
