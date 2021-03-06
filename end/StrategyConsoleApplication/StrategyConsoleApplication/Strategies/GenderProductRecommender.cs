﻿using StrategyConsoleApplication.Interfaces;

namespace StrategyConsoleApplication.Strategies
{
    public class GenderProductRecommender : IProductRecommender
    {
        public Product Recommend(Customer customer)
        {
            if (customer.Gender == Gender.Male)
                return new Product("Rollex Sea-Dweller", this.GetType().ToString());
            else
                return new Product("Prada purse", this.GetType().ToString());
        }
    }
}
