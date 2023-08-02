namespace Lectia19_3.Filters
{
    internal class Clarendon : IFilter
    {
        public void Apply(Photo photo)
        {
            photo.Shadows += 30;
            photo.Brightness += 10;
            photo.Whites -= 5;
            photo.Exposure -= 13;
            photo.Contrast += 10;
        }
    }
}
