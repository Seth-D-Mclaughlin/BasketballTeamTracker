using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.UI
{
    class Program
    {
        // This is the control center..... we don't want ANY LOGIC IN HERE...
        // only method class
        static void Main(string[] args)
        {
            Program_UI UI = new Program_UI();
            UI.Run();
        }
    }
}
