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
        var count = 0;
        result.Text = "Result: ";
        for (int i = 0; i < text.Length; i=i+4)
        {
            if (i + 4 <= text.Length)
            {
                string substring = text.Substring(i, 4);
                result.Text += substring + ", ";
                count++;
            }
            else { 
                result.Text += text.Substring(i, text.Length - i) + ", ";
            }
        }
        resultValue.Text = "Count: " + count.ToString();
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

        a.Text = letterCount.ContainsKey('a') ? "A: " + letterCount['a'].ToString() : "A: 0";
        g.Text = letterCount.ContainsKey('g') ? "G: " + letterCount['g'].ToString() : "G: 0";
        c.Text = letterCount.ContainsKey('c') ? "C:" + letterCount['c'].ToString() : "C: 0";
        t.Text = letterCount.ContainsKey('t') ? "T: " + letterCount['t'].ToString() : "T: 0";
    }
}