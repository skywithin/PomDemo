namespace PomDemo.Models;

public static class CitiesRepository
{
    private static List<string> cities =
        new()
        {
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
        };

    public static IEnumerable<string> GetCities() => cities;
}
