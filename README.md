# Adaptive-filter
Adaptive lms filter 

With application in machine learning, echo cancelation, noise cancelation and regression.
Have a look at this website https://en.wikipedia.org/wiki/Adaptive_filter

This is how the library can be used.

  int[,] inpdata=new int[]{
  {2,4,5,6},
  {7,8,9,4},
  {5,9,12,15},
  {13,16,18,20},
  {23,34,45,12},
  {15,45,78,12},
  {23,56,79,90},
  {56,65,76,87},
  {23,34,56,89},
  {12,23,56,89}};
  
  int[] learndata1=new int[]{5,9,12,18,34,78,56,76,34,56};
  
  double[] W1=new double[4];
  
  AdaptiveFilter.bestmatch(ref W1, inpdata, learndata1, 0.00001, 100000);
  
  
