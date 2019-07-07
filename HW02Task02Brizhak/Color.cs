namespace HW02Task02Brizhak
{
    class Color
    {
        public Color()
        {
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}";
        }

        private string name;
    }
}
