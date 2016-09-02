using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {
        }

        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {
        //public string Save()
        //{
        //    return "Catalog Save";
        //}
        string ISaveable.Save()
        {
            return "ISaveable Save";
        }
        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
    }


    public class Catalog : ISaveable, IVoidSaveable
    {
        public string Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }

    public class EnumerableCatalog : IEnumerable<string>
    {
        // return type mismatch so VS implements one explicitly 
        public IEnumerator<string> GetEnumerator()
        {
            // alll of our code
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
