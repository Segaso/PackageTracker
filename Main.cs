using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PackageTracker 
{
    public partial class Main : Form {
        InputDevice Input;

        public Main() {
            InitializeComponent();

            var Reader = new RFIDReader(this, AsyncOperationManager.SynchronizationContext);

            Input = new InputDevice(Handle);
            Input.EnumerateDevices();
            Input.KeyPressed += new InputDevice.DeviceEventHandler(Main_KeyPressed);
        }

        protected override void WndProc(ref Message message) {
            if (Input != null) {
                Input.ProcessMessage(message);
            }
            base.WndProc(ref message);
        }

        public void SyncThreads(int CardNumber, SynchronizationContext UIContext) {
            UIContext.Post(ProcessCardNumber, CardNumber.ToString());
        }

        private void ProcessCardNumber(object InCardNumber) {
            String Test = InCardNumber.ToString();
        }

        private void Main_KeyPressed(object sender, InputDevice.KeyControlEventArgs e) {
            // e.Keyboard.SubClass tells you where from the event came.
            // e.Keyboard.key gives you the input data.
            var test = e.Keyboard.deviceType;
        }
    }
}
