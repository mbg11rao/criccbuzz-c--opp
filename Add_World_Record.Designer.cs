
namespace CricBuzz
{
    partial class Add_World_Record
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
            this.btn_back = new System.Windows.Forms.Button();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.btn_Record = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_against = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Record_holder = new System.Windows.Forms.TextBox();
            this.txt_Record_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(109, 232);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 35);
            this.btn_back.TabIndex = 72;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(28, 12);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(428, 51);
            this.button_WOC1.TabIndex = 71;
            this.button_WOC1.Text = "Add Record";
            this.button_WOC1.TextColor = System.Drawing.SystemColors.WindowText;
            this.button_WOC1.UseVisualStyleBackColor = false;
            // 
            // btn_Record
            // 
            this.btn_Record.BackColor = System.Drawing.Color.Transparent;
            this.btn_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Record.Location = new System.Drawing.Point(292, 232);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(164, 35);
            this.btn_Record.TabIndex = 70;
            this.btn_Record.Text = "Add Record";
            this.btn_Record.UseVisualStyleBackColor = false;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "RecordHolder(Player/Team)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Opponent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Record Name";
            // 
            // txt_against
            // 
            this.txt_against.Location = new System.Drawing.Point(291, 145);
            this.txt_against.Multiline = true;
            this.txt_against.Name = "txt_against";
            this.txt_against.Size = new System.Drawing.Size(164, 32);
            this.txt_against.TabIndex = 60;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(291, 183);
            this.txt_Date.Multiline = true;
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(165, 32);
            this.txt_Date.TabIndex = 59;
            // 
            // txt_Record_holder
            // 
            this.txt_Record_holder.Location = new System.Drawing.Point(291, 107);
            this.txt_Record_holder.Multiline = true;
            this.txt_Record_holder.Name = "txt_Record_holder";
            this.txt_Record_holder.Size = new System.Drawing.Size(164, 32);
            this.txt_Record_holder.TabIndex = 57;
            this.txt_Record_holder.TextChanged += new System.EventHandler(this.txt_shirtNo_TextChanged);
            // 
            // txt_Record_name
            // 
            this.txt_Record_name.Location = new System.Drawing.Point(291, 69);
            this.txt_Record_name.Multiline = true;
            this.txt_Record_name.Name = "txt_Record_name";
            this.txt_Record_name.Size = new System.Drawing.Size(164, 32);
            this.txt_Record_name.TabIndex = 56;
            // 
            // Add_World_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 313);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.btn_Record);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_against);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Record_holder);
            this.Controls.Add(this.txt_Record_name);
            this.Name = "Add_World_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_World_Record";
            this.Load += new System.EventHandler(this.Add_World_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_against;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Record_holder;
        private System.Windows.Forms.TextBox txt_Record_name;
    }
}