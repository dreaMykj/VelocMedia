double v,d,t;

Console.Write("Distância percorrida (m): ");
d = Convert.ToDouble(Console.ReadLine());

Console.Write("Tempo gasto (s): ");
t = Convert.ToDouble(Console.ReadLine());

v = d / t;
Console.Write($"Velocidade média: {v} m/s ");