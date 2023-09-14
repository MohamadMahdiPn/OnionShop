using OnionShop.Application.Utils;
using OnionShop.DataLayer.Entities.Site;

namespace OnionShop.Application.EntitiesExtensions
{
    public static class BannerExtension
    {
        public static string GetBannerMainImageAddress(this SiteBanner banner)
        {
            return PathExtension.BannerOrigin + banner.ImageName;
        }
    }
}
