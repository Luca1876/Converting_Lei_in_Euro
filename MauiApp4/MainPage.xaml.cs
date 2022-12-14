using System;
using System.Linq.Expressions;
using System.Numerics;

namespace MauiApp4;

public partial class MainPage : ContentPage
{
    //string s5 = entry.Placeholder;
    //private bool Button = false;
    public MainPage()
    {
        InitializeComponent();
    }
  
    string Number(string text)
    {
        try
        {
            double number = double.Parse(text);
            number = number / 4.92;
            number = Math.Round(number,2);
            NewValue.Text = number.ToString();
            if (number < 0)
                NewValue.Text = "Nu se poate";
            Console.WriteLine(text, number);
        }
        catch (FormatException)
        {
            NewValue.Text = "Nu se poate";

        }

        catch (OverflowException)
        {
            NewValue.Text = "Nu se poate";
        }
        return NewValue.Text;

    }

    


    void OnCounterClicked(object sender, EventArgs e)
    {
        string element;
        element = Number(entry.Text);







        /*if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";*/
        SemanticScreenReader.Announce(element);
        
    }
    /*

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
	8*/
}
