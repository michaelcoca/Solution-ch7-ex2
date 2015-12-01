using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7_ex2
{
    class FunnyFunny:IClown
    {
        protected string funnyThingIHave;

        public string FunnyThingIHave
        {
            get { return "Honk honk! I have a " + funnyThingIHave; }
            //set { funnyThingIHave = value; }
        }

        public FunnyFunny()
        {

        }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }
    }
}
