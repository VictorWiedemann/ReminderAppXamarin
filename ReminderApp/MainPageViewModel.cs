using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

//course said to add .ViewModels here, I do not think that is mandatory, will investigate.
//all things below need to be public for the XAML to see them
namespace ReminderApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            AllNotes = new ObservableCollection<string>();
            
            EraseCommand = new Command(() => 
            {
                TheNote = string.Empty;
            });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);

                TheNote = string.Empty;
            });
        }

        public ObservableCollection<string> AllNotes { get; set; }

        //required because of the INotifyPropertyChanged flag above in the public class.
        public event PropertyChangedEventHandler PropertyChanged;

        //creating the editable string from user input
        string theNote;

        public string TheNote 
        {
            //TODO: this is functionality that I do not fully understand. Will have to do the C# course to get more info.
            get => theNote;
            set 
            {
                //I assume value is a special keyword?
                theNote = value;

                //TODO: don't like using var personally, will see what the variable type is later.
                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);

            }
        }

        
        public Command SaveCommand  { get; }

        public Command EraseCommand { get; }

    }
}
