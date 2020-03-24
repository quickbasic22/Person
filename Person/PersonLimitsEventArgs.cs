using System;

namespace Person
{
    public class PersonLimitsEventArgs : EventArgs
    {
        public string name { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public int age { get; set; }
    }
}
