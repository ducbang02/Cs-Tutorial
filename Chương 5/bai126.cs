

using System;

class Program
{
    //126. Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực 
    
    static double TinhTong(double[] array){
        double tong = 0;
        foreach(double i in array){
            if(i < 0){
                tong += i;
            }
        }
        return tong;
    }
    
    static void Main(){
        double[] array = {-2, -5, 97, 9, 12, 101, 93};
        

        Console.WriteLine(TinhTong(array));
        
    }
}
