using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class IPK : Mahasiswa
    {
        public int MhsPilihan { get; set; }
        public int kuisAT { get; set; }
        public int tugasAT { get; set; }
        public int utsAT { get; set; }
        public int uasAT { get; set; }

        private int totalNilai;
       
        public virtual int HitungIPK()
        {
            kuisAT = ConvertPersen(kuisAT, 10);
            tugasAT = ConvertPersen(tugasAT, 10);
            utsAT = ConvertPersen(utsAT, 30);
            uasAT = ConvertPersen(uasAT, 50);
            totalNilai = kuisAT + tugasAT + utsAT + uasAT;
            return totalNilai;
            
        }

        public override void TampilDataWithIndex(int value)
        {
            value = MhsPilihan;
            //Console.WriteLine("dapetX : " + value);
            base.TampilDataWithIndex(value);
            Console.WriteLine("Nilai Akhir Mahasiswa : " + HitungIPK());
            Console.WriteLine("Grade Mahasiswa : " + MyGrade(totalNilai));
        }

        static private int ConvertPersen(int nilai, int persen)
        {

            int hasilanPersen = 0;
            hasilanPersen = nilai * persen / 100;
            return hasilanPersen;
        }

        static public string MyGrade(double total)
        {
            string huruf;
            if (total >= 80)
            {
                huruf = "A";
            }
            else if (total >= 70)
            {
                huruf = "B";
            }
            else if (total >= 60)
            {
                huruf = "C";
            }
            else if (total >= 50)
            {
                huruf = "D";
            }
            else
            {
                huruf = "E";
            }
            return huruf;
        }

    }
}
