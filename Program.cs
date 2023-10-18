int v,d,t;

Console.Write("Distância percorrida (m): ");
d = Convert.ToInt32(Console.ReadLine());

Console.Write("Tempo gasto (s): ");
t = Convert.ToInt32(Console.ReadLine());

v = d / t;
Console.Write($"Velocidade média: {v} m/s ");