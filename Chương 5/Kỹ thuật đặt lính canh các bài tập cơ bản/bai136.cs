
using System;
class HelloWorld {
    //136. Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên(chancuoi). 
    //Nếu mảng không có giá trị chẵn thì trả về giá trị -1
    static int TimGiaTri(int[] array){
        int length = array.Length;
        for(int i = length - 1; i >= 0; i--){
            if(array[i] % 2 == 0){
                return array[i];
            }
        }
        return -1;
    }
    
    static void Main() {
        int [] array = {-5, 2, 5, -2, -9};
        
        Console.WriteLine(TimGiaTri(array));
    }
}