using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Collections.Generic;
namespace LAB_7;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Calculate_Click(object source, RoutedEventArgs e)
    {
        var text = seq.Text.ToLower();
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }
        }

        a.Text = letterCount.ContainsKey('a') ? letterCount['a'].ToString() : "0";
        g.Text = letterCount.ContainsKey('g') ? letterCount['g'].ToString() : "0";
        c.Text = letterCount.ContainsKey('c') ? letterCount['c'].ToString() : "0";
        t.Text = letterCount.ContainsKey('t') ? letterCount['t'].ToString() : "0";
    }
}