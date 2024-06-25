using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "NESWW";

            int x = 0;
            int y = 0;

            List<(int, int)> roadMap = new List<(int, int)>
            {
                (x, y) // Начальная позиция
            };

            foreach (char c in path)
            {
                if (c == 'N')
                {
                    y++;
                }
                else if (c == 'S')
                {
                    y--;
                }
                else if (c == 'W')
                {
                    x--;
                }
                else if (c == 'E')
                {
                    x++;
                }

                var newCoordinate = (x, y);

                if (!roadMap.Contains(newCoordinate))
                {
                    roadMap.Add(newCoordinate); 
                }
                else
                {
                    Console.WriteLine($"Координата ({x}, {y}) уже существует в списке.");
                }
            }

            for (int i = 0; i < roadMap.Count; i++)
            {
                var coordinate = roadMap[i];
                Console.WriteLine($"X: {coordinate.Item1}, Y: {coordinate.Item2}");
            }
        }
    }
}
