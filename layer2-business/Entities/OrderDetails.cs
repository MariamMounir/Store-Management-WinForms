using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer2_business.Entities
{
    public class OrderDetails
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value > 0 ? value : throw new ArgumentException("Quantity must be greater than 0.");
        }
        private decimal _price;
        public decimal Price
        { 
            get=>_price;
            set=> _price=value >=0 ?value:throw new ArgumentException("Price cannot be negative.");
        }


    }
}
