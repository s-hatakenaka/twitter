using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class RestAPI
    {
        static void Main(string[] args)
        {
            var tokens = CoreTweet.Tokens.Create(
                "PyAXUvbbYCHLCMY6LVKSbPEE8",
                "J1Krb78maUfvJEXrWgBufMk4wtj4kG3kajuXsUhLpnAvxPxsxz",
                "4067666654-CkfefjSsJwxR1owPsGNpz8jD8SDZlKd3NmbcvNa",
                "DD6kiWb2Pcuw6TibBuPyObK8iKIKjFARZ7gOByAWkTJyx", 4067666654,"adsute1111"
                );
            var parm = new Dictionary<string, object>();
            //取得する直近tweetの数
            parm["count"] = 100;
            // 取得する対象のアカウント
            parm["screen_name"] = "adsute1111";

            var tweets = tokens.Statuses.UserTimeline(parm);
            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0}:{1}", tweet.User.ScreenName, tweet.Text);
            }
        }
    }
}
