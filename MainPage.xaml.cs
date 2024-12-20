namespace JapAnakUjak_Finaltest1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Get the current slider value
            double sliderValue = e.NewValue;

            // Update the value label to show the current slider value
            valueLabel.Text = sliderValue.ToString("F0"); // "F0" formats the number without decimals.

            // Update the result label text and color based on the value
            if (sliderValue <= 39)
            {
                resultLabel.Text = "Failed";
                resultLabel.TextColor = Colors.Red;
            }
            else if (sliderValue <= 79)
            {
                resultLabel.Text = "Passed";
                resultLabel.TextColor = Colors.Black;
            }
            else
            {
                resultLabel.Text = "Excellent";
                resultLabel.TextColor = Colors.Green;
            }
        }
    }
}