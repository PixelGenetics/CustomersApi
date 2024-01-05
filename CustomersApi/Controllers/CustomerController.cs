using CustomersApi.Datos;
using CustomersApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        private readonly CustomerDatabaseContext _customerDatabaseContext;
        public CustomerController(CustomerDatabaseContext customerDatabaseContext) 
        {
        
            _customerDatabaseContext = customerDatabaseContext;

        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> GetCustomers(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created, Type =typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomer(long id)
        {
            var vacio = new CustomerDto();

            return new OkObjectResult(vacio);

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            CustomerEntity result = await _customerDatabaseContext.Add(customer);

            return new CreatedResult($"https://localhost:7075/api/customer/{result.Id}", null);
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

    }
}
