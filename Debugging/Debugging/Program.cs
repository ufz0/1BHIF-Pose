int x = 4;
int y = 3;
int z = 0;

for (int i = 0; i < 10; i++)
{
    z = z + x * y / x;
    y = y + i;
    x = x + i;
}

Console.WriteLine($"Werte am Programmende: x: {x}, y: {y}, z: {z}");
Console.ReadKey();