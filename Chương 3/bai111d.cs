

using System;

class Program
{
    //111d. Viết chương trình in ra tam giác cân có độ cao h. tam giac can vuong can lenh trai rong
    static void Main()
    {

        int h = 5;

        for (int i = 1; i <= h; i++){
            for(int j = 1; j <= i; j++){
                if(j == 1 || j == i || i == h){
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
