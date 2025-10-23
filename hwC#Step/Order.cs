using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwC_Step
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime PurchaseTime { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            return $"PurchaseTime: {PurchaseTime}, UserId: {ProductId}, UserId: {UserId}";
        }
    }
}
