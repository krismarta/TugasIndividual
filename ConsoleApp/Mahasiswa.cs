using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Mahasiswa
    {
        public List<string> namaLST { get; set; }
        public List<string> jrsLST { get; set; }
        public List<string> smtLST { get; set; }

        public string namaAT { get; set; }
        public string jurusanAT { get; set; }
        public string semesterAT { get; set; }

        public virtual void AddAllMahasiswa()
        {
            namaLST.Add(namaAT);
            jrsLST.Add(jurusanAT);
            smtLST.Add(semesterAT);
        }
        
        public virtual void TampilDataMahasiswa()
        {
            Console.WriteLine();
            Console.WriteLine("*** Data Mahasiswa ***");
            Console.WriteLine("No | Nama | Jurusan | Semester");
            for (int i = 0; i < namaLST.Count; i++)
            {
                Console.WriteLine(i + ". | " + namaLST[i] + " | " + jrsLST[i] + " | " + smtLST[i]);
            }
            Console.ReadKey();
        }

        public virtual void PilihMahasiswa()
        {
            Console.WriteLine();
            Console.WriteLine("*** Pilih Data Mahasiswa ***");
            for (int i = 0; i < namaLST.Count; i++)
            {
                Console.WriteLine(i + ". " + namaLST[i] + " " + jrsLST[i] + " " + smtLST[i]);
            }
           
        }

        public virtual void TampilDataWithIndex(int value)
        {
            Console.Clear();
            //Console.WriteLine("dapet : " + value);
            Console.WriteLine("*** IPK Mahasiswa ***");
            //Console.WriteLine("Nama : " + namaLST[value]);
            //Console.WriteLine("Jurusan : " + jrsLST[value]);
            //Console.WriteLine("Semester : " + smtLST[value]);
            
        }

        public virtual void RemoveMahasiswa(int index)
        {
            namaLST.RemoveAt(index);
            jrsLST.RemoveAt(index);
            smtLST.RemoveAt(index);
            Console.WriteLine("Data mahasiswa terhapus!");
            Console.ReadKey();
        }

    }
}
