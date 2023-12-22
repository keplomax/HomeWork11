namespace HomeWork11
{
    internal class Buildings

    {
        private Building[] buildings;
        public Buildings()
        {
            buildings = new Building[10];
        }

        public Building this[int index]
        {
            get { return buildings[index]; }
            set { buildings[index] = value; }
        }
    }
}
