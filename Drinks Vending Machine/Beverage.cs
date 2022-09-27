using System.Text;

namespace Drinks_Vending_Machine
{
    abstract class Beverages
    {
        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Name { get; protected set; }

        /// <summary>
        /// Constractor that requires:
        /// string 'Name', double 'price'
        /// </summary>
        /// <param Name="name"></param>
        /// <param Name="price"></param>
        public Beverages(string name, double price)
        {
            this.Name = name;
            _price = price;
        }

        /// <summary>
        /// For every drink, we oblige his 
        /// class to refer to these 3 functions:
        /// adding ingredients, adding hot water, mixing.
        /// i use in the string builder here
        /// Avoid creating more unnecessary space in the stack.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns><see cref="string"/></returns>
        public string prepare(VendingMachine machine)
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine(AddIngredients(machine));
            strBuild.AppendLine(AddHotWater());
            strBuild.AppendLine(Stirring());
            return strBuild.ToString();
        }
        /// <summary>
        /// To oblige the classes that inherit
        /// from here, to create a function that does
        /// the abstract method.
        /// The function has a parameter to be able to get 
        /// few functions from the vending machine class.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns></returns>
        protected abstract string AddIngredients(VendingMachine machine);
        /// <summary>
        /// To oblige the classes that inherit
        /// from here, to create a function that does
        /// the abstract method.
        /// </summary>
        /// <returns></returns>
        protected abstract string AddHotWater();
        /// <summary>
        /// To oblige the classes that inherit
        /// from here, to create a function that does
        /// the abstract method.
        /// </summary>
        /// <returns></returns>
        protected abstract string Stirring();

        /// <summary>
        /// Return the name and the price of the beverage.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Name} - {Price:c} ";
        }

        /// <summary>
        /// Checks if the obj that given in the parameter is
        /// from the same kind and has the same name, or null.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Equals(object obj)
        {
            Beverages beverage = obj as Beverages;
            if (beverage == null)
                return false;
            return beverage.Name == Name;
        }
        /// <summary>
        /// Mandatory func to restock the ingredient in all beverages.  
        /// </summary>
        /// <returns></returns>
        public abstract string ReStock();
    }
}



