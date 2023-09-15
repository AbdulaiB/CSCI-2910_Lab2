using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2910_Lab1
{
    internal class VideoGames : IComparable<VideoGames>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public decimal NA_Sales { get; set; }
        public decimal EU_Sales { get; set; }
        public decimal JP_Sales { get; set; }
        public decimal Other_Sales { get; set; }
        public decimal Global_Sales { get; set; }


        public VideoGames(string name, string platform, int year, string genre, string publisher, decimal nA_Sales, decimal eU_Sales, decimal jP_Sales, decimal other_Sales, decimal global_Sales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = nA_Sales;
            EU_Sales = eU_Sales;
            JP_Sales = jP_Sales;
            Other_Sales = other_Sales;
            Global_Sales = global_Sales;
        }

        public int CompareTo(VideoGames? other)
        {
            int result = Name.CompareTo(other.Name);

            return result;
        }

        public static bool operator > (VideoGames left, VideoGames right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator < (VideoGames left, VideoGames right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >= (VideoGames left, VideoGames right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator <=(VideoGames left, VideoGames right)
        {
            return left.CompareTo(right) <= 0;
        }

        public override string ToString()
        {
            string msg = $"Name: {Name}\nPlatform: {Platform}\nYear: {Year}\nGenre: {Genre}\nPublisher: {Publisher}\nNa_Sales: {NA_Sales}\nEU_Sales: {EU_Sales}\nJp_Sales: {JP_Sales}\nOther_Sales: {Other_Sales}\nGlobal_Sales: {Global_Sales}\n";
            return msg;
        }
    }
}
