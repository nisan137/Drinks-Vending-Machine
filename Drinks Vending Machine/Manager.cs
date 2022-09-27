using System;
using Windows.UI.Xaml.Controls;

namespace Drinks_Vending_Machine
{
    internal class Manager
    {
        VendingMachine vendingMachine;

        /// <summary>
        ///  Every time we add a new beverage
        ///  it will need to be added to the manager constructor,
        ///  which initializes the beverages classes.
        /// </summary>
        public Manager()
        {
            vendingMachine = new VendingMachine();

            vendingMachine.AddBeverage(new Coffee("Coffee", 8));
            vendingMachine.AddBeverage(new Tea("Tea", 4));
            vendingMachine.AddBeverage(new ChocolateMilk("ChocolateMilk", 13.5));
        }

        /// <summary>
        /// Prepar the choosen beverage
        /// and check if there is enough ingredieants
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Confirmation message</returns>
        /// <exception cref="IngredientsOutOfStockException"></exception>
        public string PreparChoosenBeverage(string name)
        {
            try
            {
                return vendingMachine.PrepareBeverge(name);
            }
            catch (IngredientsOutOfStockException e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// This restock func calls the "ReStockIngredient" func 
        /// in the <see cref="VendingMachine"/> calss.
        /// Restock all ingredient for up to 10 doses.
        /// </summary>
        /// <returns>Confirmation message</returns>
        public string ReStockIngredientChoosen()
        {
           return vendingMachine.ReStockIngredient();
        }
    }
}

