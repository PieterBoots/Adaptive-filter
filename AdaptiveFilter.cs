using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AdaptiveFilter
{

  //W : are unknown filter coefficients
  //Data : is the data input for the filter
  //learnvalues : are the wanted output value of the filter.
  public static void bestmatch(ref double[] W, int[,] data, int[] learnvalues,double rate,int t)
  {


    int rows = data.GetLength(0);
    // q can control the rate of convergence and filter stability.
    double q = rate;
    Random rnd = new Random();


    int dimensions = data.GetLength(1);
    for (int r = 0; r < t; r++)
    {
      int y = rnd.Next(rows);

      double v = 0;
      //filter output V given by
      for (int x = 0; x < dimensions; x++)
      {
        v = v + data[y, x] * W[x];
      }
      //The error signal
      double err = learnvalues[y] - (v / dimensions);
      //filter coefficients are updated 
      for (int x = 0; x < dimensions; x++)
      {
        W[x] = W[x] + err * data[y, x] * q;
      }
    }
  }

    public static double filter( double[] W,int[] data)
  {
    double outp = 0;
    for (int x = 0; x < data.Length; x++)
    {
      outp = outp + W[x] * data[x];
    }

    return outp / data.Length;         
  }
}
