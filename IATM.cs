using System;
using System.Collections.Generic;

namespace Sample
{
    public interface IATM
    {
         bool Check(int Pass);

         bool WithDrawal(int Pass);

         bool Inventory(int Pass);

         bool CartTOCart(int Pass);

         List<MUsers> Specifications(int Pass);

         bool ChangePassword(int Pass);
    }
}
