﻿namespace BorderControl.Contracts
{
    public interface IBuyer
    {
        string Name { get; }

        int Food { get; }

        void BuyFood();
    }
}