namespace JokeMaster
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btBadumTish = new System.Windows.Forms.Button();
            this.btFyutHa = new System.Windows.Forms.Button();
            this.btSadTrombone = new System.Windows.Forms.Button();
            this.btChastushka = new System.Windows.Forms.Button();
            this.btDimitrius = new System.Windows.Forms.Button();
            this.btBash = new System.Windows.Forms.Button();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.btSlavyanka = new System.Windows.Forms.Button();
            this.btNeNeNe = new System.Windows.Forms.Button();
            this.btLeviosa = new System.Windows.Forms.Button();
            this.btBeavis = new System.Windows.Forms.Button();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBadumTish
            // 
            this.btBadumTish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBadumTish.Location = new System.Drawing.Point(5, 5);
            this.btBadumTish.Margin = new System.Windows.Forms.Padding(5);
            this.btBadumTish.Name = "btBadumTish";
            this.btBadumTish.Size = new System.Drawing.Size(224, 43);
            this.btBadumTish.TabIndex = 0;
            this.btBadumTish.Text = "Смешная шутка";
            this.btBadumTish.UseVisualStyleBackColor = true;
            this.btBadumTish.Click += new System.EventHandler(this.BtBadumTish_Click);
            // 
            // btFyutHa
            // 
            this.btFyutHa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btFyutHa.Location = new System.Drawing.Point(5, 58);
            this.btFyutHa.Margin = new System.Windows.Forms.Padding(5);
            this.btFyutHa.Name = "btFyutHa";
            this.btFyutHa.Size = new System.Drawing.Size(224, 43);
            this.btFyutHa.TabIndex = 1;
            this.btFyutHa.Text = "Нормальная шутка";
            this.btFyutHa.UseVisualStyleBackColor = true;
            this.btFyutHa.Click += new System.EventHandler(this.BtFyutHa_Click);
            // 
            // btSadTrombone
            // 
            this.btSadTrombone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSadTrombone.Location = new System.Drawing.Point(5, 111);
            this.btSadTrombone.Margin = new System.Windows.Forms.Padding(5);
            this.btSadTrombone.Name = "btSadTrombone";
            this.btSadTrombone.Size = new System.Drawing.Size(224, 43);
            this.btSadTrombone.TabIndex = 2;
            this.btSadTrombone.Text = "Тупая шутка";
            this.btSadTrombone.UseVisualStyleBackColor = true;
            this.btSadTrombone.Click += new System.EventHandler(this.BtSadTrombone_Click);
            // 
            // btChastushka
            // 
            this.btChastushka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChastushka.Location = new System.Drawing.Point(5, 164);
            this.btChastushka.Margin = new System.Windows.Forms.Padding(5);
            this.btChastushka.Name = "btChastushka";
            this.btChastushka.Size = new System.Drawing.Size(224, 43);
            this.btChastushka.TabIndex = 3;
            this.btChastushka.Text = "Частушка";
            this.btChastushka.UseVisualStyleBackColor = true;
            this.btChastushka.Click += new System.EventHandler(this.BtChastushka_Click);
            // 
            // btDimitrius
            // 
            this.btDimitrius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDimitrius.Location = new System.Drawing.Point(5, 217);
            this.btDimitrius.Margin = new System.Windows.Forms.Padding(5);
            this.btDimitrius.Name = "btDimitrius";
            this.btDimitrius.Size = new System.Drawing.Size(224, 43);
            this.btDimitrius.TabIndex = 4;
            this.btDimitrius.Text = "Тема Димана";
            this.btDimitrius.UseVisualStyleBackColor = true;
            this.btDimitrius.Click += new System.EventHandler(this.BtDimitrius_Click);
            // 
            // btBash
            // 
            this.btBash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBash.Image = ((System.Drawing.Image)(resources.GetObject("btBash.Image")));
            this.btBash.Location = new System.Drawing.Point(5, 270);
            this.btBash.Margin = new System.Windows.Forms.Padding(5);
            this.btBash.Name = "btBash";
            this.btBash.Size = new System.Drawing.Size(224, 43);
            this.btBash.TabIndex = 5;
            this.btBash.UseVisualStyleBackColor = true;
            this.btBash.Click += new System.EventHandler(this.BtBash_Click);
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Controls.Add(this.btSlavyanka, 0, 9);
            this.tlp.Controls.Add(this.btNeNeNe, 0, 8);
            this.tlp.Controls.Add(this.btLeviosa, 0, 7);
            this.tlp.Controls.Add(this.btBadumTish, 0, 0);
            this.tlp.Controls.Add(this.btBash, 0, 5);
            this.tlp.Controls.Add(this.btSadTrombone, 0, 2);
            this.tlp.Controls.Add(this.btDimitrius, 0, 4);
            this.tlp.Controls.Add(this.btFyutHa, 0, 1);
            this.tlp.Controls.Add(this.btChastushka, 0, 3);
            this.tlp.Controls.Add(this.btBeavis, 0, 6);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Margin = new System.Windows.Forms.Padding(0);
            this.tlp.Name = "tlp";
            this.tlp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.tlp.RowCount = 10;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.99991F));
            this.tlp.Size = new System.Drawing.Size(234, 549);
            this.tlp.TabIndex = 6;
            // 
            // btSlavyanka
            // 
            this.btSlavyanka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSlavyanka.Location = new System.Drawing.Point(5, 482);
            this.btSlavyanka.Margin = new System.Windows.Forms.Padding(5);
            this.btSlavyanka.Name = "btSlavyanka";
            this.btSlavyanka.Size = new System.Drawing.Size(224, 47);
            this.btSlavyanka.TabIndex = 9;
            this.btSlavyanka.Text = "Прощание славянки";
            this.btSlavyanka.UseVisualStyleBackColor = true;
            this.btSlavyanka.Click += new System.EventHandler(this.BtSlavyanka_Click);
            // 
            // btNeNeNe
            // 
            this.btNeNeNe.BackgroundImage = global::JokeMaster.Properties.Resources.vrotmnenogi;
            this.btNeNeNe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNeNeNe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNeNeNe.Location = new System.Drawing.Point(5, 429);
            this.btNeNeNe.Margin = new System.Windows.Forms.Padding(5);
            this.btNeNeNe.Name = "btNeNeNe";
            this.btNeNeNe.Size = new System.Drawing.Size(224, 43);
            this.btNeNeNe.TabIndex = 8;
            this.btNeNeNe.UseVisualStyleBackColor = true;
            this.btNeNeNe.Click += new System.EventHandler(this.BtNeNeNe_Click);
            // 
            // btLeviosa
            // 
            this.btLeviosa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLeviosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLeviosa.Image = ((System.Drawing.Image)(resources.GetObject("btLeviosa.Image")));
            this.btLeviosa.Location = new System.Drawing.Point(5, 376);
            this.btLeviosa.Margin = new System.Windows.Forms.Padding(5);
            this.btLeviosa.Name = "btLeviosa";
            this.btLeviosa.Size = new System.Drawing.Size(224, 43);
            this.btLeviosa.TabIndex = 7;
            this.btLeviosa.UseVisualStyleBackColor = true;
            this.btLeviosa.Click += new System.EventHandler(this.BtLeviosa_Click);
            // 
            // btBeavis
            // 
            this.btBeavis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBeavis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBeavis.Image = ((System.Drawing.Image)(resources.GetObject("btBeavis.Image")));
            this.btBeavis.Location = new System.Drawing.Point(5, 323);
            this.btBeavis.Margin = new System.Windows.Forms.Padding(5);
            this.btBeavis.Name = "btBeavis";
            this.btBeavis.Size = new System.Drawing.Size(224, 43);
            this.btBeavis.TabIndex = 6;
            this.btBeavis.UseVisualStyleBackColor = true;
            this.btBeavis.Click += new System.EventHandler(this.BtBeavis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 549);
            this.Controls.Add(this.tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Joke Master";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBadumTish;
        private System.Windows.Forms.Button btFyutHa;
        private System.Windows.Forms.Button btSadTrombone;
        private System.Windows.Forms.Button btChastushka;
        private System.Windows.Forms.Button btDimitrius;
        private System.Windows.Forms.Button btBash;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Button btLeviosa;
        private System.Windows.Forms.Button btBeavis;
        private System.Windows.Forms.Button btNeNeNe;
        private System.Windows.Forms.Button btSlavyanka;
    }
}

