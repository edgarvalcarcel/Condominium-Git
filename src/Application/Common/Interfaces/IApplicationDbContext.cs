using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Condominium.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<Breed> Breed { get; set; }
        DbSet<Color> Color { get; set; }
        DbSet<Contact> Contact { get; set; }
        DbSet<Leasing> Leasing { get; set; }
        DbSet<Location> Location { get; set; }
        DbSet<Maker> Maker { get; set; }
        DbSet<Pet> Pet { get; set; }
        DbSet<PetType> PetType { get; set; }
        DbSet<Property> Property { get; set; }
        DbSet<PropertyOwner> PropertyOwner { get; set; }
        DbSet<PropertyType> PropertyType { get; set; }
        DbSet<Resident> Resident { get; set; }
        DbSet<State> State { get; set; }
        DbSet<Status> Status { get; set; }
        DbSet<Vehicle> Vehicle { get; set; }
        DbSet<VehicleModel> VehicleModel { get; set; }
        DbSet<Visitor> Visitor { get; set; }
        DbSet<VisitorLog> VisitorLog { get; set; }
        DbSet<VisitorParking> VisitorParking { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}