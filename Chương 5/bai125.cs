

using System;

class Program
{
    //125. Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
    static bool KiemTraNguyenTo(int n){
        int dem = 0;
        for(int i = 1; i <= n; i++){
            if(n % i == 0){
                dem++;
            }
        }
        return dem == 2;
    }
    
    static int DemNguyenTo(int[] array){
        int dem = 0;
        foreach(int i in array){
            if(KiemTraNguyenTo(i) && i < 100){
                dem++;
            }
        }
        
        return dem;
    }
    
    
    static void Main(){
        int[] array = {2, 5, 97, 9, 12, 101, 93};
        

        Console.WriteLine(DemNguyenTo(array));
        
    }
}
