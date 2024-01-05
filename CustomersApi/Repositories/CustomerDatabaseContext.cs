using CustomersApi.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Repositories
{
    public class CustomerDatabaseContext : DbContext
    {

        public CustomerDatabaseContext(DbContextOptions<CustomerDatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<CustomerEntity> Customers { get; set; }

        public async Task<CustomerEntity> Get(long id)
        {
            return await Customers.FirstAsync(x => x.Id == id);
        }

        public async Task<CustomerEntity> Add(CreateCustomerDto customerDto)
        {

            CustomerEntity entity = new CustomerEntity()
            {
                Id = null,
                FirstName = customerDto.Address,
                LastName= customerDto.Email,
                Email = customerDto.FirstName,
                Phone = customerDto.LastName,
                Address = customerDto.Phone
            };

            EntityEntry<CustomerEntity> response = await Customers.AddAsync(entity);
            await SaveChangesAsync();
            return await Get(response.Entity.Id ?? throw new Exception("No se ha podido guardar"));
        }

    }

    public class CustomerEntity
    {
        public long? Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;


    }
}
