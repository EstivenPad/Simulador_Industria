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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaMaquina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducidaMaquina2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.CantidadProducidaTotal,
            this.CantidadProducidaMaquina1,
            this.CantidadProducidaMaquina2});
            this.DataGridView.Location = new System.Drawing.Point(11, 244);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(801, 262);
            this.DataGridView.TabIndex = 0;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Location = new System.Drawing.Point(371, 95);
            this.IniciarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(56, 32);
            this.IniciarButton.TabIndex = 1;
            this.IniciarButton.Text = "Celete";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.Width = 125;
            // 
            // CantidadProducidaTotal
            // 
            this.CantidadProducidaTotal.HeaderText = "Cantidad total producida";
            this.CantidadProducidaTotal.MinimumWidth = 6;
            this.CantidadProducidaTotal.Name = "CantidadProducidaTotal";
            this.CantidadProducidaTotal.Width = 180;
            // 
            // CantidadProducidaMaquina1
            // 
            this.CantidadProducidaMaquina1.HeaderText = "Cantidad producida máquina 1";
            this.CantidadProducidaMaquina1.MinimumWidth = 6;
            this.CantidadProducidaMaquina1.Name = "CantidadProducidaMaquina1";
            this.CantidadProducidaMaquina1.Width = 220;
            // 
            // CantidadProducidaMaquina2
            // 
            this.CantidadProducidaMaquina2.HeaderText = "Cantidad producida máquina 2";
            this.CantidadProducidaMaquina2.MinimumWidth = 6;
            this.CantidadProducidaMaquina2.Name = "CantidadProducidaMaquina2";
            this.CantidadProducidaMaquina2.Width = 220;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 535);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaMaquina1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducidaMaquina2;
    }
}