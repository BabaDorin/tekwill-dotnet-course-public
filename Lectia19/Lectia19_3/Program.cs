using Lectia19_3.Canvases;
using Lectia19_3.Filters;

namespace Lectia19_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var photoUploadService = new PhotoUploadService();

            var photo = new Photo()
            {
                Resolution = new Resolution
                {
                    Height = 720,
                    Width = 1280,
                }
            };

            photoUploadService.Upload(photo, new TikTokCanvas(), new Sierra());
        }
    }
}
