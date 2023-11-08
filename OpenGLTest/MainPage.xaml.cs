namespace OpenGLTest
{
    public partial class MainPage : ContentPage
    {
        public OGLWidget OGLWidget { get { return (OGLWidget)oglWidget; } }

        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnLoaded(object sender, EventArgs args)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
            });
        }

        protected void OnUnloaded(object sender, EventArgs args)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
            });
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
