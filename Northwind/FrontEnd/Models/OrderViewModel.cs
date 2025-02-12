using NuGet.Protocol.Core.Types;

namespace FrontEnd.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; } = null!;
        public IEnumerable<CustomerViewModel> Customers { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeId { get; set; }
        public IEnumerable<EmployeesViewModel> Employees { get; set; }
        public string EmployeeName { get; set; } 

        public int ShipperId { get; set; }
        public IEnumerable<ShipperViewModel> Shippers { get; set; }
        public string ShipperName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
