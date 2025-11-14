using System.Linq;
using Avalonia.Controls.Chrome;

namespace lekcja7.Models;

public class Movie
{
    public string TitleOriginal { get; set; } = "";
    public string TitlePolish { get; set; } = "";
    public int ReleaseDate { get; set; } = 0;
    public string Director { get; set; } = "";
    public string Screenwriter { get; set; } = "";
    public string Genre { get; set; } = "";
    public int Time { get; set; } = 0;
    public double Rating { get; set; } = 0;
    public string MainCharacters { get; set; } = "";
    public string Ship { get; set; } = "";
    public string Description { get; set; } = "";
    public string FunFact { get; set; } = "";
};