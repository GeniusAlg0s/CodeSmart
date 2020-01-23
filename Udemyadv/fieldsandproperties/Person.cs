using System;
using System.Collections.Generic;
using System.Text;

namespace accessModifiers_public_and_private
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
