
using System;

//111a. Viết chương trình in ra tam giác cân có độ cao h. tam giac can nam giua man hinh

class HelloWorld {
  static void Main() {
    int h = 4;

    for (int i = 0; i < h; i++)
    {
        int soSao = 2 * i + 1;
        int soKhoangTrang = h - i - 1;

        // In khoảng trắng để căn giữa
        Console.Write(new string(' ', soKhoangTrang));

        // In dấu *
        Console.WriteLine(new string('*', soSao));
    }
  }
}