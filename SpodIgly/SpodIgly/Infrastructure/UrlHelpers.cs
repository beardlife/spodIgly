using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIgly.Infrastructure
{
    public static class UrlHelpers
    {
        public static string GenreIconPath(this UrlHelper helper, string genreIconFilename)
        {
            var genreIconFolder = AppConfig.GenreIconsFolderRelative;
            var path = Path.Combine(genreIconFolder, genreIconFilename);
            var absolutePath = helper.Content(path);

            return absolutePath;
        }

        public static string AlbumCoverPath(this UrlHelper helper, string coverFilename)
        {
            var coverFolder = AppConfig.PhotosFolderRelative;
            var path = Path.Combine(coverFolder, coverFilename);
            var absolutePath = helper.Content(path);

            return absolutePath;
        }
    }
}