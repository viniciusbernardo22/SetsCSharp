SortedSet<int> a = new SortedSet<int>() { 0,1, 2,4,6 ,7, 8,9 ,10};
SortedSet<int> b = new SortedSet<int>() {1,  5 , 6 , 7, 8, 9 , 10};
PrintCollection(a);

//union  ( Une conjuntos mas sem repetições )
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

//Intersection ( une os itens que existem nos dois conjuntos. ) 
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

//Diff ( elementos que só existem no A ) 
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var obj in collection)
    {
        Console.Write(obj + " ");
    }

    Console.WriteLine();
}

