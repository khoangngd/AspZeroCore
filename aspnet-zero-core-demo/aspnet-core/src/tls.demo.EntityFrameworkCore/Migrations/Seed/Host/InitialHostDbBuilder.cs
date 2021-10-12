﻿using tls.demo.EntityFrameworkCore;

namespace tls.demo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly demoDbContext _context;

        public InitialHostDbBuilder(demoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}