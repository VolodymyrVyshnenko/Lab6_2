using System;
using System.IO;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerItem player = new PlayerItem();
            player.Search();
            int i = Int32.Parse(Console.ReadLine());
            var m = player.items[i];
            switch (Path.GetExtension(m))
            {
                case ".mp3":
                    {
                        Mp3 mp3 = new Mp3(m);
                        while (true)
                        {
                            Console.WriteLine("1)Record 2)Stop 3)Pause");
                            int n = Int32.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:
                                    {
                                        mp3.Record();
                                        break;
                                    }
                                case 2:
                                    {
                                        mp3.Stop();
                                        break;

                                    }
                                case 3:
                                    {
                                        mp3.Pause();
                                        break;
                                    }
                            }
                        }

                    }

                case ".mkv":
                    {
                        MKV mkv = new MKV(m);
                        while (true)
                        {
                            Console.WriteLine("1)Play 2)Stop 3)Pause");
                            int n = Int32.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:
                                    {
                                        mkv.Play();
                                        break;
                                    }
                                case 2:
                                    {
                                        mkv.Stop();
                                        break;

                                    }
                                case 3:
                                    {
                                        mkv.Pause();
                                        break;
                                    }
                            }
                        }
                    }
                case ".wav":
                    {
                        WAV wav = new WAV(m);
                        Console.WriteLine("0)Play 1)Record 2)Stop 3)Pause");
                        while (true)
                        {
                            int n = Int32.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 0:
                                    {
                                        wav.Play();
                                        break;
                                    }
                                case 1:
                                    {
                                        wav.Record();
                                        break;
                                    }
                                case 2:
                                    {
                                        wav.Stop();
                                        break;

                                    }
                                case 3:
                                    {
                                        wav.Pause();
                                        break;
                                    }
                            }
                        }
                    }


            }
        }


    }

}
