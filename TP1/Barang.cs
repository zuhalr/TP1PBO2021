using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        public string NamaBarang { get; set; }
        public string JenisBarang { get; set; }
        public int HargaBarang { get; set; }
        public int range { get; set; }
        public Barang(){}
        public Barang(string NamaBarang,string JenisBarang,int HargaBarang,int range)
        {
            this.NamaBarang = NamaBarang;
            this.JenisBarang = JenisBarang;
            this.HargaBarang = HargaBarang;
            this.range = range;
        }
    }
}
