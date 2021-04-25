using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace App3
{
    public class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>
        {
            new Book { Title = "one", Pages = 100 },
            new Book { Title = "two", Pages = 300 },
            new Book { Title = "three", Pages = 540 },
            new Book { Title = "four", Pages = 140 },
            new Book { Title = "five", Pages = 160 },
            new Book { Title = "six", Pages = 120 },
            new Book { Title = "seven", Pages = 760 },
        };
        public string SampleText { get; set; } = "This is the text. And I'll show you how to change DataContext if you need";
        private int counter;

        public int Counter
        {
            get => counter;
            set => SetProperty(ref counter, value);
        }
        public MainPageViewModel()
        {
            IncrementCounter();
        }
        private async void IncrementCounter()
        {
            while (true)
            {
                await Task.Delay(1000);
                Counter++;
            }
        }
    }
}
