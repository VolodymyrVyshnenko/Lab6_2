using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    class MKV : IPlayable
    {
        public MKV(string path)
        {

        }

        public void Play()
        {
            Console.WriteLine("Work");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}