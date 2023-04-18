using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    [Serializable]
    internal class SinhVien
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public double Course1 { get; set; }
        public double Course2 { get; set; }
        public double Course3 { get; set; }
        public double Average { get; set; }

    }
}
