using Condominium.Application.Common.Interfaces;
using Condominium.Domain.Common;
using Condominium.Domain.Entities;
using Condominium.Infrastructure.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Condominium.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

        public virtual DbSet<Breed> Breed { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Leasing> Leasing { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Maker> Maker { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetType> PetType { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyOwner> PropertyOwner { get; set; }
        public virtual DbSet<PropertyType> PropertyType { get; set; }
        public virtual DbSet<Resident> Resident { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<VisitorLog> VisitorLog { get; set; }
        public virtual DbSet<VisitorParking> VisitorParking { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}