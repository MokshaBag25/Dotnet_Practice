using InstagramApp;
using System.Net.NetworkInformation;

namespace InstagramApp
{
    public interface IShareable
    {
        void Share();
    }

    public interface IFilterable
    {
        void ApplyFilter(string filter);
    }

    public class Content
    {
        public string UserName { get; set; }
        public int Likes { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($" Content by {UserName} | Likes: {Likes}");
        }
    }

    public class Posts : Content, IShareable, IFilterable
    {
        public void Share()
        {
            Console.WriteLine("We upload the photos.");
        }

        public void ApplyFilter(string filterName)
        {
            Console.WriteLine($"We apply filter for the {filterName}");
        }
    }

    public class Reels : Content, IShareable
    {
        public void Share()
        {
            Console.WriteLine("We upload the reels");
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            Posts posts = new Posts();
            Reels reels = new Reels();

            posts.UserName = "viratkohli";
            posts.Likes = 10;
            posts.GetInfo();
            posts.ApplyFilter("Hight Contrast");
        }
    }
}

