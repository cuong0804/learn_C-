using System;
using System.Collections.Generic;
class ThiSinhA{
    public string? SBD {get;set;}
    public string? Hoten {get;set;}
    public string? Diachi {get;set;}
    public double Toan {get;set;}
    public double Ly {get;set;}
    public double Hoa{get; set;}
    public double Diemuutien {get;set;}
    public double tongdiem{get{return Toan + Ly+ Hoa+ Diemuutien;}}
    public ThiSinhA(){}
    public ThiSinhA(string sbd,string hoten,string diachi,double toan,double ly,double hoa,double diemuutien){
        SBD=sbd;
        Hoten=hoten;
        Diachi=diachi;
        Toan =toan;
        Ly =ly;
        Hoa =hoa;
        Diemuutien=diemuutien;
    }
    public void Nhap(){
        Console.Write("Nhap so bao danh:/");
        SBD=Console.ReadLine();
        Console.Write("nhap ho ten:/");
        Hoten=Console.ReadLine();
        Console.Write("nhap dia chi:/");
        Diachi=Console.ReadLine();
        Console.Write("nhap diem toan:/");
        Toan=double.Parse(Console.ReadLine()!);
        Console.Write("nhap diem ly:/");
        Ly=double.Parse(Console.ReadLine()!);
        Console.Write("Nhap diem hoa:/");
        Hoa=double.Parse(Console.ReadLine()!);
        Console.Write("Nhap diem uu tien:/");
        Diemuutien=double.Parse(Console.ReadLine()!);
    }
    public void xuat(){
        Console.WriteLine("So bao danh:"+SBD);
        Console.WriteLine("Ho va ten :"+ Hoten);
        Console.WriteLine("Dai chi :"+ Diachi);
        Console.WriteLine("diem toan:"+Toan);
        Console.WriteLine("diem Ly:"+ Ly);
        Console.WriteLine("diem hoa "+ Hoa);
        Console.WriteLine("diem Uu tien: "+Diemuutien);
        Console.WriteLine("tong diem:"+tongdiem);

    }

}

class Program{
    

   static void Main(string [] args)
   {
    List<ThiSinhA> dsThiSinh = new List<ThiSinhA>();
            int chon;
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Nhap thong tin 1 thi sinh");
                Console.WriteLine("2. Hien thi danh sach cac thi sinh");
                Console.WriteLine("3. Hien thi thi sinh theo tong diem");
                Console.WriteLine("4. Hien thi thi sinh theo dia chi");
                Console.WriteLine("5. Tim kiem thi sinh theo so bao danh");
                Console.WriteLine("6. Ket thuc chuong trinh");

                chon = int.Parse(Console.ReadLine()!);
                switch (chon)
                {
                    case 1:
                        ThiSinhA ts = new ThiSinhA();
                        ts.Nhap();
                        dsThiSinh.Add(ts);
                        break;
                    case 2:
                        foreach (ThiSinhA ts1 in dsThiSinh)
                        {
                            ts1.xuat();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap tong diem: ");
                        int tongDiem = int.Parse(Console.ReadLine()!);
                        foreach (ThiSinhA ts1 in dsThiSinh)
                        {
                            if (ts1.tongdiem >= tongDiem)
                            {
                                ts1.xuat();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap dia chi: ");
                        string diaChi = Console.ReadLine()!;
                        foreach (ThiSinhA ts1 in dsThiSinh)
                        {
                            if (ts1.Diachi == diaChi)
                            {
                                ts1.xuat();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nhap so bao danh: ");
                        string sbd = Console.ReadLine()!;
                        bool found = false;
                        foreach (ThiSinhA ts1 in dsThiSinh)
                        {
                            if (ts1.SBD == sbd)
                            {
                                ts1.xuat();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Khong tim thay thi sinh");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Nhap sai. Vui long nhap lai!");
                        break;
                }
            } while (chon != 6);

            Console.ReadLine();
            
    
   }

}