namespace catering.Core
    .Entitys
{
    public class Order
    {
        public int Id { get; set; }

        public int quantity { get; set; }

        public bool IsSending { get; set; }

        public int endPrice { get; set; }


        public ICollection<Dish> Dishes { get; }


        public int CustomerId { get; set; }

        public Customer customer { get; set; }


        public Order()
        {
            Dishes = new List<Dish>();
        }

        public Order(int id, int customerId, int quantity, bool isSending)
        {
            Id = id;
            CustomerId = customerId;
            this.quantity = quantity;
            IsSending = isSending;
        }


        public void setEndPrice()
        {
            for (int i = 0; i < Dishes.Count; i++)
            {
                endPrice += Dishes[i].price * quantity;
            }
            if (IsSending)
            {
                endPrice += 100;
            }
        }

    }
}
