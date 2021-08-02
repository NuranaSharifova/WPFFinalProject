﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFFinalProject.Model;
using WPFFinalProject.Model.Command;
using WPFFinalProject.Service;

namespace WPFFinalProject.ViewModel
{
    public  class CinemaModelView : INotifyPropertyChanged
    {
        private Movie selectedMovie;
        private int selectedMovieIndex;
        private IService _fileService;
        public ObservableCollection<Movie> Movies { get; set; }
        public ObservableCollection<Movie> Wishlist { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


        public CinemaModelView(IService fileService)
        {
            _fileService = fileService;
            Movies = new ObservableCollection<Movie>
            {
                new Movie("Harry Potter","Fantasy","This is the tale of Harry Potter (Daniel Radcliffe), an ordinary eleven-year-old boy" +
                " serving as a sort of slave for his aunt and uncle who learns that he is actually a wizard and has been invited to attend" +
                " the Hogwarts School for Witchcraft and Wizardry. Harry is snatched away from his mundane existence by Rubeus Hagrid (Robbie Coltrane), " +
                "the groundskeeper for Hogwarts, and quickly thrown into a world completely foreign to both him and the viewer. "),
                new Movie("Sherlock","Dedective","In this modernized version of the Conan Doyle characters," +
                " using his detective plots, Sherlock Holmes lives in early 21st century London and acts more cocky " +
                "towards Scotland Yard's detective inspector Lestrade because he's actually less confident. Doctor Watson " +
                "is now a fairly young veteran of the Afghan war, less adoring and more active."),
                new Movie("Bruce Almighty","Comedy","Bruce Nolan, a television reporter in Buffalo, N.Y., " +
                "is discontented with almost everything in life despite his popularity and the love of his girlfriend Grace ." +
                " At the end of the worst day of his life, Bruce angrily ridicules and rages against God and God responds. " +
                "God appears in human form and, endowing Bruce with divine powers, challenges Bruce to take on the big job to see if he can do it any better.")

            };
            Wishlist = new ObservableCollection<Movie>();
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        public int SelectedMovieIndex
        {

            get => selectedMovieIndex;
            set => selectedMovieIndex = value;

        }
        public Movie SelectedMovie
        {

            get => selectedMovie;
            set
            {
                selectedMovie = value;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }
        private Command _addCommand;

        public Command AddCommand
        {

            get
            {

                return  (_addCommand = new Command(obj =>
                {
                   
                    Wishlist.Add(selectedMovie);

                    foreach (var item in Wishlist)
                    {
                        MessageBox.Show($"{item}");
                    }
                }));

            }



        }
        public  void ShowWishlist()
        {

            foreach (var item in Wishlist)
            {
                MessageBox.Show($"{item}");
            }
        }
    }

}