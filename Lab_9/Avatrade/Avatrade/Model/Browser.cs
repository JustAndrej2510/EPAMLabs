using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Model
{
    public class Browser
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Browser() { }

        public Browser(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(typeof(Browser).IsInstanceOfType(obj))) return false;
            Browser browser = (Browser)obj;

            return  Equals(Name, browser.Name);
        }

        public override string ToString()
        {
            return $"Browser\nName: {Name}";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
