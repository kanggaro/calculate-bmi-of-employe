using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class BMICalculatorPage : ContentPage
{
    public BMICalculatorPage(BMICalculatorPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        //this.BindingContext = new BMICalculatorPageViewModel();
    }
}