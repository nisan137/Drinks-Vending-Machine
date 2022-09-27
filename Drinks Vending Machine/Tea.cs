using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Vending_Machine
{
    internal class Tea : Beverages
    {
        private int _teaBags = 10;

        public Tea(string name = "Tea", double price = 4) : base(name, price)
        {
        }
        /// <summary>
        /// <br>Reduces the amount of the 'tea bags' by 1.</br>
        /// Adding the ingredients to the cup
        /// <br>call 3 functions from the 'vending machine' class,</br>
        /// that tells the params to reduces the amount by 1.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns>Confirmation message</returns>
        protected override string AddIngredients(VendingMachine machine)
        {
            _teaBags--;
            machine.UseCups();
            machine.UseSuger();
            machine.UseMilk();
            return $"- Adding the teabag\n";
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
            return $"- Stirring the Tea for you\n";
        }
        /// <summary>
        /// Restock the tea Bags for up to 10 doses.
        /// </summary>
        /// <returns>Confirmation message</returns>
        public override string ReStock()
        {
            _teaBags = 10;
            return $"- Restock the tea bags for up to 10 doses";
        }
    }
}
