using System;
using System.Text;

namespace CodingDecodingDLL
{

    //video de apoio para a criação e referenciação da Class Library_https://www.youtube.com/watch?v=jtZDub6xzW4
    
    public class CodingDecoding
    {

            public static string Base64Encode(string text)
            {

                return Convert.ToBase64String(Encoding.UTF8.GetBytes(text.ToString()));
            }

            public static string Base64Decode(string text)
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(text.ToString()));
            }
        
    }
}
