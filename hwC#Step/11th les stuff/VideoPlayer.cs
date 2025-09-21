
namespace hwC_Step._11th_les_stuff
{
    internal class VideoPlayer : IMediaPlayer
    {
        public uint Volume { get; set; }
        public void Play()
        {
            Console.WriteLine("Video is playing");
        }
        public void Pause()
        {
            Console.WriteLine("Video is paused");
        }
        public void Stop()
        {
            Console.WriteLine("Video is stopped");
        }
    }
    {
    }
}
