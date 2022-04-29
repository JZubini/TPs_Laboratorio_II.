namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxOperadores = new System.Windows.Forms.ComboBox();
            this.operandoUno = new System.Windows.Forms.TextBox();
            this.operandoDos = new System.Windows.Forms.TextBox();
            this.botonOperar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonBinario = new System.Windows.Forms.Button();
            this.botonDecimal = new System.Windows.Forms.Button();
            this.listBoxOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxOperadores
            // 
            this.comboBoxOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperadores.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperadores.FormattingEnabled = true;
            this.comboBoxOperadores.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperadores.Location = new System.Drawing.Point(184, 32);
            this.comboBoxOperadores.Name = "comboBoxOperadores";
            this.comboBoxOperadores.Size = new System.Drawing.Size(84, 45);
            this.comboBoxOperadores.TabIndex = 2;
            this.comboBoxOperadores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // operandoUno
            // 
            this.operandoUno.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoUno.Location = new System.Drawing.Point(15, 32);
            this.operandoUno.Name = "operandoUno";
            this.operandoUno.Size = new System.Drawing.Size(124, 43);
            this.operandoUno.TabIndex = 1;
            this.operandoUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operandoDos
            // 
            this.operandoDos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoDos.Location = new System.Drawing.Point(312, 32);
            this.operandoDos.Name = "operandoDos";
            this.operandoDos.Size = new System.Drawing.Size(124, 43);
            this.operandoDos.TabIndex = 3;
            this.operandoDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botonOperar
            // 
            this.botonOperar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonOperar.Location = new System.Drawing.Point(15, 104);
            this.botonOperar.Name = "botonOperar";
            this.botonOperar.Size = new System.Drawing.Size(124, 43);
            this.botonOperar.TabIndex = 4;
            this.botonOperar.Text = "Operar";
            this.botonOperar.UseVisualStyleBackColor = true;
            this.botonOperar.Click += new System.EventHandler(this.botonOperar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonLimpiar.Location = new System.Drawing.Point(164, 104);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(124, 43);
            this.botonLimpiar.TabIndex = 5;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonCerrar.Location = new System.Drawing.Point(312, 104);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(124, 43);
            this.botonCerrar.TabIndex = 6;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonBinario
            // 
            this.botonBinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonBinario.Location = new System.Drawing.Point(15, 172);
            this.botonBinario.Name = "botonBinario";
            this.botonBinario.Size = new System.Drawing.Size(207, 43);
            this.botonBinario.TabIndex = 7;
            this.botonBinario.Text = "Convertir a binario";
            this.botonBinario.UseVisualStyleBackColor = true;
            this.botonBinario.Click += new System.EventHandler(this.botonBinario_Click);
            // 
            // botonDecimal
            // 
            this.botonDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonDecimal.Location = new System.Drawing.Point(228, 172);
            this.botonDecimal.Name = "botonDecimal";
            this.botonDecimal.Size = new System.Drawing.Size(208, 43);
            this.botonDecimal.TabIndex = 8;
            this.botonDecimal.Text = "Convertir a decimal";
            this.botonDecimal.UseVisualStyleBackColor = true;
            this.botonDecimal.Click += new System.EventHandler(this.botonDecimal_Click);
            // 
            // listBoxOperaciones
            // 
            this.listBoxOperaciones.FormattingEnabled = true;
            this.listBoxOperaciones.ItemHeight = 15;
            this.listBoxOperaciones.Location = new System.Drawing.Point(454, 12);
            this.listBoxOperaciones.Name = "listBoxOperaciones";
            this.listBoxOperaciones.Size = new System.Drawing.Size(222, 244);
            this.listBoxOperaciones.TabIndex = 8;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 262);
            this.Controls.Add(this.listBoxOperaciones);
            this.Controls.Add(this.botonDecimal);
            this.Controls.Add(this.botonBinario);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonOperar);
            this.Controls.Add(this.operandoDos);
            this.Controls.Add(this.operandoUno);
            this.Controls.Add(this.comboBoxOperadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Julián Ignacio Zubini Mainardi del curso 2°E";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxOperadores;
        private TextBox operandoUno;
        private TextBox operandoDos;
        private Button botonOperar;
        private Button botonLimpiar;
        private Button botonCerrar;
        private Button botonBinario;
        private Button botonDecimal;
        private ListBox listBoxOperaciones;
    }
}