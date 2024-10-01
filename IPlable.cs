using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal interface IPlable
    {
        void Play();
    }

    class VideoPlayer:IPlable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video");
        }

    }

    class MusicPlayer:IPlable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
                VideoPlayer p = new VideoPlayer();
                p.Play();
                MusicPlayer m=new MusicPlayer();
                m.Play();

                Console.Read();
        }
    }
}
