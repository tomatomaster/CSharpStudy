using System;

public class PrimeNum{
    static void Main() {
        for (int i = 2; i <= 100; i++)
        {
            for (int j = 2; j < i;j++){
                if(i%j!=0) {
                    if(j==i-1) {
                        Console.WriteLine(i);
                    }
                } else {
                    break;
                }
            }
        }
    }
}