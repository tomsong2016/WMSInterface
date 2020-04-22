using System.Collections.Generic;
using AutoMapper;

namespace Mlily.WMSInterface.Common
{
    public static class MapperHelper
    {
        public static IEnumerable<TDestination> MapToList<TSource, TDestination>(this IEnumerable<TSource> source)
            where TDestination : class
            where TSource : class
        {
            if (source == null) return new List<TDestination>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());
            var mapper = config.CreateMapper();
            return mapper.Map<List<TDestination>>(source);
        }

        public static TDestination MapTo<TDestination, TSource>(this TSource source)
            where TDestination : class
            where TSource : class
        {
            if (source == null) return default(TDestination);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());
            var mapper = config.CreateMapper();
            return mapper.Map<TDestination>(source);
        }
    }
}