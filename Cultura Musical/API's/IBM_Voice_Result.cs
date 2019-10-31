using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.API_s
{
    class IBM_Voice_Result
    {
        public List<IbmResultItem> results { get; set; }
        public int result_index { get; set; }
    }

    public class IbmResultItem
    {
        public List<IbmMessage> alternatives { get; set; }
        public bool final { get; set; }
    }

    public class IbmMessage
    {
        public double confidence { get; set; }
        public string transcript { get; set; }
    }
}
