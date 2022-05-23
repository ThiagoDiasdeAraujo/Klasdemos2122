using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_Quotes
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string text;
        private string author;
        private Quote selectedQuote;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }
        public string Author
        {
            get => author;
            set
            {
                author = value;
                OnPropertyChanged();
            }
        }

        public Quote SelectedQuote
        {
            get => selectedQuote;
            set
            {
                selectedQuote = value;
                ShowQuote(value);
            }
        }

        private void ShowQuote(Quote selectedQuote)
        {
            if (selectedQuote != null)
            {
                Text = selectedQuote.Text;
                Author = selectedQuote.Author;
            }
            else
            {
                Text = "";
                Author = "";
            }
        }

        public ObservableCollection<Quote> Quotes { get; set; }

        public ActionCommand SaveCommand { get; set; }

        public MainViewModel()
        {
            Quotes = new ObservableCollection<Quote>();
            SaveCommand = new ActionCommand(SaveCommandAction);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SaveCommandAction()
        {
            Quote quote = new Quote(Text, Author);
            Text = "";
            Author = "";
            Quotes.Add(quote);
        }

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
