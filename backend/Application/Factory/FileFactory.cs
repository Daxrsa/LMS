using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Factory
{
    public class FileFactory
    {
        private static Dictionary<string, Media> FilesDictionary = new Dictionary<string, Media>()
        {
            {"application/pdf", new PDF()},
            {"application/msword", new Word()}
        };

        public static Media CorrectFile(string ContentType)
        {
            
            return FilesDictionary[ContentType];
        //     if (ContentType.Equals("application/pdf"))
        //     {
        //          return new PDF();
        //     }

        //         if (ContentType.Equals("application/msword"))
        //     {
        //          return new Word();
        //     }
        // return null;
        }
       
    }
}