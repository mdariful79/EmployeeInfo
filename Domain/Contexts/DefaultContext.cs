using Domain.Aggregates;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using RapidFireLib.Lib.Core;
using RapidFireLib.Models;

namespace Domain.Contexts
{
    public class DefaultContext : RFCoreDbContext
    {
        public DefaultContext() : base("DefaultConnection", contextType: ContextType.MSSQL) { }
        public DefaultContext(SAASType sAASType = SAASType.NoSaas) : base("DefaultConnection", sAASType, ContextType.MSSQL) { }

        public DbSet<DataVerificationLog> DataVerificationLog { get; set; }
        public DbSet<UserGeo> UserGeo { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Upazila> Upazila { get; set; }
        public DbSet<Unions> Unions { get; set; }
        public DbSet<Village> Village { get; set; }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<TrainingCategory> TrainingCategory { get; set; }
    }
}
