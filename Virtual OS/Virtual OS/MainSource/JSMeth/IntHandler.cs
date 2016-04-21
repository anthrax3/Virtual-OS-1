using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_OS.MainSource
{
    // Int
    public class Inter
    {
        private int _numb { get; set; }
        public Inter(int numb)
        {
            _numb = numb;
        }
        public void Add(int sum)
        {
            _numb += sum;
        }
        public void Minus(int sum)
        {
            _numb -= sum;
        }
        public int Get()
        {
            return _numb;
        }
    }
}
