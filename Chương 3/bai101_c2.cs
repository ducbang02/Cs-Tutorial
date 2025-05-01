

using System;
class HelloWorld {
    // 01. Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày. 
    static bool LaNamNhuan(int nam){
        if((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0){
            return true;
        }
        return false;
    }
    
  static void Main() {
    
    Console.Write("Nhap thang: ");
    int thang = int.Parse(Console.ReadLine());
    
    Console.Write("Nhap nam: ");
    int nam = int.Parse(Console.ReadLine());

    if(LaNamNhuan(nam) && thang == 2){
        Console.WriteLine($"Thang nay co 29 ngay");
    }else if (!LaNamNhuan(nam) && thang == 2){
        Console.WriteLine($"Thang nay co 28 ngay");
    }else if(thang == 1 || thang == 3 ||  thang == 5 ||thang == 7 ||thang == 8 ||thang == 10 || thang == 12){
        Console.WriteLine($"Thang nay co 31 ngay");
    }else {
        Console.WriteLine($"Thang nay co 30 ngay");
    }
    
  }
}