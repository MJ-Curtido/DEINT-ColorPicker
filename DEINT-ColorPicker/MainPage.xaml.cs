using Microsoft.Maui.Graphics;

namespace DEINT_ColorPicker;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();
    }

	private void SliderColor_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		var col = Color.FromRgb((float)sliderRed.Value, (float)sliderGreen.Value, (float)sliderBlue.Value);

		conteiner.BackgroundColor = col;
		colorActual.Text =  col.ToHex();
	}

	private void colorActual_Clicked(object sender, EventArgs e)
	{
		Clipboard.Default.SetTextAsync(colorActual.Text);
	}

	private void colorRandom_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
		sliderRed.Value = random.NextDouble();
		sliderGreen.Value = random.NextDouble();
		sliderBlue.Value = random.NextDouble();
        var col = Color.FromRgb((float)sliderRed.Value, (float)sliderGreen.Value, (float)sliderBlue.Value);

        conteiner.BackgroundColor = col;
        colorActual.Text = col.ToHex();
    }
}

