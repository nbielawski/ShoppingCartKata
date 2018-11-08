using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class SilverMember : Member
    {
        public SilverMember(int id, string name): base(id, name)
        {}
        public override decimal GetDiscountPercent()
        {
            return .1m;
        }
    }
}
