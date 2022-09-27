using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Vending_Machine
{
    internal class ChocolateMilk : Beverages
    {
        /// <summary>
        /// Privet fild for the cocoa pwoder.
        /// </summary>
        private int _cocoaDoses = 10;
        public ChocolateMilk(string name = "ChocolateMilk", double price = 13.5) : base(name, price)
        {
        }
        /// <summary>
        /// <br>Reduces the amount of the 'cocoa doses' by 1.</br>
        /// Adding the ingredients to the cup
        /// <br>call 3 functions from the 'vending machine' class,</br>
        /// that tells the params to reduces the amount by 1.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns>Confirmation message</returns>
        protected override string AddIngredients(VendingMachine machine)
        {
            _cocoaDoses--;
            machine.UseCups();
            machine.UseSuger();
            machine.UseMilk();
            return $"- Adding the chocolateMilk beans\n";
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
            return $"- Stirring the chocolateMilk for you\n";
        }
        /// <summary>
        /// Restock cocoa powder rot up to 10 doses.
        /// </summary>
        /// <returns>Confirmation message</returns>
        public override string ReStock()
        {
            _cocoaDoses = 10;
            return $"- Restock cocoa powder rot up to 10 doses";
        }
    }
}
