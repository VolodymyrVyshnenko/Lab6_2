using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    interface IMedia
    {
        public void Play()
        {
            Console.WriteLine("play");
        }

        public void Pause()
        {

        }

        public void Stop()
        {

        }
    }
}