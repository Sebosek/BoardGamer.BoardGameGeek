using System;
using System.Threading.Tasks;

namespace BoardGamer.BoardGameGeek.BoardGameGeekXmlApi2
{
    public class BoardGameGeekXmlApi2ClientOptions
    {
        public readonly static BoardGameGeekXmlApi2ClientOptions Default = new BoardGameGeekXmlApi2ClientOptions
        {
            Delay = TimeSpan.FromMilliseconds(500),
            MaxRetries = 20,
            ApiTokenFactory = () => throw new NotImplementedException("No API token factory has been configured for the BGG XML API2 client."),
        };
        
        /// <summary>
        /// The base address for the BGG XML API2.
        /// </summary>
        public Uri BaseAddress { get; set; } = new Uri("https://boardgamegeek.com/xmlapi2/");

        /// <summary>
        /// The time to wait before retrying a request.
        /// </summary>
        public TimeSpan Delay { get; set; }

        /// <summary>
        /// The maximum number of times to try a request.
        /// </summary>
        public int MaxRetries { get; set; }

        /// <summary>
        /// BGG API token factory.
        /// </summary>
        public Func<Task<string>> ApiTokenFactory { get; set; }
    }
}
