namespace BEMaterial.Pages._Examples.Spotify.Demo.Models
{
    public enum ImageType { Album, Person };

    public class Image
    {
        public ImageType Type { get; set; } = ImageType.Album;
        public string ImageUrl { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
