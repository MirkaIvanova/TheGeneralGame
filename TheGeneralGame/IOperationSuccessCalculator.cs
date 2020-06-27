using System;

namespace TheGeneral
{
    public interface IOperationSuccessCalculator
    {
        bool IsAttackSuccessful(int x, int y);
        bool IsDefenseSuccessful(int x, int y);
    }
}
