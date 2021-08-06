namespace BlazorApp.Data
{
    public interface IGenreCounter
    {
        int FantasyCounter { get; set; }
        int SciFiCounter { get; set; }

        void IncrementCounter(string genre, bool approved);
    }
}