public static class GraphBasics
{
    /// <summary>
    /// Creates an undirected adjacency list for nodes numbered from 0 through
    /// <paramref name="nodes"/> - 1.
    /// </summary>
    /// <param name="nodes">The total number of nodes in the graph.</param>
    /// <param name="edges">
    /// A two-dimensional array whose rows contain the two endpoints of each edge.
    /// </param>
    /// <returns>An adjacency list indexed by node number.</returns>
    public static List<int>[] CreateAdjacenyListSequential(int nodes, int[,] edges)
    {
        //TO CHECK IF NODE NUMBERS ARE VALID
        if(nodes < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(nodes));
        }

        if(edges.GetLength(1) != 2)
        {
            throw new ArgumentException("Each edge must have 2 nodes", nameof(edges));
        }

        //Initialize the adjacanyList
        List<int>[] adjacanyList = new List<int>[nodes];
        for(int i = 0; i<nodes; i++)
        {
            adjacanyList[i] = new List<int>();
        }

        //Iterate through edges and add to the list
        for(int i = 0; i< edges.GetLength(0); i++)
        {
            int u = edges[i,0];
            int v = edges[i,1];
            
            if(u<0 || u >= nodes || v<0 || v >= nodes)
            {
                throw new ArgumentException("Edge contains nodes outside valid range", nameof(edges));
            }

            adjacanyList[u].Add(v);
            if(u!=v)
                adjacanyList[v].Add(u);
        }

        return adjacanyList;        
    }

    /// <summary>
    /// Creates an undirected adjacency list for graphs whose node identifiers
    /// do not need to be sequential.
    /// </summary>
    /// <param name="edges">
    /// A two-dimensional array whose rows contain the two endpoints of each edge.
    /// </param>
    /// <returns>
    /// A dictionary that maps each node identifier to its neighboring nodes.
    /// </returns>
    public static Dictionary<int, List<int>> CreateAdjacenyListNonSequential(int[,] edges)
    {
        if(edges.GetLength(1) != 2)
        {
            throw new ArgumentException("Each edge must have 2 nodes", nameof(edges));
        }

        //Initialize the adjacanyList
        Dictionary<int, List<int>> NonSequentialAdjacancyList = new Dictionary<int, List<int>>();        

        //Iterate through edges and add to the list
        for(int i = 0; i< edges.GetLength(0); i++)
        {
            int u = edges[i,0];
            int v = edges[i,1];

            if(!NonSequentialAdjacancyList.ContainsKey(u))
                NonSequentialAdjacancyList[u] = new List<int>();
            NonSequentialAdjacancyList[u].Add(v);
            
            if(!NonSequentialAdjacancyList.ContainsKey(v))
                NonSequentialAdjacancyList[v] = new List<int>();
            NonSequentialAdjacancyList[v].Add(u);
            
        }

        return NonSequentialAdjacancyList;          
    }

    /// <summary>
    /// Writes every sequential node and its neighbors to the console.
    /// </summary>
    /// <param name="graph">The adjacency list to display.</param>
    public static void IterateThroughAdjacancyList(List<int>[] graph)
    {
        var length = graph.Length;
        for(int i=0; i<length;i++)
        {
            Console.Write($"Connection from {i} is: ");
            foreach(var neighbor in graph[i])
            {
                Console.Write($"{neighbor} ");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Writes every non-sequential node and its neighbors to the console.
    /// </summary>
    /// <param name="graph">
    /// The adjacency list, keyed by node identifier, to display.
    /// </param>
    public static void IterateThroughNonSequentialAdjacancyList(Dictionary<int, List<int>> graph)
    {
        foreach(var item in graph)
        {
            Console.Write($"Neighbors of {item.Key} is: ");
            foreach(var neighbor in item.Value)
            {
                Console.Write($"{neighbor}  ");
            }
            Console.WriteLine();
        }
    }
}
