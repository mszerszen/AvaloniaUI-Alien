using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using lekcja7.Models;
using ReactiveUI;

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
            MainCharacters = "Ellen Ripley, Dallas, Ash, Lambert, Kane",
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
            MainCharacters = "Ellen Ripley, Hicks, Newt, Bishop, Vasquez",
            Ship = "USS Sulaco",
            Description = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFact = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },
        new Movie()
        {
            TitleOriginal = "Alien³",
            TitlePolish = "Obcy³",
            ReleaseDate = 1992,
            Director = "David Fincher",
            Screenwriter = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            Time = 114,
            Rating = 6.5,
            MainCharacters = "Ellen Ripley, Dillon, Clemens, Morse, Andrews",
            Ship = "E.E.V. z USS Sulaco (katastrofa)",
            Description = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            FunFact = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },
        new Movie()
        {
            TitleOriginal = "Alien: Resurrection",
            TitlePolish = "Obcy: Przebudzenie",
            ReleaseDate = 1997,
            Director = "Jean-Pierre Jeunet",
            Screenwriter = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            Time = 109,
            Rating = 6.2,
            MainCharacters = "Ellen Ripley (klon), Call, Johner, Christie, Dr. Gediman",
            Ship = "USM Auriga",
            Description = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            FunFact = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },
        new Movie()
        {
            TitleOriginal = "Prometheus",
            TitlePolish = "Prometeusz",
            ReleaseDate = 2012,
            Director = "Ridley Scott",
            Screenwriter = "Jon Spaihts, Damon Lindelof",
            Genre = "Sci-Fi / Thriller",
            Time = 124,
            Rating = 7.0,
            MainCharacters = "Elizabeth Shaw, David, Charlie Holloway, Meredith Vickers",
            Ship = "USCSS Prometheus",
            Description = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            FunFact = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },
        new Movie()
        {
            TitleOriginal = "Alien: Covenant",
            TitlePolish = "Obcy: Przymierze",
            ReleaseDate = 2017,
            Director = "Ridley Scott",
            Screenwriter = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            Time = 122,
            Rating = 6.4,
            MainCharacters = "Daniels, David, Walter, Oram, Tennessee",
            Ship = "USCSS Covenant",
            Description = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            FunFact = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }
    };
    public ObservableCollection<Character> Characters { get; } = new()
    {
        new Character()
        {
            Name = "Ellen Louise Ripley",
            Movies = "Alien (1979), Aliens (1986), Alien³ (1992), Alien: Resurrection (1997)",
            Role = "Oficer porządkowy, później specjalistka ds. bezpieczeństwa",
            Actor = "Sigourney Weaver",
            Race = "Człowiek",
            BirthDate = "2092",
            Function = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Characteristics = "Zdeterminowana, inteligentna, odporna psychicznie. Jej decyzje często ratują załogę kosztem własnego komfortu. Symbol siły i walki człowieka z nieznanym.",
            Fate = "Ginęła w filmie „Alien³”, by uniemożliwić korporacji zdobycie królowej obcych. Później została sklonowana (film „Resurrection”).",
            FunFact = "Sigourney Weaver była nominowana do Oscara za rolę w „Aliens” — to rzadkość w kinie sci-fi."
        },
        new Character()
        {
            Name = "Arthur Koblenz Dallas",
            Movies = "Alien (1979)",
            Role = "Kapitan statku handlowego USCSS Nostromo",
            Actor = "Tom Skerritt",
            Race = "Człowiek",
            BirthDate = "2071",
            Function = "Dowódca misji, odpowiedzialny za decyzje dotyczące lądowania i bezpieczeństwa załogi.",
            Characteristics = "Opanowany, odpowiedzialny, często stawia bezpieczeństwo załogi ponad własne emocje. Zmuszony do podjęcia trudnych decyzji w obliczu kontaktu z obcą formą życia.",
            Fate = "Zginął podczas próby schwytania obcego w kanałach wentylacyjnych Nostromo.",
            FunFact = "W scenariuszu oryginalnie rozważano alternatywne zakończenie, w którym Dallas zostaje odnaleziony żywy, uwięziony w kokonach obcego."
        },
        new Character()
        {
            Name = "Ash",
            Movies = "Alien (1979)",
            Role = "Oficer naukowy Nostromo",
            Actor = "Ian Holm",
            Race = "Android (model Hyperdyne Systems 120-A/2)",
            Function = "Odpowiada za analizę sygnałów i badania naukowe obiektów pozaziemskich.",
            Characteristics = "Zewnętrznie spokojny i profesjonalny, w rzeczywistości kierowany tajnymi rozkazami korporacji.",
            Fate = "Zniszczony przez załogę po ujawnieniu, że jego misją było zachowanie obcego przy życiu.",
            FunFact = "Ash jest pierwszym androidem w uniwersum Alien i początkiem całego wątku sztucznej inteligencji."
        },
        new Character()
        {
            Name = "Bishop",
            Movies = "Alien (1979), Alien³ (1992)",
            Role = "Oficer naukowy, android kolonialnych marines",
            Actor = "Lance Henriksen",
            Race = "Android (model Hyperdyne 341-B)",
            Function = "Zajmuje się systemami analizy danych i wspiera operacje bojowe.",
            Characteristics = "Empatyczny, lojalny, różni się od Asha — ma autentyczne poczucie etyki.",
            Fate = "Ciężko uszkodzony przez królową obcych, później dezaktywowany.",
            FunFact = "Bishop jest jednym z niewielu androidów w kinie, który naprawdę wzbudza zaufanie."
        },
        new Character()
        {
            Name = "Jenette Vasquez",
            Movies = "Aliens (1986)",
            Role = "Strzelec kolonialnych marines",
            Actor = "Jenette Goldstein",
            Race = "Człowiek",
            BirthDate = "2124",
            Function = "Specjalistka od broni ciężkiej i operacji w ciasnych korytarzach kolonii.",
            Characteristics = "Odważna, twarda i zadziorna. Nie boi się śmierci i żartuje nawet w obliczu zagrożenia.",
            Fate = "Poświęca życie, wysadzając korytarz pełen obcych, by uratować innych marines.",
            FunFact = "Postać Vasquez była wzorem dla wielu późniejszych bohaterek gier i filmów sci-fi."
        },
        new Character()
        {
            Name = "Rebecca \"Newt\" Jorden",
            Movies = "Aliens (1986)",
            Role = "Jedyna ocalała z kolonii Hadley’s Hope",
            Actor = "Carrie Henn",
            Race = "Człowiek",
            BirthDate = "2172",
            Function = "Nieformalna towarzyszka Ripley, dziecko, które przetrwało atak ksenomorfów.",
            Characteristics = "Sprytna, cicha, zaskakująco odporna psychicznie mimo wieku.",
            Fate = "Ginęła w katastrofie statku Sulaco (początek „Alien³”).",
            FunFact = "Carrie Henn po tym filmie nigdy więcej nie wystąpiła w żadnym filmie."
        },
        new Character()
        {
            Name = "The Queen Alien",
            Movies = "Aliens (1986), Alien: Resurrection (1997)",
            Role = "Matka i królowa ksenomorfów",
            Actor = "efekty praktyczne i animatronics",
            Race = "Obcy (Ksenomorf Królowa)",
            Function = "Nie dotyczy — centralna postać hierarchii obcych, odpowiedzialna za składanie jaj.",
            Characteristics = "Niezwykle inteligentna, agresywna, pełna instynktu macierzyńskiego.",
            Fate = "Zniszczona przez Ripley w ładowni statku Sulaco, ponownie klonowana w „Resurrection”.",
            FunFact = "Do animacji Królowej Obcych użyto modelu o wysokości ponad 4 metrów."
        },
        new Character()
        {
            Name = "Annalee Call",
            Movies = "Alien: Resurrection (1997)",
            Role = "Członkini załogi statku Betty",
            Actor = "Winona Ryder",
            Race = "Android (model Auton – stworzony przez androidy)",
            BirthDate = "2381",
            Function = "Specjalistka ds. techniki i hakowania systemów wojskowych.",
            Characteristics = "Empatyczna, emocjonalna, wykazuje moralność bardziej ludzką niż większość ludzi.",
            Fate = "Przeżywa i opuszcza Ziemię wraz z klonem Ripley.",
            FunFact = "Call to pierwszy android w serii, który został stworzony przez inne androidy."
        },
        new Character()
        {
            Name = "Ripley 8",
            Movies = "Alien: Resurrection (1997)",
            Role = "Klon Ellen Ripley z DNA królowej obcych",
            Actor = "Sigourney Weaver",
            Race = "Hybryda (Człowiek / Obcy)",
            BirthDate = "2381",
            Function = "Pomaga załodze Betty w walce z obcymi na statku USM Auriga.",
            Characteristics = "Silna fizycznie i emocjonalnie, rozdarta między naturą człowieka i obcego.",
            Fate = "Przeżywa wydarzenia filmu, ale nie ufa już ani ludziom, ani korporacjom.",
            FunFact = "Ma kwaśną krew i zdolności nadludzkie, będąc symbolicznym połączeniem dwóch światów."
        },
        new Character()
        {
            Name = "The Engineer",
            Movies = "Prometheus (2012)",
            Role = "Starożytna istota – stwórca ludzi",
            Actor = "Ian Whyte",
            Race = "Inżynier",
            Function = "Nie jest członkiem załogi – reprezentuje cywilizację twórców, którzy stworzyli życie na Ziemi.",
            Characteristics = "Milczący, majestatyczny, potężny. Symbol boskiej pychy.",
            Fate = "Budzi się z hibernacji i morduje członków misji Prometeusza, po czym ginie.",
            FunFact = "Postać Inżyniera łączy mit o stworzeniu człowieka z początkiem gatunku Obcych."
        },
        new Character()
        {
            Name = "Neomorph",
            Movies = "Alien: Covenant (2017)",
            Role = "Forma pośrednia między stworzeniem Davida a ksenomorfem",
            Actor = "CGI / efekty komputerowe",
            Race = "Obcy (mutant)",
            Function = "Nie dotyczy — stworzenie eksperymentalne Davida, symbol błędu ewolucji.",
            Characteristics = "Nieprzewidywalny, szybki i niestabilny biologicznie.",
            Fate = "Zabity przez załogę Covenant.",
            FunFact = "Neomorphy były inspirowane koncepcją „białego drapieżcy” z natury — połączeniem piękna i grozy."
        },
        new Character()
        {
            Name = "Daniels Branson",
            Movies = "Alien: Covenant (2017)",
            Role = "Oficer kolonizacyjny",
            Actor = "Katherine Waterston",
            Race = "Człowiek",
            BirthDate = "2100",
            Function = "Projektantka kolonii, kieruje działaniami terraformacyjnymi.",
            Characteristics = "Pragmatyczna, ale odważna i zdeterminowana.",
            Fate = "Zostaje uśpiona w kapsule przez Davida, który podszywa się pod androida Waltera.",
            FunFact = "Scott chciał, by Daniels była symbolicznym „nowym początkiem” linii bohaterek."
        }
    };
    
    private Movie? _selectedMovie;
    public Movie? SelectedMovie
    {
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }
}