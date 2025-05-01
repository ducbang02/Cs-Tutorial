

using System;

class Program
{
    ////124. Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị 
    //chẵn nhỏ hơn 2004 hay không?
    
    static bool KiemTra(int[] array){
        
        for(int i = 0; i < array.Length; i++){
            if(array[i] < 2004 && array[i] % 2 == 0){
                return true;
            }
        }
        
        return false;
    }
    
    static void Main(){
        int[] array = {2002};
        
        Console.WriteLine(KiemTra(array));
        
    }
}
