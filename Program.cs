

public class program
{
    public static void Main()
    {
        // NestedLoop();
        //Printnumbers();
        // Pattern1();
        // pattern2();
        // pattern3();
        // pattern4();
        //pattern5();
        //pattern6();
        //pattern7();
        // pattern8();
        pattern9();
    }


    //public static void NestedLoop()
    //{
      /*  for (int A = 1; A <= 5; A++) 
        {

            for (int B = 1; B <= 12; B++)
            {
                Console.Write("$");
            }

            Console.WriteLine();
        }

      /*  for (int C = 1 ;  C <= 10; C++)
        {
            for (int D = 1; D <= 8;  D++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }*/
   // }

   // private static void Printnumbers()
   // {
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

        /*for (int B = 2; B <= 200; B = B*2)
        {
            Console.WriteLine(B);
        }*/

      public static void Pattern1()  //   G F E D C B A 7*10
      {
            for (int A = 10; A >= 1; A--)
            {
                for (int B = 7; B >= 1; B--)
                {
                    Console.Write(" " + Convert.ToChar(64 + B));
                }
                Console.WriteLine();

            }
      }
    
    public static void pattern2()                     //F F F F F F
    {                                                 //E E E E E E
        for (int c =  10;  c >= 1; c--)               //D D D D D D
        {                                             //C C C C C C
            for (int d = 1; d <=7 ; d++)              //B B B B B B
            {                                         //A A A A A A  
                Console.Write(" " + Convert.ToChar(64 + c));
            }
            Console.WriteLine();
        }
    }


    public static void pattern3()                                //lowercasea=97
    {
        Console.WriteLine("Please enter  value for the rows");       // a
        int Row = Convert.ToInt32(Console.ReadLine());               // b
                                                                     // TO
        Console.WriteLine("Please enter  value for the columns");    // x
        int Column = Convert.ToInt32(Console.ReadLine());            // z   




        for (int E = 1; E <= 26; E++)
        {
            for (int F = 1; F <= 26; F++)
            {
                Console.Write(" " + Convert.ToChar(96 + E));
            }
            Console.WriteLine();
        }

    }
    public static void pattern4()                                         //UPPERCASE A=65
    {
        Console.WriteLine("Please enter  value for the rows");            // A
        int Row = Convert.ToInt32(Console.ReadLine());                    // B
                                                                          // to
        Console.WriteLine("Please enter  value for the columns");         // Y
        int Column = Convert.ToInt32(Console.ReadLine());                 // Z

        for (int G = 1; G <= 26; G++)
        {
            for (int H = 1; H <= 26; H++)
            {
                Console.Write(" " + Convert.ToChar(64 + G));
            }
            Console.WriteLine();
        }
        

    }
    public static void pattern5()           // 1 2 3
    {                                       // 1 2 3   
                                            // 1 2 3   
        for (int I = 1; I <= 3; I++)
        {


            for (int J = 1; J <= 3; J++)
            {
                Console.Write(J);
            }


            Console.WriteLine();
        }

    }
    public static void pattern6()   // 1 2 3
    {                               // 4 5 6
        int K = 1;                  // 7 8 9
        for (int M = 1; M <= 3; M++)
        {


            for (int N = 1; N <= 3; N++)
            {
                Console.Write(( " "+K++));
            }


            Console.WriteLine();
        }

    }

    public static void pattern7()                            // A A A A A
    {                                                        // B B B B B
        for (int O = 1; O <= 5; O++)                        // C C C C C
        {                                                   // D D D D D
            for (int P = 1; P <= 5 ; P++)                   // E E E E E
            {
                Console.Write( " "+Convert.ToChar(64+O));
            }
            Console.WriteLine();
        }
        

        
    }

    public static void pattern8()                            // LIMIT P
    {
        Console.WriteLine("Please enter the limit");
        string str = Console.ReadLine();
        var limit = Convert.ToInt32(str);
        for(int Q=1;Q<=limit;Q++)
        {
            for(int R =1;R<=limit;R++)
            {
                Console.Write(R + " ");
            }
            Console.WriteLine();
        }
    }
    public static void pattern9()                              // A B C D E F G      1
    {                                                          // A B C D E F G      2
                                                                                  // TO
        for (int i = 1; i <= 10; i++)                                             // 10
        {


            for (int j = 1; j <= 7; j++)
            {
                Console.Write(" "+Convert.ToChar(64+j ));
            }


            Console.WriteLine();
        }
    }
}

