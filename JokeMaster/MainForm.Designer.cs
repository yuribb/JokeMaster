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
            this.btBeavis = new System.Windows.Forms.Button();
            this.btLeviosa = new System.Windows.Forms.Button();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBadumTish
            // 
            this.btBadumTish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBadumTish.Location = new System.Drawing.Point(5, 5);
            this.btBadumTish.Margin = new System.Windows.Forms.Padding(5);
            this.btBadumTish.Name = "btBadumTish";
            this.btBadumTish.Size = new System.Drawing.Size(224, 42);
            this.btBadumTish.TabIndex = 0;
            this.btBadumTish.Text = "Смешная шутка";
            this.btBadumTish.UseVisualStyleBackColor = true;
            this.btBadumTish.Click += new System.EventHandler(this.BtBadumTish_Click);
            // 
            // btFyutHa
            // 
            this.btFyutHa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btFyutHa.Location = new System.Drawing.Point(5, 57);
            this.btFyutHa.Margin = new System.Windows.Forms.Padding(5);
            this.btFyutHa.Name = "btFyutHa";
            this.btFyutHa.Size = new System.Drawing.Size(224, 42);
            this.btFyutHa.TabIndex = 1;
            this.btFyutHa.Text = "Нормальная шутка";
            this.btFyutHa.UseVisualStyleBackColor = true;
            this.btFyutHa.Click += new System.EventHandler(this.BtFyutHa_Click);
            // 
            // btSadTrombone
            // 
            this.btSadTrombone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSadTrombone.Location = new System.Drawing.Point(5, 109);
            this.btSadTrombone.Margin = new System.Windows.Forms.Padding(5);
            this.btSadTrombone.Name = "btSadTrombone";
            this.btSadTrombone.Size = new System.Drawing.Size(224, 42);
            this.btSadTrombone.TabIndex = 2;
            this.btSadTrombone.Text = "Тупая шутка";
            this.btSadTrombone.UseVisualStyleBackColor = true;
            this.btSadTrombone.Click += new System.EventHandler(this.BtSadTrombone_Click);
            // 
            // btChastushka
            // 
            this.btChastushka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChastushka.Location = new System.Drawing.Point(5, 161);
            this.btChastushka.Margin = new System.Windows.Forms.Padding(5);
            this.btChastushka.Name = "btChastushka";
            this.btChastushka.Size = new System.Drawing.Size(224, 42);
            this.btChastushka.TabIndex = 3;
            this.btChastushka.Text = "Частушка";
            this.btChastushka.UseVisualStyleBackColor = true;
            this.btChastushka.Click += new System.EventHandler(this.BtChastushka_Click);
            // 
            // btDimitrius
            // 
            this.btDimitrius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDimitrius.Location = new System.Drawing.Point(5, 213);
            this.btDimitrius.Margin = new System.Windows.Forms.Padding(5);
            this.btDimitrius.Name = "btDimitrius";
            this.btDimitrius.Size = new System.Drawing.Size(224, 42);
            this.btDimitrius.TabIndex = 4;
            this.btDimitrius.Text = "Тема Димана";
            this.btDimitrius.UseVisualStyleBackColor = true;
            this.btDimitrius.Click += new System.EventHandler(this.BtDimitrius_Click);
            // 
            // btBash
            // 
            this.btBash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBash.Image = ((System.Drawing.Image)(resources.GetObject("btBash.Image")));
            this.btBash.Location = new System.Drawing.Point(5, 265);
            this.btBash.Margin = new System.Windows.Forms.Padding(5);
            this.btBash.Name = "btBash";
            this.btBash.Size = new System.Drawing.Size(224, 42);
            this.btBash.TabIndex = 5;
            this.btBash.UseVisualStyleBackColor = true;
            this.btBash.Click += new System.EventHandler(this.BtBash_Click);
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tlp.RowCount = 8;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(234, 436);
            this.tlp.TabIndex = 6;
            // 
            // btBeavis
            // 
            this.btBeavis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBeavis.Image = ((System.Drawing.Image)(resources.GetObject("btBeavis.Image")));
            this.btBeavis.Location = new System.Drawing.Point(5, 317);
            this.btBeavis.Margin = new System.Windows.Forms.Padding(5);
            this.btBeavis.Name = "btBeavis";
            this.btBeavis.Size = new System.Drawing.Size(224, 42);
            this.btBeavis.TabIndex = 6;
            this.btBeavis.UseVisualStyleBackColor = true;
            this.btBeavis.Click += new System.EventHandler(this.BtBeavis_Click);
            // 
            // btLeviosa
            // 
            this.btLeviosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLeviosa.Image = ((System.Drawing.Image)(resources.GetObject("btLeviosa.Image")));
            this.btLeviosa.Location = new System.Drawing.Point(5, 369);
            this.btLeviosa.Margin = new System.Windows.Forms.Padding(5);
            this.btLeviosa.Name = "btLeviosa";
            this.btLeviosa.Size = new System.Drawing.Size(224, 47);
            this.btLeviosa.TabIndex = 7;
            this.btLeviosa.UseVisualStyleBackColor = true;
            this.btLeviosa.Click += new System.EventHandler(this.BtLeviosa_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 436);
            this.Controls.Add(this.tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Joke Master";
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
    }
}

