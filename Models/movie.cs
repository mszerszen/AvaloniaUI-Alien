using Avalonia.Controls.Chrome;

namespace lekcja7.Models;

public record Movie(
    string TitleOriginal,
    string TitlePolish,
    int ReleaseDate,
    string Director,
    string Screenwriter,
    string Genre,
    int Time,
    float Rating,
    string[] MainCharacters,
    string Ship
);