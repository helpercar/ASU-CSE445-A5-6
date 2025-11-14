// Malcom Myers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace WebApplication5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WordFilter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WordFilter.svc or WordFilter.svc.cs at the Solution Explorer and start debugging.
    public class WordFilter : IWordFilterer
    {
        // Creating a list of common words
        private static readonly HashSet<string> common_Strings = new HashSet<string>
        {
            "she", "was", "with", "the", "by", "he", "of", "but", "i", "for",
            "we", "on", "this", "they", "in", "an", "is", "not", "to", "that",
            "as", "were", "you", "a", "from", "and", "it", "are", "at", "with"

        };

        public string WordFilterer(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return string.Empty;
            }

            try
            {

                string text = Regex.Replace(word, "<[^>]*>", " ");

                string[] spilt_Words = Regex.Split(text, @"W+");


                List<string> content = new List<string>();
                foreach (string curr in spilt_Words)
                {
                    if (!string.IsNullOrWhiteSpace(curr) && !common_Strings.Contains(curr))
                    {
                        content.Add(curr);
                    }
                }

                return string.Join(" ", content);
            }

            catch (Exception ex)
            {
                return "Error:" + ex.Message;

            }

        }
   
    }
}
