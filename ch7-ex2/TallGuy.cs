using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7_ex2
{
    public class TallGuy:IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave 
        { 
            get { return "big shoes";} 
        }

        public void TalkAboutYourself()
        {
            MessageBox.Show("My name is " + Name + " and I'm " + Height + " inches tall.");
        }

        public void Honk()
        {
            MessageBox.Show("Honk honk!");
        }
    }
}
