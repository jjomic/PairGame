using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MysteryContent
    {

        public Suspects OfficialAccusation { get; set; }
        public void PickSuspect()
        {
            //MysteryContent killer = new MysteryContent();
            Random rnd = new Random();
            int whoDidIt = rnd.Next(1, 5);
            OfficialAccusation = (Suspects)whoDidIt;

        }

    }
    public enum Suspects
    {
        Martin = 1,
        Karen,
        Matthew,
        Linda,
        Peter
    }
}

        //public bool Accusations
        //{
        //    get
        //    {
        //        if ((int)(OfficialAccusation) == 4)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}