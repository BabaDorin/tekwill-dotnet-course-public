namespace Lectia19_3.Canvases
{
    internal class InstagramCanvas : ICanvas
    {
        public void Resize(Photo photo)
        {
            photo.Resolution.Height = photo.Resolution.Width = 600;
        }
    }
}
