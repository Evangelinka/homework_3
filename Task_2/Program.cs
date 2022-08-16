// Программа, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

double Distance_3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return dist;
}

Console.WriteLine(Distance_3D(3,6,8,2,1,-7));
Console.WriteLine(Distance_3D(7,-5,0,1,-1,9));