

using System;

class Program
{
    //111b. Viết chương trình in ra tam giác cân có độ cao h. tam giac can rong nam giua man hinh
    static void Main()
    {

        int h = 4;

        for (int i = 0; i < h; i++)
        {
            int soSao = 2 * i + 1; // số lượng ký tự trên dòng
            int soKhoangTrang = h - i - 1;

            // In khoảng trắng để căn giữa
            Console.Write(new string(' ', soKhoangTrang));

            // In dòng đầu và cuối: in toàn bộ dấu *
            if (i == 0 || i == h - 1)
            {
                Console.WriteLine(new string('*', soSao));
            }
            else
            {
                // In dấu * đầu dòng
                Console.Write("*");

                // In khoảng trắng giữa hai dấu *
                Console.Write(new string(' ', soSao - 2));

                // In dấu * cuối dòng
                Console.WriteLine("*");
            }
        }
    }
}
