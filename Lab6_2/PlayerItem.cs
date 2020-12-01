using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Lab6_2
{
    class PlayerItem : IMedia
    {
        public List<string> items { get; private set; }        //public Mp3 mp3;        //private MKV mkv;        //private WAV wav;        
        public void Search()        
        {           
            items = new List<string>();  
            foreach (var i in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "media"), "*.mp3"))        
            {            
                items.Add(i); 
            }
            foreach (var i in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "media"), "*.wav"))     
            {   
                items.Add(i);            
            }
            foreach (var i in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "media"), "*.mkv"))      
            {             
                items.Add(i);     
            }         
            for(int i = 0; i < items.Count; i++)     
            {               
                Console.WriteLine(i + " " + Path.GetFileName(items[i])) ;          
            }  
        }        public Mp3 Choice(int num)        //
        {        
            switch (Path.GetExtension(items[num]))        //    
        {                case ".mp3":        //   
        {                    mp3 = new Mp3(items[num]);        
                        return mp3;                            
                    }        
                case ".mkv":               
                    {         
                        mkv = new MKV(items[num]);  
                        
                        return mp3;        
                    }               case ".wav":       
                    {                 wav = new WAV(items[num]);        
                        return mp3;        
                    }         
                default:       
                    return null;        
            }        
        }                   
        }
}
