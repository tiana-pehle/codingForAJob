using nameSplitParse.core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameSplitParse.core.Repository
{
    public class NameRepository
    {
        private static ObservableCollection<Name> names = new ObservableCollection<Name>();

        public static Name Create()
        {
           Name name = new Name();

           names.Add(name);

            return name;

        }
        public static void Update(Name name, string firstName, string lastName, string fullName)
        {
            name.FirstName = firstName;
            name.LastName = lastName;
            name.FullName = fullName;
        }

    }
}
