namespace Lectia19_3.Filters
{
    internal class Sierra : IFilter
    {
        public void Apply(Photo photo)
        {
            photo.Shadows += 40;
            photo.Brightness += 210;
            photo.Whites -= 5;
            photo.Exposure -= 11;
            photo.Contrast += 10;
        }
    }
}
