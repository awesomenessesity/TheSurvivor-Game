using System.Media;

namespace TheSurvivor
{
    public static class Music
    {
        static private bool isPlaying = true;
        static private SoundPlayer spBackground = new SoundPlayer("backsounds.wav");
        static private SoundPlayer spend = new SoundPlayer("end.wav");
        static private SoundPlayer splevel1 = new SoundPlayer("one.wav");
        static private SoundPlayer splevel2 = new SoundPlayer("two.wav");
        static private SoundPlayer splevel3 = new SoundPlayer("three.wav");
        static private SoundPlayer splevel4 = new SoundPlayer("four.wav");

        public static void PlayLoop()
        {
            try
            {
                spBackground.PlayLooping();
            }
            catch { }
        }

        public static void Stop()
        {
            try
            {
                spBackground.Stop();
                splevel1.Stop();
                splevel2.Stop();
                splevel3.Stop();
                splevel4.Stop();
                spend.Stop();
            }
            catch { }
        }

        public static void Playlevel1()
        { 
            try
            {
               splevel1.PlayLooping();
            }
            catch { }
        }
        
        public static void Playlevel2()
        {
            try
            {
                splevel2.PlayLooping();
            }
            catch { }
        }
      
        public static void Playlevel3()
        {
            try
            {
                splevel3.PlayLooping();
            }
            catch { }
        }
       
        public static void Playlevel4()
        {
            try
            {
                splevel4.PlayLooping();
            }
            catch { }
        }

        public static void Playend()
        {
            try
            {
                spend.PlayLooping();
            }
            catch { }
        }

        public static bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }
    }
}