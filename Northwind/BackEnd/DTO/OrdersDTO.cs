using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTO
{
    public class OrdersDTO
    {
        public int OrderId { get; set; }
        [Required]
        public int? CustomerId { get; set; }
        [Required]
        public int? EmployeeId { get; set; }
        [Required]
        public int? ShipperId { get; set; }
        public int OrderDate { get; set; }

    }
}
