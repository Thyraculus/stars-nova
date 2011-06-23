﻿using System;

using Nova.Common;

namespace Nova.ControlLibrary
{
    /// <summary>
    /// A dialog for transferring cargo between a planet and a ship.
    /// </summary>
    public partial class CargoDialog : System.Windows.Forms.Form
    {
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.ironiumTransfer = new ControlLibrary.CargoTransfer();
            this.boroniumTransfer = new ControlLibrary.CargoTransfer();
            this.germaniumTransfer = new ControlLibrary.CargoTransfer();
            this.colonistsTransfer = new ControlLibrary.CargoTransfer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cargoBay = new ControlLibrary.Gauge();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(352, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(256, 256);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // IroniumTransfer
            // 
            this.ironiumTransfer.Location = new System.Drawing.Point(24, 48);
            this.ironiumTransfer.Maximum = 10;
            this.ironiumTransfer.Name = "ironiumTransfer";
            this.ironiumTransfer.Size = new System.Drawing.Size(384, 32);
            this.ironiumTransfer.TabIndex = 11;
            this.ironiumTransfer.Title = "Ironium";
            this.ironiumTransfer.Value = 0;
            // 
            // boroniumTransfer
            // 
            this.boroniumTransfer.Location = new System.Drawing.Point(24, 88);
            this.boroniumTransfer.Maximum = 10;
            this.boroniumTransfer.Name = "boroniumTransfer";
            this.boroniumTransfer.Size = new System.Drawing.Size(384, 32);
            this.boroniumTransfer.TabIndex = 12;
            this.boroniumTransfer.Title = "Boranium";
            this.boroniumTransfer.Value = 0;
            // 
            // GermaniumTransfer
            // 
            this.germaniumTransfer.Location = new System.Drawing.Point(24, 128);
            this.germaniumTransfer.Maximum = 10;
            this.germaniumTransfer.Name = "germaniumTransfer";
            this.germaniumTransfer.Size = new System.Drawing.Size(384, 32);
            this.germaniumTransfer.TabIndex = 13;
            this.germaniumTransfer.Title = "Germanium";
            this.germaniumTransfer.Value = 0;
            // 
            // colonistsTransfer
            // 
            this.colonistsTransfer.Location = new System.Drawing.Point(24, 168);
            this.colonistsTransfer.Maximum = 10;
            this.colonistsTransfer.Name = "colonistsTransfer";
            this.colonistsTransfer.Size = new System.Drawing.Size(384, 32);
            this.colonistsTransfer.TabIndex = 14;
            this.colonistsTransfer.Title = "Colonists";
            this.colonistsTransfer.Value = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Resources On Hand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(320, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cargo Bay Content";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CargoBay
            // 
            this.cargoBay.BarColour = System.Drawing.Color.LightGreen;
            this.cargoBay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cargoBay.Location = new System.Drawing.Point(96, 216);
            this.cargoBay.Maximum = 50;
            this.cargoBay.Name = "cargoBay";
            this.cargoBay.ShowText = true;
            this.cargoBay.Size = new System.Drawing.Size(152, 16);
            this.cargoBay.TabIndex = 17;
            this.cargoBay.Units = "kT";
            this.cargoBay.Value = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(264, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cargo Bay";
            // 
            // CargoDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(434, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cargoBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colonistsTransfer);
            this.Controls.Add(this.germaniumTransfer);
            this.Controls.Add(this.boroniumTransfer);
            this.Controls.Add(this.ironiumTransfer);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargoDialog";
            this.ShowInTaskbar = false;
            this.Text = "Cargo Transfer";
            this.ResumeLayout(false);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">Set to true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private Nova.ControlLibrary.CargoTransfer ironiumTransfer;
        private Nova.ControlLibrary.CargoTransfer boroniumTransfer;
        private Nova.ControlLibrary.CargoTransfer germaniumTransfer;
        private Nova.ControlLibrary.CargoTransfer colonistsTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Nova.ControlLibrary.Gauge cargoBay;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.Container components = null;
    }
}