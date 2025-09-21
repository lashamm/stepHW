namespace hwC_Step._11th_les_stuff
{
    internal interface IMediaPlayer
    {
        public uint Volume { get; set; }
        void Play();
        void Pause();
        void Stop();
    }
}
