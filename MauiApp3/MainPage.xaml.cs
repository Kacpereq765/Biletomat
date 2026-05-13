namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        zonePicker.SelectedIndex = 0;
    }

    private void ticketsStepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int liczbaBiletow = (int)e.NewValue;

        ticketsLabel.Text = $"Liczba biletów: {liczbaBiletow}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (zonePicker.SelectedIndex == -1)
        {
            resultLabel.Text = "Wybierz strefę.";
            return;
        }

        double cenaJednostkowa = 0;

        if (zonePicker.SelectedItem.ToString() == "Miejska")
        {
            cenaJednostkowa = 4.80;
        }
        else if (zonePicker.SelectedItem.ToString() == "Podmiejska")
        {
            cenaJednostkowa = 7.20;
        }

        if (discountSwitch.IsToggled)
        {
            cenaJednostkowa *= 0.5;
        }

        int liczbaBiletow = (int)ticketsStepper.Value;

        double wynik = cenaJednostkowa * liczbaBiletow;

        priceLabel.Text = $"Do zapłaty: {wynik:F2} zł";

        resultLabel.Text = "Cena została obliczona.";
    }
}