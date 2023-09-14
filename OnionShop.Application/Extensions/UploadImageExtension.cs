using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using OnionShop.Application.Utils;

namespace OnionShop.Application.Extensions
{
    public static class UploadImageExtension
    {
        public static bool AddImageToServer(this string image, string fileName, string orginalPath, int? width, int? height, string thumbPath = null, string deletefileName = null)
        {
            return false;
        }

        public static void DeleteImage(this string imageName, string OriginPath, string ThumbPath)
        {
           
        }
    }
}
