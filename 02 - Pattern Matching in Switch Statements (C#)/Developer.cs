namespace Pattern_Matching_Guide
{
    class Developer: Employee
    {
        private string language;
        public string Language
        {
            get
            {
                return this.language;
            }
            set
            {
                this.language = value;
            }
        }
    }
}
