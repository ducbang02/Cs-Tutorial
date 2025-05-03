
using System;

class Program
{
    //130. Viết hàm xuất mảng 1 chiều các số thực 
    
    static void XuatMang(double[] array){
        //Cach 1:
        // int n = array.Length;
        // for(int i = 0; i < n; i++){
        //     Console.Write($"{array[i]} ");
        // }
        
        //Cach 2:
        foreach(double i in array){
            Console.Write($"{i} ");
        }
    }

    
    static void Main(){
        double[] array = {2.3, 5, 8.2, 9};
        
        XuatMang(array);
    }
}
