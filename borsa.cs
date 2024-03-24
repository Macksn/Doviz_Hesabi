using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASS_BORSA_
{
    class borsa
    {
        public double para;
        public double euro()
        {
            return (para / 3.63);
        }
        public double dolar()
        {
            return (para / 3.43);
        }
        public double altın()
        {
            return (para / 131);
        }
    }
}
