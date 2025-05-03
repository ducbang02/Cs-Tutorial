
using System;
class HelloWorld {
    //135. Tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực(duongdau). 
    //Nếu mảng không có giá trị dương thì trả về giá trị -1
    static double TimGiaTri(double[] array){
        foreach(double i in array){
            if(i > 0){
                return i;
            }
        }
        return -1;
    }
    
    static void Main() {
        double [] array = {-5, 2.5, 5.6, -2};
        
        Console.WriteLine(TimGiaTri(array));
    }
}