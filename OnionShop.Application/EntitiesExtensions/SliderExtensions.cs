using OnionShop.Application.Utils;
using OnionShop.DataLayer.Entities.Site;

namespace OnionShop.Application.EntitiesExtensions
{
    public static class SliderExtensions
    {
        public static string GetSliderImageAddress(this Slider slider)
        {
            return PathExtension.SliderOrigin + slider.ImageName;
        }
    }
}
