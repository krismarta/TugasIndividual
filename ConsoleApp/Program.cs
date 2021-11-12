using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namaMahasiswaLST = new List<string>();
            List<string> jurusanMahasiswaLST = new List<string>();
            List<string> smtMahasiswaLST = new List<string>();

            Mahasiswa newMHS = new Mahasiswa();
            IPK newIPK = new IPK();

            newMHS.namaLST = namaMahasiswaLST;
            newMHS.jrsLST = jurusanMahasiswaLST;
            newMHS.smtLST = smtMahasiswaLST;

            string namaMHS, jurusanMHS, smtMHS, ulangiLagi;
            int kuis, tugas, uts, uas, total;
            string huruf;
            int plh;
            int pilihan;

        awal:
            try 
            {
                Console.Clear();
                Console.WriteLine("======= Aplikasi Mahasiswa =======");
                Console.WriteLine("=========== Pilih Menu ===========");
                Console.WriteLine("1. Tambah Mahasiswa Baru");
                Console.WriteLine("2. Pengisian KRS");
                Console.WriteLine("3. Hitung IPK");
                Console.WriteLine("4. Data Mahasiswa");
                Console.WriteLine("5. Hapus Mahasiswa");
                Console.WriteLine("6. Keluar");
                Console.Write("Masukan Pilihan [1-6] : ");
                pilihan = int.Parse(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                    lagidong:
                        Console.Clear();
                        Console.Write("Masukan Nama :");
                        namaMHS = Console.ReadLine();
                        Console.Write("Masukan Jurusan :");
                        jurusanMHS = Console.ReadLine();
                        Console.Write("Masukan Semester :");
                        smtMHS = Console.ReadLine();
                        
                        newMHS.namaAT = namaMHS;
                        newMHS.jurusanAT = jurusanMHS;
                        newMHS.semesterAT = smtMHS;

                        newMHS.AddAllMahasiswa();

                        Console.WriteLine("Data Mahasiswa Tersimpan");
                        Console.WriteLine();
                        Console.Write("Pilih :(Y/y = tambah lagi, T/t = Menu Utama) : ");
                        ulangiLagi = Console.ReadLine();
                        if (ulangiLagi == "Y" || ulangiLagi == "y")
                        {
                            goto lagidong;
                        }
                        else
                        {
                            goto awal;
                        }

                        break;
                    case 2:

                        break;
                    case 3:
                        Console.Clear();
                        newMHS.PilihMahasiswa();
                        Console.Write("Pilih Mahasiswa [angka] : ");
                        plh = int.Parse(Console.ReadLine());

                        Console.Write("Masukan Nilai Kuis ? ");
                        kuis = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Nilai Tugas ? ");
                        tugas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Nilai UTS ? ");
                        uts = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Nilai UAS ? ");
                        uas = Convert.ToInt32(Console.ReadLine());

                        newIPK.kuisAT = kuis;
                        newIPK.tugasAT = tugas;
                        newIPK.utsAT = uts;
                        newIPK.uasAT = uas;
                        newIPK.MhsPilihan = plh;
                        newIPK.TampilDataWithIndex(plh);
                        Console.ReadKey();
                        goto awal;
                        break;

                    case 4:
                        Console.Clear();
                        newMHS.TampilDataMahasiswa();
                        goto awal;
                        break;

                    case 5:
                        Console.Clear();
                        newMHS.PilihMahasiswa();
                        Console.Write("Pilih Mahasiswa : ");
                        plh = int.Parse(Console.ReadLine());
                        newMHS.RemoveMahasiswa(plh);
                        
                        goto awal;
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("======== Terima kasih =========");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan tidak ditemukan, Coba lagi !");
                        goto awal;
                        break;
                }
            }
            catch(FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Pilihan hanya bisa diinput bilangan bulat, Coba lagi !");
                goto awal;
            }

            
        }
    }
}
