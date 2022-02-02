using System;
using System.Collections.Generic;
using System.Text;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class CuisineTest
    {
        [Fact]
        public void Cuisine_bien_cree()
        {
            var cuisine = new CuisineBuilder().Creer("resto1").Build();

            Assert.NotNull(cuisine.Restaurant);
        }
    }
}
