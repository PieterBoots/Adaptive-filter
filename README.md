# Adaptive-filter
Adaptive lms filter 

With application in machine learning, echo cancelation, noise cancelation and regression.
Have a look at this website https://en.wikipedia.org/wiki/Adaptive_filter

This is how the library can be used.

  int[,] inp=new int[100000,4];
        int[] learn=new int[100000];

        Random rnd=new Random();
        for (int t = 0; t< 9; t++)
        {
          for (int a = 0; a < 9; a++)
          {
            for (int b = 0; b < 9; b++)
            {
              for (int c = 0; c < 9; c++)
              {
                for (int d = 0; d < 9; d++)
                {
                  int position = a + b * 10 + c * 100 + d * 1000 + t * 10000;
                  learn[position] = a * 3 + b * -6 + c * 12 + d * -2+ rnd.Next(-10, 10);
                  inp[position, 0] = a ;
                  inp[position, 1] = b ;
                  inp[position, 2] = c ;
                  inp[position, 3] = d ;
                }
              }
            }
          }
        }

        double[] W =new double[4];

        AdaptiveFilter.bestmatch(ref W, inp, learn, 0.00001, 1000000);  
  
  
