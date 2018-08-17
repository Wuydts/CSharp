using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("This is a post.", true, "Chris Wuydts");

            Console.WriteLine(post1.ToString());

            ImagePost imgpost1 = new ImagePost("Check out my new shoes", "Christopher Wuydts", "http://images.com/shoes", true);
            Console.WriteLine(imgpost1.ToString());

            VideoPost vidpost1 = new VideoPost("Epic/Win/Fail", "Christopher Wuydts", "https://video.com/epicwinfail",
                true, 10);
            Console.WriteLine(vidpost1.ToString());

            vidpost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            vidpost1.Stop();



        }
    }
}
