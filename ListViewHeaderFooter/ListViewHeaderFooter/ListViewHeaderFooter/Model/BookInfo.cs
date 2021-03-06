﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoFitSample 
{
    public class ListViewBookInfo : INotifyPropertyChanged
    {
        #region Fields

        private string bookName;
        private string bookDesc;
        private int bookNumber;
        private ImageSource _authorImage;

        #endregion

        #region Constructor

        public ListViewBookInfo()
        {
            tappedCommand = new Command<object>(OnTapped);
        }

        #endregion

        #region Properties

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public int BookNumber
        {
            get { return bookNumber; }
            set
            {
                bookNumber = value;
                OnPropertyChanged("BookNumber");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public ImageSource AuthorImage
        {
            get { return _authorImage; }
            set
            {
                _authorImage = value;
                OnPropertyChanged("AuthorImage");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region Command

        private Command<object> tappedCommand;

        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set
            {
                tappedCommand = value;
                OnPropertyChanged("TappedCommand");
            }
        }

        private void OnTapped(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Tapped Command", "ListViewItem is tapped", "Close");
        }

        #endregion
    }
}
