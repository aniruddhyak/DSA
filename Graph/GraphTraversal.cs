public static class GraphTraversal
{
    public static List<int> DFSTraversalRec(int start, Dictionary<int, List<int>> graph)
    {
        if(!graph.ContainsKey(start))
            throw new Exception("Start Element is not present"); 

        HashSet<int> isVisited = new HashSet<int>();
        List<int> traversedList = new List<int>();

        DFSRecucrsive(start, graph, isVisited, traversedList);

        return traversedList;        
    }

    private static void DFSRecucrsive(int node, Dictionary<int, List<int>> graph, HashSet<int> isVisited, List<int> traversedList)
    {

        if(!isVisited.Contains(node))
        {
            isVisited.Add(node);            
            traversedList.Add(node);

            foreach (var neighbor in graph[node])
            {
                    DFSRecucrsive(neighbor, graph, isVisited, traversedList);
            }
        }       
        
    }
}