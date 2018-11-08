using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public abstract class Member
    {
      
        public int ID { get; set; }

        public string Name { get; set; }

        public Member(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public virtual decimal GetDiscountPercent()
        {
            return 0m;

        }



    }
}
