using System;

namespace Person
{
    public class Person : IComparable
    {
        private int _age;
        private string _name;
        private float _height;
        private float _weight;
        public compare comparethis;
        public event EventHandler<PersonLimitsEventArgs> HumanLimits;

        public enum compare
        {
            name,
            height,
            age,
            weight
        }


        public Person()
        {
            _name = "John Doe";
            _age = 18;
            _height = 70.9992f;
            _weight = 219.5f;
        }

        public Person(string name, int age, float height, float weight)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
        }

        public string name
        {
            get { return this._name; }
            set
            {
                _name = value;
                if (_name == "John Doe")
                {
                    PersonLimitsEventArgs args = new PersonLimitsEventArgs();
                    args.name = _name;
                    this.OnHumanLimits(args);
                }
            }

        }

        public int age
        {
            get { return this._age; }
            set
            {
                _age = value;
                if (_age >= 70)
                {
                    PersonLimitsEventArgs args = new PersonLimitsEventArgs();
                    args.age = _age;
                    OnHumanLimits(args);
                }
            }
        }

        public float height
        {
            get { return this._height; }
            set
            {
                _height = value;
                if (_height >= 80)
                {
                    PersonLimitsEventArgs args = new PersonLimitsEventArgs();
                    args.height = _height;
                    this.OnHumanLimits(args);
                }
            }

        }

        public float weight
        {
            get { return this._weight; }
            set
            {
                _weight = value;
                if (_weight >= 250)
                {
                    PersonLimitsEventArgs args = new PersonLimitsEventArgs();
                    args.weight = _weight;
                    this.OnHumanLimits(args);
                }
            }

        }

        public int CompareTo(object other)
        {
            if (other == null) return 1;
            Person otherperson = other as Person;

            if (otherperson != null && otherperson.comparethis == Person.compare.name)
            {
                return this.name.CompareTo(otherperson.name);
            }
            else if (otherperson != null && otherperson.comparethis == Person.compare.age)
            {
                return this.age.CompareTo(otherperson.age);
            }
            else if (otherperson != null && otherperson.comparethis == Person.compare.height)
            {
                return this.height.CompareTo(otherperson.height);
            }
            else if (otherperson != null && otherperson.comparethis == Person.compare.weight)
            {
                return this.weight.CompareTo(otherperson.weight);
            }
            else
                throw new ArgumentException("Object is not a Person");


        }

        protected virtual void OnHumanLimits(PersonLimitsEventArgs e)
        {
            EventHandler<PersonLimitsEventArgs> handler = HumanLimits;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public override string ToString()
        {
            return String.Format("Person name = {0} age = {1} years old weight = {2} lbs height = {3} inches tall compared On {4}", this._name, this._age, this._weight, this._height, this.comparethis);
        }
    }
}
