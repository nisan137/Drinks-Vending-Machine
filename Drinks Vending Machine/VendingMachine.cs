using System;
using System.Collections.Generic;
using System.Text;
using Windows.System;

namespace Drinks_Vending_Machine
{
    class VendingMachine
    {
        private List<Beverages> _beverageList;
        private int _cups = 10;
        private int _sugarDoses = 10;
        private int _milkDoses = 10;
        public List<Beverages> BeverageList
        {
            get { return _beverageList; }
        }
        public VendingMachine()
        {
            _beverageList = new List<Beverages>();
        }

        /// <summary>
        /// Checks if the beverage is not null,
        /// if its not, add him to the list.
        /// </summary>
        /// <param Name="bever"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddBeverage(Beverages bever)
        {
            if (bever == null)
                throw new ArgumentNullException($"beverage: {bever} is null");
            else
                _beverageList.Add(bever);
        }

        /// <summary>
        /// Remove beverage from the list.
        /// </summary>
        /// <param name="bever"></param>
        public void RemoveBeverage(string name)
        {
            _beverageList.Remove(this[name]);
        }

        /// <summary>
        /// I created that function to be able 
        /// use the cups in the beverages classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Confirmation message</returns>
        /// <exception cref="IngredientsOutOfStockException"></exception>
        public string UseCups(int amount = 1)
        {
            if (_cups - amount <= 0)
                throw new IngredientsOutOfStockException("Sorry, \nOut of stuck\nPlease restuck the Ingredients");

            _cups -= amount;
            return $"Use {amount} cup";
        }

        /// <summary>
        /// I created that function to be able 
        /// use the suger in the beverages classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Confirmation message</returns>
        /// <exception cref="IngredientsOutOfStockException"></exception>
        public string UseSuger(int amount = 1)
        {
            if (_sugarDoses - amount <= 0)
                throw new IngredientsOutOfStockException("Sorry, \nOut of stuck\nPlease restuck the Ingredients");

            _sugarDoses -= amount;
            return $"Use {amount} sugar";
        }

        /// <summary>
        /// I created that function to be able 
        /// use the milk in the beverages classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Confirmation message</returns>
        /// <exception cref="IngredientsOutOfStockException"></exception>
        public string UseMilk(int amount = 1)
        {
            if (_milkDoses - amount <= 0)
                throw new IngredientsOutOfStockException("Sorry, \nOut of stuck\nPlease restuck the Ingredients");

            _milkDoses -= amount;
            return $"Use {amount} milk";
        }

        /// <summary>
        /// The func checks<br></br>
        /// if the name of the list member
        /// is the same as the parameter name<br></br>
        /// it will activate the 'prepare' func of the
        /// relevant beverage.<br></br>
        /// </summary>
        /// <param name="name">The beverage name</param>
        /// <returns>Confirmation message</returns>
        public string PrepareBeverge(string name)
        {
            return this[name].prepare(this) + this[name].ToString();
        }

        /// <summary>
        /// Indexer that find the index of the list by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Beverages this[string name]
        {
            get
            {
                if (String.IsNullOrEmpty(name))   //if (name != null && name != "")
                    throw new ArgumentNullException($"name: {name} is null or empty");

                for (int i = 0; i < BeverageList.Count; i++)
                {
                    if (BeverageList[i].Name.Equals(name))
                        return BeverageList[i];
                }
                throw new ArgumentException("There is no such a beverage");
            }
        }

        /// <summary>
        /// Restock all ingredient to 10 doses
        /// </summary>
        /// <returns>Confirmation message</returns>
        public string ReStockIngredient()
        {
            _cups = _milkDoses = _sugarDoses = 10;
            StringBuilder sBuild = new StringBuilder();
            foreach (Beverages item in _beverageList)
            {
                sBuild.AppendLine(item.ReStock());
            }
            return sBuild.ToString() + 
                $"- Restock cups to 10 doses\n" +
                $"- Restock milk to 10 doses\n" +
                $"- Restock sugar to 10 doses\n\n" +
                $"- All ingredients restock to 10 doses";
        }
    }
}