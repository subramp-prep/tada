using System;
using System.Collections.Generic;

namespace Misc
{
    public class Codec
    {
        IDictionary<string, string> _longToShort;
        IDictionary<string, string> _shortToLong;

        public Codec()
        {
            _longToShort = new Dictionary<string, string>();
            _shortToLong = new Dictionary<string, string>();
        }
        
        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string encodedURL = string.Empty;
            if (!_longToShort.TryGetValue(longUrl, out encodedURL))
            {
                encodedURL = string.Format("http://tinyurl.com/{0}", longUrl.GetHashCode());

                _longToShort[longUrl] = encodedURL;
                _shortToLong[encodedURL] = longUrl;
            }

            return encodedURL;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            string longURL = string.Empty;

            if (!_shortToLong.TryGetValue(shortUrl, out longURL))
            {
                return null;
            }

            return longURL;
        }
    }
}
