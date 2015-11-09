using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AdaptiveFilter
{

  //W: are unknown filter coefficients
  //data : is the data input for the filter
  //learnvalues : are the wanted output value of the filter.
  //rate:  can control the rate of convergence and filter stability.
  //iteration: Update repetitions
  public static void bestmatch(ref double[] W, int[,] data, int[] learnvalues,double rate,int iteration)
  {

    int rows = data.GetLength(0);
  
    Random rnd = new Random();

    int dimensions = data.GetLength(1);
    
    for (int r = 0; r < iteration; r++)
    {
      int row = rnd.Next(rows);

      double FilterOutput = 0;
      //Calculate filter output
      for (int d = 0; d < dimensions; d++)
      {
        FilterOutput = FilterOutput + data[row, d] * W[d];
      }
      //The error signal
      double err = learnvalues[row] - FilterOutput;
      //filter coefficients are updated 
      for (int d = 0; d < dimensions; d++)
      {
        W[d] = W[d] + err * data[row, d] * rate;
      }
    }
  }


  public static double filter( double[] W,int[] data)
  {
    double FilterOutput = 0;
    for (int d = 0; d < data.Length; d++)
    {
      FilterOutput = FilterOutput + W[d] * data[d];
    }
    return FilterOutput / data.Length;         
  }
  
  
  
}
