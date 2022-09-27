using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Drinks_Vending_Machine
{
    public sealed partial class MainPage : Page
    {
        Manager manager;
        
        public MainPage()
        {
            this.InitializeComponent();
            manager = new Manager(); 
        }

        /// <summary>
        /// The events send the strings to the grid.
        /// Each drink has a button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreparCoffee_Tapped(object sender, TappedRoutedEventArgs e)
        {
            displayTbl.Text = manager.PreparChoosenBeverage("Coffee");
        }
        private void PreparTea_Tapped(object sender, TappedRoutedEventArgs e)
        {
            displayTbl.Text = manager.PreparChoosenBeverage("Tea");
        }
        private void PreparChocolateMilk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            displayTbl.Text = manager.PreparChoosenBeverage("ChocolateMilk");
        }
        private void Exit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        /// <summary>
        /// Event for restock the ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReStockIngredients_Tapped(object sender, TappedRoutedEventArgs e)
        {
            displayTbl.Text = manager.ReStockIngredientChoosen();
        }
    }
}
