namespace catering.Core.Entitys
{
    public class Customer
    {
        public int id { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public string adress { get; set; }

        public List<Order> prevOrders { get; set; }

        public Customer()
        {
            prevOrders = new List<Order>();
        }

    }
}
