namespace SimuladorIndustria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaMaquina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaMaquina2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaALaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.M1Averiada = new System.Windows.Forms.PictureBox();
            this.M2Arreglada = new System.Windows.Forms.PictureBox();
            this.M1Arreglada = new System.Windows.Forms.PictureBox();
            this.Maquina2 = new System.Windows.Forms.PictureBox();
            this.Maquina1 = new System.Windows.Forms.PictureBox();
            this.M2Averiada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MateriaPrimaLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maquina1Lb = new System.Windows.Forms.Label();
            this.Maquina2Lb = new System.Windows.Forms.Label();
            this.HayRepuestosLb = new System.Windows.Forms.Label();
            this.NoHayRepuestosLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MateriaPrimaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1Averiada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2Arreglada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1Arreglada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maquina2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maquina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2Averiada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.CantidadProducidaMaquina1,
            this.CantidadProducidaMaquina2,
            this.CantidadProducidaTotal,
            this.CantidadProducidaALaFecha});
            this.DataGridView.Location = new System.Drawing.Point(11, 264);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1169, 280);
            this.DataGridView.TabIndex = 0;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            // 
            // CantidadProducidaMaquina1
            // 
            this.CantidadProducidaMaquina1.HeaderText = "Cantidad producida máquina 1";
            this.CantidadProducidaMaquina1.MinimumWidth = 6;
            this.CantidadProducidaMaquina1.Name = "CantidadProducidaMaquina1";
            this.CantidadProducidaMaquina1.Width = 255;
            // 
            // CantidadProducidaMaquina2
            // 
            this.CantidadProducidaMaquina2.HeaderText = "Cantidad producida máquina 2";
            this.CantidadProducidaMaquina2.MinimumWidth = 6;
            this.CantidadProducidaMaquina2.Name = "CantidadProducidaMaquina2";
            this.CantidadProducidaMaquina2.Width = 255;
            // 
            // CantidadProducidaTotal
            // 
            this.CantidadProducidaTotal.HeaderText = "Cantidad total producida";
            this.CantidadProducidaTotal.MinimumWidth = 6;
            this.CantidadProducidaTotal.Name = "CantidadProducidaTotal";
            this.CantidadProducidaTotal.Width = 230;
            // 
            // CantidadProducidaALaFecha
            // 
            this.CantidadProducidaALaFecha.HeaderText = "Cantidad producida a la fecha";
            this.CantidadProducidaALaFecha.Name = "CantidadProducidaALaFecha";
            this.CantidadProducidaALaFecha.Width = 250;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Location = new System.Drawing.Point(537, 11);
            this.IniciarButton.Margin = new System.Windows.Forms.Padding(2);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(94, 44);
            this.IniciarButton.TabIndex = 1;
            this.IniciarButton.Text = "Iniciar";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // M1Averiada
            // 
            this.M1Averiada.BackColor = System.Drawing.Color.SlateGray;
            this.M1Averiada.Image = global::SimuladorIndustria.Properties.Resources.Maquina_averiada;
            this.M1Averiada.Location = new System.Drawing.Point(110, 99);
            this.M1Averiada.Name = "M1Averiada";
            this.M1Averiada.Size = new System.Drawing.Size(20, 18);
            this.M1Averiada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M1Averiada.TabIndex = 6;
            this.M1Averiada.TabStop = false;
            this.M1Averiada.Visible = false;
            // 
            // M2Arreglada
            // 
            this.M2Arreglada.BackColor = System.Drawing.Color.SlateGray;
            this.M2Arreglada.Image = global::SimuladorIndustria.Properties.Resources.Maquina_en_buen_estado;
            this.M2Arreglada.Location = new System.Drawing.Point(1063, 99);
            this.M2Arreglada.Name = "M2Arreglada";
            this.M2Arreglada.Size = new System.Drawing.Size(20, 18);
            this.M2Arreglada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M2Arreglada.TabIndex = 5;
            this.M2Arreglada.TabStop = false;
            // 
            // M1Arreglada
            // 
            this.M1Arreglada.BackColor = System.Drawing.Color.SlateGray;
            this.M1Arreglada.Image = global::SimuladorIndustria.Properties.Resources.Maquina_en_buen_estado;
            this.M1Arreglada.Location = new System.Drawing.Point(110, 99);
            this.M1Arreglada.Name = "M1Arreglada";
            this.M1Arreglada.Size = new System.Drawing.Size(20, 18);
            this.M1Arreglada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M1Arreglada.TabIndex = 4;
            this.M1Arreglada.TabStop = false;
            // 
            // Maquina2
            // 
            this.Maquina2.Image = global::SimuladorIndustria.Properties.Resources.Maquina;
            this.Maquina2.Location = new System.Drawing.Point(964, 43);
            this.Maquina2.Name = "Maquina2";
            this.Maquina2.Size = new System.Drawing.Size(216, 216);
            this.Maquina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maquina2.TabIndex = 3;
            this.Maquina2.TabStop = false;
            // 
            // Maquina1
            // 
            this.Maquina1.Image = global::SimuladorIndustria.Properties.Resources.Maquina;
            this.Maquina1.Location = new System.Drawing.Point(12, 43);
            this.Maquina1.Name = "Maquina1";
            this.Maquina1.Size = new System.Drawing.Size(216, 216);
            this.Maquina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maquina1.TabIndex = 2;
            this.Maquina1.TabStop = false;
            // 
            // M2Averiada
            // 
            this.M2Averiada.BackColor = System.Drawing.Color.SlateGray;
            this.M2Averiada.Image = global::SimuladorIndustria.Properties.Resources.Maquina_averiada;
            this.M2Averiada.Location = new System.Drawing.Point(1063, 99);
            this.M2Averiada.Name = "M2Averiada";
            this.M2Averiada.Size = new System.Drawing.Size(20, 18);
            this.M2Averiada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M2Averiada.TabIndex = 7;
            this.M2Averiada.TabStop = false;
            this.M2Averiada.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Máquina 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1004, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Máquina 2";
            // 
            // MateriaPrimaLb
            // 
            this.MateriaPrimaLb.AutoSize = true;
            this.MateriaPrimaLb.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriaPrimaLb.Location = new System.Drawing.Point(94, 53);
            this.MateriaPrimaLb.Name = "MateriaPrimaLb";
            this.MateriaPrimaLb.Size = new System.Drawing.Size(530, 25);
            this.MateriaPrimaLb.TabIndex = 10;
            this.MateriaPrimaLb.Text = "Queda poca materia prima, debe reabastecerse";
            this.MateriaPrimaLb.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoHayRepuestosLb);
            this.groupBox1.Controls.Add(this.HayRepuestosLb);
            this.groupBox1.Controls.Add(this.Maquina2Lb);
            this.groupBox1.Controls.Add(this.Maquina1Lb);
            this.groupBox1.Controls.Add(this.MateriaPrimaLb);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(234, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Maquina1Lb
            // 
            this.Maquina1Lb.AutoSize = true;
            this.Maquina1Lb.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maquina1Lb.Location = new System.Drawing.Point(201, 53);
            this.Maquina1Lb.Name = "Maquina1Lb";
            this.Maquina1Lb.Size = new System.Drawing.Size(304, 25);
            this.Maquina1Lb.TabIndex = 11;
            this.Maquina1Lb.Text = "Se ha dañado la máquina 1";
            this.Maquina1Lb.Visible = false;
            // 
            // Maquina2Lb
            // 
            this.Maquina2Lb.AutoSize = true;
            this.Maquina2Lb.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maquina2Lb.Location = new System.Drawing.Point(201, 53);
            this.Maquina2Lb.Name = "Maquina2Lb";
            this.Maquina2Lb.Size = new System.Drawing.Size(307, 25);
            this.Maquina2Lb.TabIndex = 12;
            this.Maquina2Lb.Text = "Se ha dañado la máquina 2";
            this.Maquina2Lb.Visible = false;
            // 
            // HayRepuestosLb
            // 
            this.HayRepuestosLb.AutoSize = true;
            this.HayRepuestosLb.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HayRepuestosLb.Location = new System.Drawing.Point(269, 92);
            this.HayRepuestosLb.Name = "HayRepuestosLb";
            this.HayRepuestosLb.Size = new System.Drawing.Size(171, 25);
            this.HayRepuestosLb.TabIndex = 13;
            this.HayRepuestosLb.Text = "Hay repuestos";
            this.HayRepuestosLb.Visible = false;
            // 
            // NoHayRepuestosLb
            // 
            this.NoHayRepuestosLb.AutoSize = true;
            this.NoHayRepuestosLb.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHayRepuestosLb.Location = new System.Drawing.Point(254, 92);
            this.NoHayRepuestosLb.Name = "NoHayRepuestosLb";
            this.NoHayRepuestosLb.Size = new System.Drawing.Size(201, 25);
            this.NoHayRepuestosLb.TabIndex = 14;
            this.NoHayRepuestosLb.Text = "No hay repuestos";
            this.NoHayRepuestosLb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Materia prima";
            // 
            // MateriaPrimaTextBox
            // 
            this.MateriaPrimaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriaPrimaTextBox.Location = new System.Drawing.Point(584, 76);
            this.MateriaPrimaTextBox.Name = "MateriaPrimaTextBox";
            this.MateriaPrimaTextBox.Size = new System.Drawing.Size(148, 26);
            this.MateriaPrimaTextBox.TabIndex = 13;
            this.MateriaPrimaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 555);
            this.Controls.Add(this.MateriaPrimaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.M2Averiada);
            this.Controls.Add(this.M1Averiada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.M2Arreglada);
            this.Controls.Add(this.M1Arreglada);
            this.Controls.Add(this.Maquina2);
            this.Controls.Add(this.Maquina1);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1Averiada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2Arreglada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1Arreglada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maquina2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maquina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2Averiada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Maquina1;
        private System.Windows.Forms.PictureBox Maquina2;
        private System.Windows.Forms.PictureBox M1Arreglada;
        private System.Windows.Forms.PictureBox M2Arreglada;
        private System.Windows.Forms.PictureBox M1Averiada;
        private System.Windows.Forms.PictureBox M2Averiada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaMaquina1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaMaquina2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaALaFecha;
        private System.Windows.Forms.Label MateriaPrimaLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Maquina2Lb;
        private System.Windows.Forms.Label Maquina1Lb;
        private System.Windows.Forms.Label NoHayRepuestosLb;
        private System.Windows.Forms.Label HayRepuestosLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MateriaPrimaTextBox;
    }
}