using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Calculator;

public partial class MainWindow : Window
{
    public Solver solver;
    string top, bottom = "";
    public MainWindow()
    {
        InitializeComponent();
        solver = new Solver();
        Display();
    }
    void Display()
    {
        TextBox1.Text = top + "\n————-\n" + bottom;
    }
    //operators
    public void AdditionClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("+");
        top += "+";
        Display();
    }
    public void SubtractionClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("-");
        top += "-";
        Display();
    }
    public void MultiplicationClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("*");
        top += "*";
        Display();
    }
    public void DivisionClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("/");
        top += "/";
        Display();
    }
    public void ModuloClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("%");
        top += "%";
        Display();
    }
    //clear
    public void ACClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Clear();
        top = "";
        bottom = "";
        Display();
        //clears the bottom of it too
    }
    //numbers
    public void Button1ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("1");
        top += "1";
        Display();
    }
    public void Button2ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("2");
        top += "2";
        Display();
    }
    public void Button3ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("3");
        top += "3";
        Display();
    }
    public void Button4ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("4");
        top += "4";
        Display();
    }
    public void Button5ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("5");
        top += "5";
        Display();
    }
    public void Button6ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("6");
        top += "6";
        Display();
    }
    public void Button7ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("7");
        top += "7";
        Display();
    }
    public void Button8ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("8");
        top += "8";
        Display();
    }
    public void Button9ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("9");
        top += "9";
        Display();
    }
    public void Button0ClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("0");
        top += "0";
        Display();
    }
    public void ButtonDecimalClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate(".");
        top += ".";
        Display();
    }
    public void PLMClickHandler(object sender, RoutedEventArgs args)
    {
        solver.Accumulate("-");
        top += "-";
        Display();
    }
    public void EqualsClickHandler(object sender, RoutedEventArgs args)
    {
        bottom = solver.Solve().ToString();
        Display();
    }
}
