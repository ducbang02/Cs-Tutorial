using System;

class Program
{
    // Bài 121: Liệt kê tất cả các số Amstrong trong đoạn [1, 1_000_000]
    static bool LaSoAmstrong(int n){
        int k = n.ToString().Length;
        int sum = 0;
        int temp = n;
        while(temp > 0){
            int m = temp % 10;
            sum += (int)Math.Pow(m, k);
            temp /= 10;
        }
        return sum == n;
    }
    

    static void Main(){
        Console.WriteLine("tất cả các số Amstrong trong đoạn [1, 1_000_000]: ");
        for(int i = 1; i <= 1000000; i++){
            if(LaSoAmstrong(i)){
                Console.WriteLine($"{i} ");
            }
        }
    }
    
}
