﻿using System;
using System.Collections.Generic;

class Employee
{
    public string? ID { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Workingdays { get; set; }
    private const double price = 50;

    public double salary => Workingdays * price;
    public Employee(string id, string name, int age, int workingdays)
    {
        ID = id;
        Name = name;
        Age = age;
        Workingdays = workingdays;

    }
    public Employee() { }
    public void Input()
    {

        Console.WriteLine("Nhap so ID:");
        ID = Console.ReadLine()!;
        Console.WriteLine("Nhap ho ten:");
        Name = Console.ReadLine()!;
        Console.WriteLine("Nhap tuoi:");
        Age = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap so ngay cong:");
        Workingdays = int.Parse(Console.ReadLine()!);
    }
    public void Output()
    {
        Console.WriteLine("So ID:" + ID);
        Console.WriteLine("Name:" + Name);
        Console.WriteLine("Tuoi:" + Age);
        Console.WriteLine("So Ngay cong:" + Workingdays);
        Console.WriteLine("Luong:" + salary);
    }

}
class Program
{
    static void Main(string[] args)
    {
        List<Employee> dsNhanvien = new List<Employee>();
        int n;
        Console.WriteLine("nhap so nhan vien:");
        n = int.Parse(Console.ReadLine()!);
        Employee nv = new Employee();
        for (int i = 1; i <= n; i++)
        {
            nv.Input();
            dsNhanvien.Add(nv);
            nv.Output();
        }



    }


}