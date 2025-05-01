

using System;

class Program
{
    //109. In bang cua chuong
    static void Main()
    {

        for(int i = 1; i <= 10; i++){
            for(int j = 1; j <= 9; j++){
                Console.Write($"{j} * {i} = {i*j} |");
            }
            Console.WriteLine();
        }
    }
}
