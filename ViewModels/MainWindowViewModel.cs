using System.Collections.ObjectModel;
using lekcja7.Models;

namespace lekcja7.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Movie> Movies { get; } = new()
    {
        new Movie()
        {
            TitleOriginal = "Alien",
            TitlePolish = "Obcy - ósmy pasażer Nostromo",
            Director = "Ridley Scott",
            Screenwriter = "Dan O’Bannon",
            Genre = "Sci-Fi / Horror",
            Time = 117,
            Rating = 8.5,
            MainCharacters = ["Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane"],
            Ship = "USCSS Nostromo"
        }

    };
}