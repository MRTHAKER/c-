using System;
 class pro
    {
        pro()
        {
        }


        pro(int x,int y,int z)
        {
            pro p2 = new pro();
            p2.a();
            p2.a(x,y,z);
            p2.a(x,y);
        }

        void a()
        {
            Console.WriteLine("nothing here");
        }
        void a(int x,int y)
        {
            int ans=x+y;
            Console.WriteLine("ans is"+ans);
        }

        void a(int x, int y, int z)
        {
            int ans = x + y + z;
            Console.WriteLine("ans is" + ans);
        }

        public static void Main()
        {
            pro p1 = new pro(10, 20, 30);
            Console.Read();

        }

    }
}
