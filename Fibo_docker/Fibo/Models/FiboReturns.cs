using System.Collections.Generic;
namespace fibo.Models
{
    public class FiboReturns
    {

        public List<ulong> fibonnacci { get; set; }
        public List<ulong> sorted { get; set; }

        public FiboReturns()
        {
            fibonnacci = new List<ulong>();
            sorted = new List<ulong>();
        }

    }
}