using System;

namespace kpro
{
    class lol
    {
        int x, y, z = 20,ans;
        lol()
        {
            Console.WriteLine("this is default");
        }

        lol(int x, int y)
        {
            int ans;
            ans = x + y + z;
            this.ans = ans;
            Console.WriteLine(+this.ans);
        }

        lol(int x, int y, int z)
        {
            int ans;
            ans = x + y + z;
            this.ans = ans;
            Console.WriteLine(+this.ans);
        }

        static void Main()
        {
            lol lol1 = new lol();
            lol lol2 = new lol(20, 30);
            lol lol3 = new lol(20, 30, 40);
            Console.Read();
        }

    }
}
