using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7_ex2
{
    class ScaryScary:FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public ScaryScary()
        {

        }

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base (funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders"; }
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("You can't have my " + base.funnyThingIHave);
            //MessageBox.Show("Boo! Gotcha!" + funnyThingIHave);
        }

    }
}
