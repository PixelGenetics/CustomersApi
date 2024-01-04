using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Datos
{
    public class CreateCustomerDto
    {
        [Required(ErrorMessage = "Escribe tu nombre")]
        public string FirstName { get; set; } = null!;
        [Required (ErrorMessage = "Escribe tu apellido")]
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;

    }
}
