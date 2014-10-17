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

namespace PackageTracker {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            var Reader = new RFIDReader(this, AsyncOperationManager.SynchronizationContext);
        }

        public void SyncThreads(int CardNumber, SynchronizationContext UIContext) {
            UIContext.Post(ProcessCardNumber, CardNumber.ToString());
        }

        private void ProcessCardNumber(object InCardNumber) {
            String Test = InCardNumber.ToString();


        }
    }
}
