using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class PersonSequencer
    {
        private static int personId;
        public static int nextPersonId()
        {
            personId++;
            return personId;
        }
        public static void reset()
        {
            personId = 0;
        }
    }
}
