using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    public partial class RemoteControl : Form
    {
        #region Commands
        //Slot 1
        private ICommand Slot1ON = NoCommand.GetInstance();
        private ICommand Slot1OFF = NoCommand.GetInstance();
        //Slot 2
        private ICommand Slot2ON = NoCommand.GetInstance();
        private ICommand Slot2OFF = NoCommand.GetInstance();
        //TODO

        #endregion

        #region Devices
        //Light
        private Light light;
        private ICommand LightON;
        private ICommand LightOFF;

        //TV
        private TV tv;
        private ICommand TVON;
        private ICommand TVOFF;

        //Door
        private Door door;
        private ICommand _DoorOn;
        private ICommand _DoorOff;
        #endregion

        public RemoteControl()
        {
            InitializeComponent();

            //Light
            light = new Light(this.txtStatus1);
            LightON = new LightOn(light);
            LightOFF = new LightOff(light);

            //TV
            tv = new TV(this.btnTV);
            TVON = new TVOn(tv);
            TVOFF = new TVOff(tv);

            //TODO

            door = new Door(this.pictureBox1);
            _DoorOn = new DoorON(door);
            _DoorOff = new DoorOFF(door);
        }

        #region Slot 1
        private void btnOn1_Click(object sender, EventArgs e)
        {
            Slot1ON.Execute();        
        }

        private void btnOFF1_Click(object sender, EventArgs e)
        {
            Slot1OFF.Execute();
        }

        private void cboSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String device = cboSlot1.SelectedItem.ToString();
            choiceDevice(device, 1);
        }
        #endregion

        #region Slot 2
        private void btnON2_Click(object sender, EventArgs e)
        {
            this.Slot2ON.Execute();
        }

        private void btnOFF2_Click(object sender, EventArgs e)
        {
            this.Slot2OFF.Execute();
        }

        private void cboSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String device = cboSlot2.SelectedItem.ToString();
            choiceDevice(device, 2);
        }

        #endregion

        private void choiceDevice(String device, int slotNum)
        {
            if (slotNum == 1)
            {
                assignCommandOnOFF(device, ref Slot1ON, ref Slot1OFF);
            }
            else if (slotNum == 2)
            {
                assignCommandOnOFF(device, ref Slot2ON, ref Slot2OFF);
            }
            //TODO...
        }

        private void assignCommandOnOFF(String device,  ref ICommand On, ref ICommand Off)
        {
            if (device.Equals("Light"))
            {
                Off = LightOFF;
                On = LightON;
            }
            else if (device.Equals("TV"))
            {
                Off = TVOFF;
                On = TVON;
            }
            else if (device.Equals("Door"))
            {
                Off = _DoorOff;
                On = _DoorOn;
            }
            else if (device.Equals("None"))
            {
                Off = NoCommand.GetInstance();
                On = NoCommand.GetInstance();
            }
            //TODO
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
