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
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.CantidadProducida});
            this.DataGridView.Location = new System.Drawing.Point(23, 114);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(863, 329);
            this.DataGridView.TabIndex = 0;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.Width = 125;
            // 
            // CantidadProducida
            // 
            this.CantidadProducida.HeaderText = "Cantidad producida";
            this.CantidadProducida.MinimumWidth = 6;
            this.CantidadProducida.Name = "CantidadProducida";
            this.CantidadProducida.Width = 200;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Location = new System.Drawing.Point(36, 44);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(75, 23);
            this.IniciarButton.TabIndex = 1;
            this.IniciarButton.Text = "button1";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 659);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.DataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducida;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Timer Timer;
    }
}