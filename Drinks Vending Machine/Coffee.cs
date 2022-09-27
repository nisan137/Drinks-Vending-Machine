namespace Drinks_Vending_Machine
{
    internal class Coffee : Beverages
    {
        private int _coffeeBeansDoses = 10;

        /// <summary>
        /// Coffee constractor that inheritor
        /// from beverage class & requires: Name, price.
        /// </summary>
        /// <param Name="name"></param>
        /// <param Name="price"></param>
        public Coffee(string name = "Coffee", double price = 8) : base(name, price)
        {
        }

        /// <summary>
        /// <br>Reduces the amount of the 'coffee beans' by 1.</br>
        /// Adding the ingredients to the cup
        /// <br>call 3 functions from the 'vending machine' class,</br>
        /// that tells the params to reduces the amount by 1.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns>Confirmation message</returns>
        protected override string AddIngredients(VendingMachine machine)
        {
            _coffeeBeansDoses--;
            machine.UseCups();
            machine.UseSuger();
            machine.UseMilk();

            return $"- Adding the coffee beans to the cup\n";
        }
        /// <summary>
        /// Adding the hot water to the cup.
        /// </summary>
        /// <returns>Confirmation message</returns>
        protected override string AddHotWater()
        {
            return $"- Adding the hot water to the cup\n";
        }
        /// <summary>
        /// Stirring the beverage.
        /// </summary>
        /// <returns>Confirmation message</returns>
        protected override string Stirring()
        {
            return $"- Stirring the coffee for you\n";
        }
        /// <summary>
        /// Restock the coffee beans for up to 10 doses.
        /// </summary>
        /// <returns>Confirmation message</returns>
        public override string ReStock()
        {
            _coffeeBeansDoses = 10;
            return $"- Restock coffee beans for up to 10 doses";
        }
    }
}
