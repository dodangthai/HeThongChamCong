namespace ATINTimekeeping.FormHeThong
{
    partial class KhaiBaoPhongBanAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhaiBaoPhongBanAdd));
            this.txtTenPhongBan = new DevExpress.XtraEditors.TextEdit();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhongBan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(11, 11);
            this.txtTenPhongBan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTenPhongBan.Properties.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtTenPhongBan.Size = new System.Drawing.Size(412, 24);
            this.txtTenPhongBan.TabIndex = 62;
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnAccept.Appearance.Options.UseBorderColor = true;
            this.btnAccept.Location = new System.Drawing.Point(170, 48);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 23);
            this.btnAccept.TabIndex = 81;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // KhaiBaoPhongBanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 79);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtTenPhongBan);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("KhaiBaoPhongBanAdd.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(450, 360);
            this.Name = "KhaiBaoPhongBanAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xin nhập tên phòng ban bên dưới";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhongBan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTenPhongBan;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
    }
}