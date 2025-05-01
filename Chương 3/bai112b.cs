
using System;

//112b. Xuat hinh chu nhat rong *
class HelloWorld {
  static void Main() {
    int row = 4;
    int column = 7;
    
    for(int i = 1; i <= row; i++){
        for(int j = 1; j <= column; j++){
            if(i == 1 || i == row || j == 1 || j == column){
                Console.Write("*");
            }else {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
  }
}