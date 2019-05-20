using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCireyPract
{
    class People
    {
        private List<Person> somePeople = new List<Person>();

        public People()
        {
            somePeople.Add(new Person("Timoty", "Peterson"));
            somePeople.Add(new Person("Luke", "Skywalker"));
            somePeople.Add(new Person("Karika", "Csapatási"));
        }

        public List<Person> Crowd { get { return somePeople; } }
    }
}
