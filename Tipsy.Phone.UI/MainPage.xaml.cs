using System;
using System.Linq;
using Tipsy.CalculatorProviders;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Tipsy.Enums;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Tipsy.Phone.UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public Tipsy.Calculator BillCalculator { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

            UpdateTipScreen();
        }

        private void UpdateTipScreen()
        {
            try
            {
                var ppl = float.Parse(NumPeopleSlider.Value.ToString());
                var bill = float.Parse(BillTotalTextBox.Text.ToString());
                var tip = float.Parse(TipSlider.Value.ToString().Replace("%",""));

                if (RoundingSwitch.IsOn)
                {
                    BillCalculator = new Calculator(ppl, bill, TipType.PercentageRoundUp, tip);
                }
                else {
                    BillCalculator = new Calculator(ppl, bill, TipType.PercentageExact, tip);
                }

                //BillCalculator = new Calculator(ppl, bill, TipType.PercentageExact, tip);
                BillAmountTextLabel.Text = "€ " + BillCalculator.PrintTip();
            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void NumPeopleSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            NumPeopleTextLabel.Text = e.NewValue.ToString();
            UpdateTipScreen();
        }

        private void TipSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            TipTextLabel.Text = e.NewValue.ToString() + "%";
            UpdateTipScreen();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        private void TextBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BillTotalTextBox.SelectAll();
        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void RoundingSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            UpdateTipScreen();
        }
    }
}
