namespace Lectia19_3.Canvases
{
    internal class TikTokCanvas : ICanvas
    {
        public void Resize(Photo photo)
        {
            photo.Resolution.Width = 720;
            photo.Resolution.Height = 1280;
        }
    }
}
