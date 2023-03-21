using MVVMDemo.Views;

namespace MVVMDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(BMICalculatorPage), typeof(BMICalculatorPage));
    }
}
