

using System;

class Program
{
    //111c. Viết chương trình in ra tam giác cân có độ cao h. tam giac can vuong can lenh trai
    static void Main()
    {

        int h = 4;

        for (int i = 1; i <= h; i++){
            for(int j = 1; j <= i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
