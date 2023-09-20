
namespace HotelSYS
{
    partial class frmUpdRoomType
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
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(27, 32);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(153, 25);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Select Room Type";
            this.lblRoomType.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "DB - Double Room",
            "SL - Single Room",
            "FM - Family"});
            this.cboRoomType.Location = new System.Drawing.Point(199, 29);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(155, 33);
            this.cboRoomType.TabIndex = 1;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.btnSubmit);
            this.grpRoomType.Controls.Add(this.txtRate);
            this.grpRoomType.Controls.Add(this.lblRate);
            this.grpRoomType.Controls.Add(this.txtDescription);
            this.grpRoomType.Controls.Add(this.lblDescription);
            this.grpRoomType.Controls.Add(this.txtTypeCode);
            this.grpRoomType.Controls.Add(this.lblTypeCode);
            this.grpRoomType.Location = new System.Drawing.Point(39, 103);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(516, 316);
            this.grpRoomType.TabIndex = 2;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Update Room Type";
            this.grpRoomType.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(186, 228);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 35);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(245, 170);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(150, 31);
            this.txtRate.TabIndex = 10;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(122, 170);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(47, 25);
            this.lblRate.TabIndex = 12;
            this.lblRate.Text = "Rate";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(245, 111);
            this.txtDescription.MaxLength = 20;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 31);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(122, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Location = new System.Drawing.Point(245, 54);
            this.txtTypeCode.MaxLength = 2;
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(150, 31);
            this.txtTypeCode.TabIndex = 7;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Location = new System.Drawing.Point(122, 54);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(96, 25);
            this.lblTypeCode.TabIndex = 8;
            this.lblTypeCode.Text = "Type Code";
            // 
            // frmUpdRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Name = "frmUpdRoomType";
            this.Text = "Happy House Hotel - [Update Room Type]  ";
            this.Load += new System.EventHandler(this.frmUpdRoomType_Load);
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.Label lblTypeCode;
    }
}