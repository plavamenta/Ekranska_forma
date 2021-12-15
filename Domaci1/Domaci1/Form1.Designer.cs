namespace Domaci1
{
    partial class Form1
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_izvodjac = new System.Windows.Forms.TextBox();
            this.txt_trajanje = new System.Windows.Forms.TextBox();
            this.txt_jezik = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_izvodjac = new System.Windows.Forms.Label();
            this.lbl_trajanje = new System.Windows.Forms.Label();
            this.lbl_jezik = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.but_insert = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_levolevo = new System.Windows.Forms.Button();
            this.but_desnodesno = new System.Windows.Forms.Button();
            this.but_levo = new System.Windows.Forms.Button();
            this.but_desno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(206, 84);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(206, 133);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(100, 20);
            this.txt_naziv.TabIndex = 1;
            // 
            // txt_izvodjac
            // 
            this.txt_izvodjac.Location = new System.Drawing.Point(206, 179);
            this.txt_izvodjac.Name = "txt_izvodjac";
            this.txt_izvodjac.Size = new System.Drawing.Size(100, 20);
            this.txt_izvodjac.TabIndex = 2;
            // 
            // txt_trajanje
            // 
            this.txt_trajanje.Location = new System.Drawing.Point(206, 226);
            this.txt_trajanje.Name = "txt_trajanje";
            this.txt_trajanje.Size = new System.Drawing.Size(100, 20);
            this.txt_trajanje.TabIndex = 3;
            // 
            // txt_jezik
            // 
            this.txt_jezik.Location = new System.Drawing.Point(206, 270);
            this.txt_jezik.Name = "txt_jezik";
            this.txt_jezik.Size = new System.Drawing.Size(100, 20);
            this.txt_jezik.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(106, 88);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(28, 16);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naziv.Location = new System.Drawing.Point(106, 137);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(49, 16);
            this.lbl_naziv.TabIndex = 6;
            this.lbl_naziv.Text = "Naziv:";
            // 
            // lbl_izvodjac
            // 
            this.lbl_izvodjac.AutoSize = true;
            this.lbl_izvodjac.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izvodjac.Location = new System.Drawing.Point(106, 180);
            this.lbl_izvodjac.Name = "lbl_izvodjac";
            this.lbl_izvodjac.Size = new System.Drawing.Size(70, 16);
            this.lbl_izvodjac.TabIndex = 7;
            this.lbl_izvodjac.Text = "Izvodjac:";
            // 
            // lbl_trajanje
            // 
            this.lbl_trajanje.AutoSize = true;
            this.lbl_trajanje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trajanje.Location = new System.Drawing.Point(106, 226);
            this.lbl_trajanje.Name = "lbl_trajanje";
            this.lbl_trajanje.Size = new System.Drawing.Size(87, 32);
            this.lbl_trajanje.TabIndex = 8;
            this.lbl_trajanje.Text = "Trajanje u\r\nsekundama:";
            // 
            // lbl_jezik
            // 
            this.lbl_jezik.AutoSize = true;
            this.lbl_jezik.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jezik.Location = new System.Drawing.Point(106, 274);
            this.lbl_jezik.Name = "lbl_jezik";
            this.lbl_jezik.Size = new System.Drawing.Size(45, 16);
            this.lbl_jezik.TabIndex = 9;
            this.lbl_jezik.Text = "Jezik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pesme:";
            // 
            // but_insert
            // 
            this.but_insert.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_insert.Location = new System.Drawing.Point(132, 337);
            this.but_insert.Name = "but_insert";
            this.but_insert.Size = new System.Drawing.Size(75, 34);
            this.but_insert.TabIndex = 11;
            this.but_insert.Text = "INSERT";
            this.but_insert.UseVisualStyleBackColor = true;
            this.but_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_update
            // 
            this.but_update.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.Location = new System.Drawing.Point(225, 337);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(75, 35);
            this.but_update.TabIndex = 12;
            this.but_update.Text = "UPDATE";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_delete
            // 
            this.but_delete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.Location = new System.Drawing.Point(318, 337);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 35);
            this.but_delete.TabIndex = 13;
            this.but_delete.Text = "DELETE";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_clear.Location = new System.Drawing.Point(378, 180);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 70);
            this.but_clear.TabIndex = 14;
            this.but_clear.Text = "CLEAR";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_levolevo
            // 
            this.but_levolevo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_levolevo.Location = new System.Drawing.Point(21, 336);
            this.but_levolevo.Name = "but_levolevo";
            this.but_levolevo.Size = new System.Drawing.Size(48, 35);
            this.but_levolevo.TabIndex = 15;
            this.but_levolevo.Text = "<<";
            this.but_levolevo.UseVisualStyleBackColor = true;
            this.but_levolevo.Click += new System.EventHandler(this.but_levolevo_Click);
            // 
            // but_desnodesno
            // 
            this.but_desnodesno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_desnodesno.Location = new System.Drawing.Point(459, 336);
            this.but_desnodesno.Name = "but_desnodesno";
            this.but_desnodesno.Size = new System.Drawing.Size(45, 34);
            this.but_desnodesno.TabIndex = 16;
            this.but_desnodesno.Text = ">>\r\n";
            this.but_desnodesno.UseVisualStyleBackColor = true;
            this.but_desnodesno.Click += new System.EventHandler(this.but_desnodesno_Click);
            // 
            // but_levo
            // 
            this.but_levo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_levo.Location = new System.Drawing.Point(75, 336);
            this.but_levo.Name = "but_levo";
            this.but_levo.Size = new System.Drawing.Size(39, 35);
            this.but_levo.TabIndex = 17;
            this.but_levo.Text = "<";
            this.but_levo.UseVisualStyleBackColor = true;
            this.but_levo.Click += new System.EventHandler(this.but_levo_Click);
            // 
            // but_desno
            // 
            this.but_desno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_desno.Location = new System.Drawing.Point(414, 337);
            this.but_desno.Name = "but_desno";
            this.but_desno.Size = new System.Drawing.Size(39, 34);
            this.but_desno.TabIndex = 18;
            this.but_desno.Text = ">";
            this.but_desno.UseVisualStyleBackColor = true;
            this.but_desno.Click += new System.EventHandler(this.but_desno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 401);
            this.Controls.Add(this.but_desno);
            this.Controls.Add(this.but_levo);
            this.Controls.Add(this.but_desnodesno);
            this.Controls.Add(this.but_levolevo);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.but_insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_jezik);
            this.Controls.Add(this.lbl_trajanje);
            this.Controls.Add(this.lbl_izvodjac);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_jezik);
            this.Controls.Add(this.txt_trajanje);
            this.Controls.Add(this.txt_izvodjac);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_izvodjac;
        private System.Windows.Forms.TextBox txt_trajanje;
        private System.Windows.Forms.TextBox txt_jezik;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_izvodjac;
        private System.Windows.Forms.Label lbl_trajanje;
        private System.Windows.Forms.Label lbl_jezik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_insert;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_levolevo;
        private System.Windows.Forms.Button but_desnodesno;
        private System.Windows.Forms.Button but_levo;
        private System.Windows.Forms.Button but_desno;
    }
}

