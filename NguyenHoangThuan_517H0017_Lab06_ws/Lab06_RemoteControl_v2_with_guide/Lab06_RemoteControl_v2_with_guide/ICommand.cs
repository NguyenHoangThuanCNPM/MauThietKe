using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    interface ICommand
    {
        void Execute();
    }

    class NoCommand : ICommand
    {
        public void Execute()
        {
            MessageBox.Show("Please choice device for this slots");
        }

        private NoCommand() {}
        private static NoCommand _Instance = new NoCommand();

        public static NoCommand GetInstance()
        {
            return _Instance;
        }
    }
}
