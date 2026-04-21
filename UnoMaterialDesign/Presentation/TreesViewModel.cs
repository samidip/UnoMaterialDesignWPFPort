using System.Collections.ObjectModel;

namespace UnoMaterialDesign.Presentation;

public partial class TreesViewModel : ObservableObject
{
    public TreesViewModel()
    {
        MovieCategories =
        [
            new MovieCategory("Action",
            [
                new Movie("Predator", "John McTiernan"),
                new Movie("Alien", "Ridley Scott"),
                new Movie("Prometheus", "Ridley Scott"),
            ]),
            new MovieCategory("Comedy",
            [
                new Movie("EuroTrip", "Jeff Schaffer"),
                new Movie("Superbad", "Greg Mottola"),
            ]),
            new MovieCategory("Sci-Fi",
            [
                new Movie("Interstellar", "Christopher Nolan"),
                new Movie("Arrival", "Denis Villeneuve"),
            ]),
        ];

        Planets =
        [
            new PlanetInfo("Mercury", 0.42, 1.40, 44.29),
            new PlanetInfo("Venus", 0.73, 1.69, 34.82),
            new PlanetInfo("Earth", 0.99, 0.00, 30.16),
            new PlanetInfo("Mars", 1.59, 1.55, 23.12),
            new PlanetInfo("Jupiter", 5.43, 5.29, 12.51),
            new PlanetInfo("Saturn", 10.07, 10.69, 9.14),
            new PlanetInfo("Uranus", 19.90, 20.37, 6.55),
            new PlanetInfo("Neptune", 29.94, 30.88, 5.45),
        ];
    }

    public ObservableCollection<MovieCategory> MovieCategories { get; }
    public List<PlanetInfo> Planets { get; }

    [RelayCommand]
    private void AddMovie()
    {
        if (MovieCategories.Count > 0)
        {
            var random = new Random();
            var category = MovieCategories[random.Next(MovieCategories.Count)];
            category.Movies.Add(new Movie($"Movie {random.Next(100, 999)}", "New Director"));
        }
    }

    [RelayCommand]
    private void AddCategory()
    {
        var random = new Random();
        MovieCategories.Add(new MovieCategory($"Genre {random.Next(10, 99)}", []));
    }
}

public record Movie(string Name, string Director);

public record PlanetInfo(string Name, double DistanceFromSun, double DistanceFromEarth, double Velocity);

public class MovieCategory
{
    public MovieCategory(string name, List<Movie> movies)
    {
        Name = name;
        Movies = new ObservableCollection<Movie>(movies);
    }

    public string Name { get; }
    public ObservableCollection<Movie> Movies { get; }
}
