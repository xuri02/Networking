﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyForm {
    public partial class Start : Form {
        public Start() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public int    getPortL() { return int.Parse( this.portL.Text ); }
        public int    getPortC() { return int.Parse( this.portC.Text ); }
        public string getIp()   { return this.ip.Text; }

        private void port_KeyPress(object sender, KeyPressEventArgs e) {
            if ( !char.IsControl( e.KeyChar ) && !char.IsDigit( e.KeyChar ) && ( e.KeyChar != '.' ) ) {
                e.Handled = true;
            }
        }

        private void ip_KeyPress(object sender, KeyPressEventArgs e) {
            if ( !char.IsControl( e.KeyChar ) && !char.IsDigit( e.KeyChar ) ) {
                e.Handled = true;
            }
        }
    }
}