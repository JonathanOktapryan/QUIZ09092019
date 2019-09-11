using System;

namespace Visual_Studio_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            bangun_ruang obj = new bangun_ruang();

            int p, l, t, s;
//volume balok
            Console.WriteLine("Menghitung Volume Balok");  
            Console.Write("Masukkan Nilai Panjang = ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Lebar = ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai Tinggi = ");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai Balok adalah "+obj.tampil_volume_balok(p,l,t));
            Console.WriteLine("=======================");
//Volume Kubus
            Console.WriteLine("Menghitung Volume Kubus"); 
            Console.Write("Masukkan Nilai Sisi = ");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai Kubus adalah "+obj.tampil_volume_kubus(s));
            Console.WriteLine("=======================");


            
            
            
            bangundatar objt = new bangundatar();
           
            int si, a, ti, r;
//Luas Persegi
            Console.WriteLine("Menghitung Luas Persegi"); 
            Console.Write("Masukkan panjang sisi =");
            si = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas Persegi adalah "+objt.tampil_luas(si));
            Console.WriteLine("=======================");
//Luas Segitiga
            Console.WriteLine("Menghitung Luas Segitiga"); 
            Console.Write("Masukkan nilai alas = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Tinggi = ");
            ti = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas Segitiga adalah "+objt.tampil_segitiga(a, ti));
            Console.WriteLine("========================");
//Luas Lingkaran
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.Write("Masukkan nilai jari-jari = "); 
            r = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("Luas Lingkaran adalah "+objt.tampil_lingkaran(s));
            Console.WriteLine("========================");
        }    
    }
}
