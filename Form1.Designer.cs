namespace Pizza____Poject
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStartOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartOrder.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnStartOrder.ForeColor = System.Drawing.Color.Red;
            this.btnStartOrder.Location = new System.Drawing.Point(311, 411);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(197, 46);
            this.btnStartOrder.TabIndex = 0;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = false;
            this.btnStartOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pizza____Poject.Properties.Resources.pizza_logo_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.btnStartOrder);
            this.Name = "FrmMain";
            this.Text = "Pizza Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartOrder;
    }
}

