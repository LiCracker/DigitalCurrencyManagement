using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM_WPF
{
    class Model
    {
    }

    public class BTC
    {
        public double USD { get; set; }
    }

    public class ETH
    {
        public double USD { get; set; }
    }

    public class LTC
    {
        public double USD { get; set; }
    }

    public class RootObject
    {
        private RootObject result;

        public BTC BTC { get; set; }
        public ETH ETH { get; set; }
        public LTC LTC { get; set; }
    }
}
