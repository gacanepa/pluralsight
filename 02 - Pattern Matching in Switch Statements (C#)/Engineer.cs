namespace Pattern_Matching_Guide
{
    class Engineer: Employee
    {
        private bool leader;
        public bool Leader
        {
            get
            {
                return this.leader;
            }
            set
            {
                this.leader = value;
            }
        }
    }
}
