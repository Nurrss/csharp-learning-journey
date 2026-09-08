using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string status = "";
        bool f = isPrime(17);
        if (f){
            status = "true";
        }else{
            status = "false";
        }
        Console.WriteLine("17: " + status);
        bool s = isPrime(18);
        if (s){
            status = "true";
        }else{
            status = "false";
        }
        Console.WriteLine("18: " + status);
    }

    static bool isPrime(int n){
        int x = 0;
        int down = n;
        while(down > 0){
            if(n % down == 0){
                x++;
            }
            down--;
        }
        if(x > 2){
            return false;
        }
        else
        {
            return true;
        }
    }
}

