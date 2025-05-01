

using System;

class Program
{
    //122. Tìm số lớn nhất trong mảng 1 chiều số thực
    static void Main()
    {
        double [] array = {5, 6, 8, 9.2, 2.6};
        
        double max = array[0];
        
        foreach(double i in array){
            if(i > max){
                max = i;
            }
        }
        
        Console.WriteLine(max);
    }
}
