namespace Felgi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private static string[] felgi = { "f0.jpg", "f1.jpg", "f2.jpg", "f3.jpg", "f4.jpg", "f5.jpg", "f6.jpg", "f7.jpg", "f8.jpg", "f9.jpg" };

        int count = 0;

        /****************************************************************************************************************************************************\
            Nazwa funkcji: btnPoprzedni
            Parametry wejściowe: brak
            wartość zwracana: brak
            informacje: funkcja po kliknięciu przycisku zmienia zdjęcię z tablicy o -1 oraz weypisuje napis "felga nr. " i odpowiedni numer felgi + 1
            autor: Kubuś i Madzia
        *****************************************************************************************************************************************************/
        private void btnPoprzedni(object sender, EventArgs e)
        {
            count--;
            if (count == -1) count = 9;

            imgFelga.Source = felgi[count];
            lblNrFelgi.Text = $"Felgi nr {count + 1}";
        }

        /****************************************************************************************************************************************************\
         Nazwa funkcji: btnNastępny
         Parametry wejściowe: brak
         wartość zwracana: brak
         informacje: funkcja po kliknięciu przycisku zmienia zdjęcię z tablicy o +1 oraz weypisuje napis "felga nr. " i odpowiedni numer felgi -1
         autor: Kubuś i Madzia
        *****************************************************************************************************************************************************/

        private void btnNastepny(object sender, EventArgs e)
        {
            count++;
            if (count == 10) count = 0;

            imgFelga.Source = felgi[count];
            lblNrFelgi.Text = $"Felga nr {count + 1}";
        }


        /****************************************************************************************************************************************************\
            Nazwa funkcji: btnLosuj
            Parametry wejściowe: brak
            wartość zwracana: brak
            informacje: funkcja po kliknęciu przycisku losuje randomowe zdjęcię z tablicy o nazwie felgi
            autor: Kubuś i Madzia
        *****************************************************************************************************************************************************/
        private void btnLosuj(object sender, EventArgs e)
        {
            Random random = new Random();
            count = random.Next(0, 10);

            imgFelga.Source = felgi[count];
            lblNrFelgi.Text = $"Felgi nr {count + 1}";
        }
    }

}
