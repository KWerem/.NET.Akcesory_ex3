namespace Akcesory
{
    class Hours
    {
        private int hour; // ta zmienna posiada właściwość
        //private int second;
        private string oznaczenie;

        public int Hour // Definicja właściwość
        {
            get
            { return hour; }
            set
            {
                //if (value >= 0 && value <= 24)
                //{ hour = value; second = value * 3600; }

                if (value == 0)
                {
                    hour = value + 12;
                    oznaczenie = "AM.";
                }
                else if (value == 12)
                {
                    hour = value;
                    oznaczenie = "PM.";
                }
                else if (value > 0 && value < 12)
                {
                    hour = value; 
                    oznaczenie = "AM."; 
                }
                else if (value > 12 && value <=23)
                {
                    hour = value - 12;
                    oznaczenie = "PM.";
                }
                else { hour = -1;   }

            }
        }

        public string Info()
        {
            if (hour == -1)
            {
                { return "Nieprawidłowa wartośc godziny!"; }
            } else { return "Godzina: " + hour + " " + oznaczenie; }

            // return "Godzina " + hour + ". " + second +
           // " sekunda tej doby.";
        }
    }
}
