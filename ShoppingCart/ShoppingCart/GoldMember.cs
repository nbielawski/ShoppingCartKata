using System;

namespace ShoppingCart
{
    public class GoldMember : Member
    {
        public GoldMember(int id, string name): base(id, name)
        {  }

        public override decimal GetDiscountPercent()
        {
            return .20m;
        }
    }
}
