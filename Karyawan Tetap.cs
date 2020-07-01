using System;
using System.Collections.Generic;
using System.Text;

namespace tugas
{
    public class KaryawanTetap : Karyawan
    {

        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }
}