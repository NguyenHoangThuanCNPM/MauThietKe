using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    class Door
    {
        PictureBox status;
        
        public Door(PictureBox status)
        {
            this.status = status;
        }

        public void Open()
        {
            this.status.Image = global::Lab06_RemoteControl.Properties.Resources.open;
        }

        public void Close()
        {
            this.status.Image = global::Lab06_RemoteControl.Properties.Resources.close;
        }
    }

    class DoorON : ICommand
    {
        private Door door;

        public DoorON(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            this.door.Open();
        }
    }

    class DoorOFF : ICommand
    {
        private Door door;

        public DoorOFF(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            this.door.Close();
        }
    }
}
