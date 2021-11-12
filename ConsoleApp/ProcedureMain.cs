using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ProcedureMain
    {
        static void TestConsole(string[] args)
        {
            List<string> namaMahasiswaLST = new List<string>();
            List<string> jurusanMahasiswaLST = new List<string>();
            List<string> smtMahasiswaLST = new List<string>();

            string namaMHS, jurusanMHS, smtMHSl, ulangiLagi;
            int kuis, tugas, uts, uas, total;
            string huruf;
            int plh;
            int pilihan;

        awal:
            try
            {
                Console.WriteLine();
                Console.WriteLine("======= Aplikasi Mahasiswa =======");
                Console.WriteLine("=========== Pilih Menu ===========");
                Console.WriteLine("1. Tambah Mahasiswa Baru");
                Console.WriteLine("2. Hitung IPK");
                Console.WriteLine("3. Data Mahasiswa");
                Console.WriteLine("4. Hapus Mahasiswa");
                Console.WriteLine("5. Keluar");
                Console.Write("Masukan Pilihan [1-5] : ");
                pilihan = int.Parse(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                    lagidong:
                        Console.WriteLine();
                        Console.Write("Masukan Nama :");
                        namaMHS = Console.ReadLine();
                        Console.Write("Masukan Jurusan :");
                        jurusanMHS = Console.ReadLine();
                        Console.Write("Masukan Semester :");
                        smtMHSl = Console.ReadLine();
                        namaMahasiswaLST.Add(namaMHS);
                        jurusanMahasiswaLST.Add(jurusanMHS);
                        smtMahasiswaLST.Add(smtMHSl);
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
                        Console.WriteLine();
                        Console.WriteLine("*** Pilih Data Mahasiswa ***");
                        for (int i = 0; i < namaMahasiswaLST.Count; i++)
                        {
                            Console.WriteLine(i + ". " + namaMahasiswaLST[i] + " " + jurusanMahasiswaLST[i] + " " + smtMahasiswaLST[i]);
                        }

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

                        kuis = ConvertPersen(kuis, 10);
                        tugas = ConvertPersen(tugas, 10);
                        uts = ConvertPersen(uts, 30);
                        uas = ConvertPersen(uas, 50);

                        total = kuis + tugas + uts + uas;

                        Console.WriteLine();
                        Console.WriteLine(" *** Hasil IPK Mahasiswa *** ");
                        Console.WriteLine("Nama Mahasiswa = " + namaMahasiswaLST[plh]);
                        Console.WriteLine("Jurusan Mahasiswa = " + jurusanMahasiswaLST[plh]);
                        Console.WriteLine("Semester Mahasiswa = " + smtMahasiswaLST[plh]);
                        Console.WriteLine("Nilai Akhir Mahasiswa : " + total);
                        Console.WriteLine("Grade Mahasiswa : " + MyGrade(total));
                        Console.ReadKey();
                        goto awal;
                        break;

                    case 3:
                        tampilMahasiswa(namaMahasiswaLST, jurusanMahasiswaLST, smtMahasiswaLST);
                        goto awal;
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Pilih Data Mahasiswa :");
                        for (int i = 0; i < namaMahasiswaLST.Count; i++)
                        {
                            Console.WriteLine(i + ". " + namaMahasiswaLST[i] + " " + jurusanMahasiswaLST[i] + " " + smtMahasiswaLST[i]);
                        }

                        Console.Write("Pilih Mahasiswa : ");
                        plh = int.Parse(Console.ReadLine());

                        namaMahasiswaLST.RemoveAt(plh);
                        jurusanMahasiswaLST.RemoveAt(plh);
                        smtMahasiswaLST.RemoveAt(plh);
                        goto awal;
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("======== Terima kasih =========");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak ditemukan, Coba lagi !");
                        goto awal;
                        break;
                }
            }
            catch (FormatException e)
            {
               
                Console.WriteLine("Pilihan hanya bisa diinput bilangan bulat, Coba lagi !");
                goto awal;
            }


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

        static public int ConvertPersen(int nilai, int persen)
        {

            int hasilanPersen = 0;
            hasilanPersen = nilai * persen / 100;
            return hasilanPersen;
        }
        static void tampilMahasiswa(List<string> nma, List<string> jrs, List<string> smt)
        {
            Console.WriteLine();
            Console.WriteLine("*** Data Mahasiswa ***");
            Console.WriteLine("No | Nama | Jurusan | Semester");
            for (int i = 0; i < nma.Count; i++)
            {
                Console.WriteLine(i + ". | " + nma[i] + " | " + jrs[i] + " | " + smt[i]);
            }
            Console.ReadKey();
        }



    }
}
