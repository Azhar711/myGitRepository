using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using AutoMapper;
using AutoMapper.Internal;

namespace ARTS.SKL.Utilities
{
    public static class CommonUtilities
    {
        private static IMapper mapper;

        public static void AddMapDTOProperties<TSource, TDestination>(TSource source, TDestination destination)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TSource, TDestination>());
            mapper = Mapper.Instance;
        }

        public static void CreateMap<TSource, TDestination>(TSource source, TDestination destination)
        {
            Mapper.Initialize(cfg => { cfg.CreateMap<TSource, TDestination>(); });
        }

        public static TDestination MapProperties<TSource, TDestination>(TSource source, TDestination destination)
        {
            //CreateMap(typeof(TSource),typeof(TDestination));
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination MapDestination<TSource, TDestination>(TSource source, TDestination destination)
        {
            Mapper.Initialize(cfg => { cfg.CreateMap<TSource, TDestination>(); });
            return Mapper.Map<TDestination>(source);
        }

        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static T ParseXML<T>(this string @this) where T : class
        {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        public static string SafeSubstring(this string text, int start, int length)
        {
            return text.Length <= start ? string.Empty
                : text.Length - start <= length ? text.Substring(start)
                : text.Substring(start, length);
        }

       

        /// <summary>
        /// Creates the data table.
        /// </summary>
        /// <returns>DataTable</returns>
        private static System.Data.DataTable CreateDataTable()
        {
            var dt = new System.Data.DataTable();
            for (int i = 0; i < 10; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            for (int i = 0; i < 10; i++)
            {
                var dr = dt.NewRow();
                foreach (var dc in dt.Columns)
                {
                    dr[dc.ToString()] = i;
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
