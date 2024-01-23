using Windows.Media.Core;

namespace MediaPlayerSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            URI = new Uri("ms-appx:///MediaPlayerSample/Assets/videos/CookingVideo.mp4");
            CompleteURI = URI.AbsolutePath;
            
            VideoSource = MediaSource.CreateFromUri(URI);
        }

        private Uri URI { get; set; }
        private string CompleteURI { get; set; }

        public MediaSource VideoSource { get; set; }
    }
}
