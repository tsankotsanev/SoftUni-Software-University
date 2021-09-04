namespace _01.Cars
{
    interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Start() => "Engine start";

        public string Stop() => "Breaaak!";

    }
}
