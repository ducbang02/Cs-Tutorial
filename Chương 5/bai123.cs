

using System;

class Program
{
    //123. Viết hàm tìm 1 vị trí mà giá trị tại ví trí đó là 1 giá trị nhỏ nhất 
    //trong mảng 1 chiều các số nguyên 
    static int TimViTri(int[] array){
        int lc = 0;
        
        for(int i = 0; i < array.Length; i++){
            if(array[i] < array[lc]){
                lc = i;
            }
        }
        
        return lc;
    }
    
    static void Main(){
        int[] array = {3, 5, 8, 2, 33, 1, 7};
        
        Console.WriteLine(TimViTri(array));
        
    }
}
