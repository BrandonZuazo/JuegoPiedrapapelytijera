namespace Piedrapapelytijera2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupUsuario = new System.Windows.Forms.GroupBox();
            this.butPiedraPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butRocaPC = new System.Windows.Forms.Button();
            this.butTijeraPC = new System.Windows.Forms.Button();
            this.butPapelPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labPcwin = new System.Windows.Forms.Label();
            this.labEmpate = new System.Windows.Forms.Label();
            this.labPlayerwin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.butPapel = new System.Windows.Forms.Button();
            this.butTijera = new System.Windows.Forms.Button();
            this.groupUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUsuario
            // 
            this.groupUsuario.Controls.Add(this.butTijera);
            this.groupUsuario.Controls.Add(this.butPapel);
            this.groupUsuario.Controls.Add(this.butPiedraPlay);
            this.groupUsuario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUsuario.ForeColor = System.Drawing.Color.Lime;
            this.groupUsuario.Location = new System.Drawing.Point(12, 29);
            this.groupUsuario.Name = "groupUsuario";
            this.groupUsuario.Size = new System.Drawing.Size(509, 179);
            this.groupUsuario.TabIndex = 3;
            this.groupUsuario.TabStop = false;
            this.groupUsuario.Enter += new System.EventHandler(this.groupUsuario_Enter);
            // 
            // butPiedraPlay
            // 
            this.butPiedraPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPiedraPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butPiedraPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPiedraPlay.ForeColor = System.Drawing.Color.Black;
            this.butPiedraPlay.Image = global::Piedrapapelytijera2._0.Properties.Resources.Piedra;
            this.butPiedraPlay.Location = new System.Drawing.Point(24, 53);
            this.butPiedraPlay.Name = "butPiedraPlay";
            this.butPiedraPlay.Size = new System.Drawing.Size(96, 76);
            this.butPiedraPlay.TabIndex = 1;
            this.butPiedraPlay.UseVisualStyleBackColor = true;
            this.butPiedraPlay.Click += new System.EventHandler(this.butPiedraPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRocaPC);
            this.groupBox2.Controls.Add(this.butTijeraPC);
            this.groupBox2.Controls.Add(this.butPapelPC);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC";
            // 
            // butRocaPC
            // 
            this.butRocaPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRocaPC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butRocaPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRocaPC.Image = global::Piedrapapelytijera2._0.Properties.Resources.Piedra;
            this.butRocaPC.Location = new System.Drawing.Point(24, 53);
            this.butRocaPC.Name = "butRocaPC";
            this.butRocaPC.Size = new System.Drawing.Size(96, 76);
            this.butRocaPC.TabIndex = 0;
            this.butRocaPC.UseVisualStyleBackColor = true;
            // 
            // butTijeraPC
            // 
            this.butTijeraPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butTijeraPC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butTijeraPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTijeraPC.Image = global::Piedrapapelytijera2._0.Properties.Resources.Tijeras;
            this.butTijeraPC.Location = new System.Drawing.Point(359, 53);
            this.butTijeraPC.Name = "butTijeraPC";
            this.butTijeraPC.Size = new System.Drawing.Size(96, 76);
            this.butTijeraPC.TabIndex = 1;
            this.butTijeraPC.UseVisualStyleBackColor = true;
            // 
            // butPapelPC
            // 
            this.butPapelPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPapelPC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butPapelPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPapelPC.Image = global::Piedrapapelytijera2._0.Properties.Resources.Papel;
            this.butPapelPC.Location = new System.Drawing.Point(193, 53);
            this.butPapelPC.Name = "butPapelPC";
            this.butPapelPC.Size = new System.Drawing.Size(96, 76);
            this.butPapelPC.TabIndex = 2;
            this.butPapelPC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labPcwin);
            this.groupBox3.Controls.Add(this.labEmpate);
            this.groupBox3.Controls.Add(this.labPlayerwin);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labPlayer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(527, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 310);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // labPcwin
            // 
            this.labPcwin.AutoSize = true;
            this.labPcwin.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPcwin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labPcwin.Location = new System.Drawing.Point(26, 194);
            this.labPcwin.Name = "labPcwin";
            this.labPcwin.Size = new System.Drawing.Size(169, 30);
            this.labPcwin.TabIndex = 13;
            this.labPcwin.Text = "PC GANADOR";
            // 
            // labEmpate
            // 
            this.labEmpate.AutoSize = true;
            this.labEmpate.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmpate.ForeColor = System.Drawing.Color.Cyan;
            this.labEmpate.Location = new System.Drawing.Point(55, 194);
            this.labEmpate.Name = "labEmpate";
            this.labEmpate.Size = new System.Drawing.Size(113, 30);
            this.labEmpate.TabIndex = 12;
            this.labEmpate.Text = "EMPATE";
            // 
            // labPlayerwin
            // 
            this.labPlayerwin.AutoSize = true;
            this.labPlayerwin.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayerwin.ForeColor = System.Drawing.Color.Lime;
            this.labPlayerwin.Location = new System.Drawing.Point(26, 194);
            this.labPlayerwin.Name = "labPlayerwin";
            this.labPlayerwin.Size = new System.Drawing.Size(109, 30);
            this.labPlayerwin.TabIndex = 11;
            this.labPlayerwin.Text = "PLAYER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(92, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "PC";
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer.ForeColor = System.Drawing.Color.Lime;
            this.labPlayer.Location = new System.Drawing.Point(166, 110);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(74, 23);
            this.labPlayer.TabIndex = 6;
            this.labPlayer.Text = "player";
            // 
            // butPapel
            // 
            this.butPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPapel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPapel.ForeColor = System.Drawing.Color.Black;
            this.butPapel.Image = global::Piedrapapelytijera2._0.Properties.Resources.Papel;
            this.butPapel.Location = new System.Drawing.Point(206, 51);
            this.butPapel.Name = "butPapel";
            this.butPapel.Size = new System.Drawing.Size(96, 76);
            this.butPapel.TabIndex = 5;
            this.butPapel.UseVisualStyleBackColor = true;
            this.butPapel.Click += new System.EventHandler(this.butPapel_Click);
            // 
            // butTijera
            // 
            this.butTijera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butTijera.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butTijera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTijera.ForeColor = System.Drawing.Color.Black;
            this.butTijera.Image = global::Piedrapapelytijera2._0.Properties.Resources.Tijeras;
            this.butTijera.Location = new System.Drawing.Point(359, 53);
            this.butTijera.Name = "butTijera";
            this.butTijera.Size = new System.Drawing.Size(96, 76);
            this.butTijera.TabIndex = 6;
            this.butTijera.UseVisualStyleBackColor = true;
            this.butTijera.Click += new System.EventHandler(this.butTijera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 444);
            this.Name = "Form1";
            this.Text = "Piedra,Papel y Tijera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupUsuario.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butRocaPC;
        private System.Windows.Forms.Button butTijeraPC;
        private System.Windows.Forms.Button butPapelPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Button butPiedraPlay;
        private System.Windows.Forms.Label labPcwin;
        private System.Windows.Forms.Label labEmpate;
        private System.Windows.Forms.Label labPlayerwin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butPapel;
        private System.Windows.Forms.Button butTijera;
    }
}

