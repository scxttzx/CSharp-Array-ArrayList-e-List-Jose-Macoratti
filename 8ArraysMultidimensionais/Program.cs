int[,] n = {
    { 11, 22, 33 }, // n[0,0] n[0,1] n[0,2]
    { 44, 55, 66 }, // n[1,0] n[1,1] n[1,2]     n[3,3] -> n[i,j]
    { 77, 88, 99 }  // n[2,0] n[2,1] n[2,2]

};

Console.WriteLine("for")
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.WriteLine($"{n[i,j]}");
    }
}


Console.WriteLine("foreach");
foreach (var x in n)
{
    Console.WriteLine($"{x}");
}

Console.ReadKey();