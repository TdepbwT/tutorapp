using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorapp
{
    internal class test
    {
        public bool Instantiation()  // check if program uses instantiation - verify objects are created using new keyword
        {
           
            //check if pack class is instantiated
            pack pack = new pack(52);
            
            if (pack == null)
            {
                return false;
            }

            //check if card class is instantiated
            Card card = new Card(1);
            if (card == null)
            {
                return false;
            }
            
            //check if tutorial class is instantiated
            tutorial tutorial = new tutorial();
            if (tutorial == null)
            {
                return false;
            }

            return true;
        }
        
        public bool Encapsulation() // check if program uses encapsulation - verify that all class variables are private
        {
            //check if pack class variables are private
            pack pack = new pack(52);
            if (pack.GetType().GetFields().Length > 0)
            {
                return false;
            }
            //check if card class variables are private
            Card card = new Card(1);
            if (card.GetType().GetFields().Length > 0)
            {
                return false;
            }
            //check if tutorial class variables are private
            tutorial tutorial = new tutorial();
            if (tutorial.GetType().GetFields().Length > 0)
            {
                return false;
            }
            return true;
        }

        public bool Inheritance() // check if the program uses inheritance - verify classes are inherited from a base class / interface
        {
            if (typeof(pack).BaseType != typeof(object))
            {
                return false;
            }

            if (typeof(Card).BaseType != typeof(object))
            {
                return false;
            }

            if (typeof(tutorial).BaseType != typeof(object))
            {
                return false;
            }
            return true;
        }
 

       

    }
}
