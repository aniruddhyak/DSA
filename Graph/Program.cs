
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = 5;
      
        //sequential nodes
        int[,] edgesSN = {{0,1},{2,1},{3,4}};
        GraphBasics.CreateAdjacenyListSequential(n, edgesSN);
        GraphBasics.IterateThroughAdjacancyList();

        //Non-Sequential nodes
        int[,] edgesNSN = {{100,500},{500,7000},{7000,9999}, {100,800}};
        GraphBasics.CreateAdjacenyListNonSequential(edgesNSN);
        GraphBasics.IterateThroughNonSequentialAdjacancyList();
    }
}
