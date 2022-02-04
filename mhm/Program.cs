using System;
using System.Collections;
ArrayList a = new ArrayList();
a.Add("Anggur");
a.Add("Belimbing");
a.Add("Cherry");
a.Add("Delima");
a.Add("Jambu");
a.Add("Jeruk");
a.Add("Kiwi");
Menu:
Console.WriteLine("Silahkan pilih keperluan anda:");
Console.WriteLine("");
Console.WriteLine("1. Menambahkan daftar buah");
Console.WriteLine("2. Menyisipkan buah dalam daftar");
Console.WriteLine("3. Mencari buah dalam daftar");
Console.WriteLine("4. Menghapus buah dalam daftar berdasarkan nama");
Console.WriteLine("5. Menghapus buah dalam daftar berdasarkan index");
Console.WriteLine("6. Menghapus beberapa buah dalam daftar");
Console.WriteLine("");
Console.WriteLine("Silahkan ketik pilihan anda");
int buah;
buah = int.Parse(Console.ReadLine());
switch (buah)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Masukkan nama buah");
        string b;
        b = Console.ReadLine();
        a.Add(b);
        Console.Clear();
        foreach (string b1 in a)
        Console.WriteLine(b1);
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string b2;
        b2 = Console.ReadLine();
        Console.Clear();
        if (b2 == "Y")
            goto Menu;
        else
            break;

    case 2:
        Console.Clear();
        Console.WriteLine("Masukkan urutan (dimulai 0) dan nama buah");
        int c;
        c = int.Parse(Console.ReadLine());
        string c1;
        c1 = Console.ReadLine();
        a.Insert(c, c1);
        Console.Clear();
        foreach (string c2 in a)
        Console.WriteLine(c2); ;
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string c3;
        c3 = Console.ReadLine();
        Console.Clear();
        if (c3 == "Y")
            goto Menu;
        else
            break;

    case 3:
        Console.Clear();
        Console.WriteLine("Cari buah berdasarkan nama");
        string d;
        d = Console.ReadLine();
        Console.Clear();
        if (a.Contains(d))
            Console.WriteLine("Buah " + d + " ditemukan");
        else
        {
            Console.WriteLine("Maaf, Buah " + d + " tidak ditemukan");
        }
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string d1;
        d1 = Console.ReadLine();
        Console.Clear();
        if (d1 == "Y")
            goto Menu;
        else
            break;
    case 4:
        Console.Clear();
        Console.WriteLine("Masukkan nama buah");
        string e;
        e = Console.ReadLine();
        a.Remove(e);
        Console.Clear();
        foreach (string e1 in a)
            Console.WriteLine(e1);
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string e2;
        e2 = Console.ReadLine();
        Console.Clear();
        if (e2 == "Y")
            goto Menu;
        else
            break;
    case 5:
        Console.Clear();
        Console.WriteLine("Masukkan urutan buah (dimulai dari 0)");
        int f;
        f = int.Parse(Console.ReadLine());
        a.RemoveAt(f);
        Console.Clear();
        foreach (string f1 in a)
            Console.WriteLine(f1);
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string f2;
        f2 = Console.ReadLine();
        Console.Clear();
        if (f2 == "Y")
            goto Menu;
        else
            break;
    case 6:
        Console.Clear();
        Console.WriteLine("Masukkan urutan buah awal (dimulai dari 0) dan jumlah buah yang ingin dihapus");
        int g;
        g = int.Parse(Console.ReadLine());
        int g1;
        g1 = int.Parse(Console.ReadLine());
        a.RemoveRange(g, g1);
        Console.Clear();
        foreach (string g2 in a)
            Console.WriteLine(g2);
        Console.WriteLine("Apakah anda ingin melakukan sesuatu lagi? (Y/N)");
        string g3;
        g3 = Console.ReadLine();
        Console.Clear();
        if (g3 == "Y")
            goto Menu;
        else
            break;
}