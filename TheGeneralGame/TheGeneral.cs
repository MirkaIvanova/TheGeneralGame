using System;

namespace TheGeneral
{
    public class Game : IOperationSuccessCalculator
    {
        public const int minX = 0;
        public const int minY = 0;
        public const int maxX = 199;
        public const int maxY = 299;

        public Game() { }


        public bool IsAttackSuccessful(int x, int y)
        {
            if (x < minX || y < minY || x > maxX || y > maxY)
            {
                throw new ArgumentOutOfRangeException("Coordinates are out of allowed range");
            }

            if (((x + y - 5) % 2) == 0)
            {
                return true;
            }

            return false;
        }

        public bool IsDefenseSuccessful(int x, int y)
        {
            if (x < minX || y < minY || x > maxX || y > maxY)
            {
                throw new ArgumentOutOfRangeException("Coordinates are out of allowed range");
            }

            if (((x * y - 5) % 2) == 0)
            {
                return true;
            }

            return false;
        }

        public static void Main()
        {
        }
    }
}