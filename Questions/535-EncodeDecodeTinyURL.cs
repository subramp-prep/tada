using System;
using System.Collections.Generic;

namespace questions
{
    // URL: https://leetcode.com/problems/encode-and-decode-tinyurl/description/
    //TinyURL is a URL shortening service where you enter a URL such as 
    //https://leetcode.com/problems/design-tinyurl and it returns a 
    //short URL such as http://tinyurl.com/4e9iAk.

    //Design the encode and decode methods for the TinyURL service.
    //There is no restriction on how your encode/decode algorithm should work.
    //You just need to ensure that a URL can be encoded to a tiny URL and the 
    //tiny URL can be decoded to the original URL.
    public class Codec
    {
        Dictionary<string, string> _urls = new Dictionary<string, string>();

        public string encode(string url)
        {
            string encodedURL = string.Empty;
            if (!_urls.TryGetValue(url, out encodedURL))
            {
                encodedURL = string.Format("http://tinyurl.com/{0}", url.GetHashCode());
                _urls[encodedURL] = url;
            }

            return encodedURL;
        }

        public string decode(string url)
        {
            string decodedURL = string.Empty;

            if (_urls.TryGetValue(url, out decodedURL))
                return decodedURL;

            return "";
        }
    }
}
