

public class program
{
    public static void Main()
    {
        NestedLoop();
        //Printnumbers();
    }


    public static void NestedLoop()
    {
        for (int A = 1; A <= 10; A++) 
        {

            for (int B = 1; B <= 8; B++)
            {
                Console.Write("@A@");
            }

            Console.WriteLine();
        }

        for (int C = 1 ;  C <= 10; C++)
        {
            for (int D = 1; D <= 8;  D++)
            {
                Console.Write("*");
            }
        }
    }

    private static void Printnumbers()
    {
        /*  //Q print numbers from 100, 98, 94, 90, 88, 80

          for (int A = 100; A >=80 ; A=A-2)
          {
              Console.WriteLine(A);
          }*/

        //Q print numbers from 30 60 90 120  ...300

        /* for (int B = 30; B <= 300; B = B + 30)
         {
             Console.WriteLine(B);
         }*/

       /* //Q print numbers from 100 90 80 70 60 ...10

        for (int K = 100; K >= 50; K = K - 5)
        {
            Console.WriteLine(K);
        }*/
        //Q print numbers where are they multiply by 2

         for (int B = 2; B <= 200; B = B*2)
         {
             Console.WriteLine(B);
         }
    }
}
