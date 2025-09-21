namespace hwC_Step._11th_les_stuff
{
    internal class AudioPlayer : IMediaPlayer
    {
        public uint Volume { get; set; }
        public void Play()
        {
            Console.WriteLine("Audio is playing");
        }
        public void Pause()
        {
            Console.WriteLine("Audio is paused");
        }
        public void Stop()
        {
            Console.WriteLine("Audio is stopped");
        }
    }
    
    }

