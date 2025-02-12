namespace FrontEnd.ApiModels
{
    public class OrdersAPI
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; } = null!;
        public int EmployeeId {  get; set; }

        public int ShipperId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
