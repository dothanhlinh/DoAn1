using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA1.Entities
{
    class Lop
    {
        private int malop;
        private string tenlop;

        public Lop() { }
        public Lop(int malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
        public Lop(Lop lop)
        {
            malop = (lop.malop);
            tenlop = string.Copy(lop.tenlop);
        }

        public int Malop1 { get => malop; set => malop = value; }
        public string Tenlop1 { get => tenlop; set => tenlop = value; }
    }
}
