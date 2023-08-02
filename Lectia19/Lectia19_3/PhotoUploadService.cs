using Lectia19_3.Canvases;
using Lectia19_3.Filters;

namespace Lectia19_3
{
    internal class PhotoUploadService
    {
        public void Upload(Photo photo, ICanvas canvas, IFilter filter)
        {
            canvas.Resize(photo);

            filter.Apply(photo);

            System.Console.WriteLine(photo.Resolution.Width);
            System.Console.WriteLine(photo.Resolution.Height);
            System.Console.WriteLine(photo.Whites);
            System.Console.WriteLine(photo.Shadows);
            System.Console.WriteLine(photo.Exposure);
            System.Console.WriteLine(photo.Contrast);

            /// .. upload image somewhere
        }
    }
}
