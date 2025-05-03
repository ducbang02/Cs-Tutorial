

using System;

class Program
{
    //127. Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần
    
    static void SapXep(double[] array){
        int length = array.Length;
        for(int i = 0; i < length - 1; i++){
            for(int j = i + 1; j < length; j++){
                if(array[j] < array[i]){
                    double temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
    
    static void Main(){
        double[] array = {-2, -5, 97, 9, 12, 101, 93};
        
        SapXep(array);
        
        foreach(double i in array){
            Console.Write($"{i} ");
        }

    }
}
