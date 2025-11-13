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
            ReleaseDate = 1979,
            Director = "Ridley Scott",
            Screenwriter = "Dan O’Bannon",
            Genre = "Sci-Fi / Horror",
            Time = 117,
            Rating = 8.5,
            MainCharacters = ["Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane"],
            Ship = "USCSS Nostromo",
            Description = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety.Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            FunFact = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },
        
        new Movie()
        {
            TitleOriginal = "Aliens",
            TitlePolish = "Obcy – decydujące starcie",
            ReleaseDate = 1986,
            Director = "James Cameron",
            Screenwriter = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Akcja / Horror",
            Time = 137,
            Rating = 8.4,
            MainCharacters = ["Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez"],
            Ship = "USS Sulaco",
            Description = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFact = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        }

    };
}