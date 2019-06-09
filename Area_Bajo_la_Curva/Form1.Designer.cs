namespace Area_Bajo_la_Curva
{
    partial class AreaBajoCurva
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
            this.L_funcion = new System.Windows.Forms.Label();
            this.TB_funcion = new System.Windows.Forms.TextBox();
            this.L_fx = new System.Windows.Forms.Label();
            this.L_limite1 = new System.Windows.Forms.Label();
            this.L_limite2 = new System.Windows.Forms.Label();
            this.L_x1 = new System.Windows.Forms.Label();
            this.TB_x1 = new System.Windows.Forms.TextBox();
            this.TB_x2 = new System.Windows.Forms.TextBox();
            this.L_x2 = new System.Windows.Forms.Label();
            this.L_rectangulos = new System.Windows.Forms.Label();
            this.L_n = new System.Windows.Forms.Label();
            this.TB_n = new System.Windows.Forms.TextBox();
            this.BTN_ok = new System.Windows.Forms.Button();
            this.RB_sumasSuperiores = new System.Windows.Forms.RadioButton();
            this.RB_sumasInferiores = new System.Windows.Forms.RadioButton();
            this.RB_ambas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // L_funcion
            // 
            this.L_funcion.AutoSize = true;
            this.L_funcion.Location = new System.Drawing.Point(13, 13);
            this.L_funcion.Name = "L_funcion";
            this.L_funcion.Size = new System.Drawing.Size(119, 13);
            this.L_funcion.TabIndex = 0;
            this.L_funcion.Text = "Ecuacion de la funcion:";
            // 
            // TB_funcion
            // 
            this.TB_funcion.Location = new System.Drawing.Point(46, 29);
            this.TB_funcion.Name = "TB_funcion";
            this.TB_funcion.Size = new System.Drawing.Size(93, 20);
            this.TB_funcion.TabIndex = 1;
            // 
            // L_fx
            // 
            this.L_fx.AutoSize = true;
            this.L_fx.Location = new System.Drawing.Point(13, 33);
            this.L_fx.Name = "L_fx";
            this.L_fx.Size = new System.Drawing.Size(30, 13);
            this.L_fx.TabIndex = 2;
            this.L_fx.Text = "f(x) =";
            // 
            // L_limite1
            // 
            this.L_limite1.AutoSize = true;
            this.L_limite1.Location = new System.Drawing.Point(13, 68);
            this.L_limite1.Name = "L_limite1";
            this.L_limite1.Size = new System.Drawing.Size(164, 13);
            this.L_limite1.TabIndex = 3;
            this.L_limite1.Text = "Limite #1 (Primera Recta Vertical)";
            // 
            // L_limite2
            // 
            this.L_limite2.AutoSize = true;
            this.L_limite2.Location = new System.Drawing.Point(13, 117);
            this.L_limite2.Name = "L_limite2";
            this.L_limite2.Size = new System.Drawing.Size(172, 13);
            this.L_limite2.TabIndex = 4;
            this.L_limite2.Text = "Limite #2 (Segunda Recta Vertical)";
            // 
            // L_x1
            // 
            this.L_x1.AutoSize = true;
            this.L_x1.Location = new System.Drawing.Point(16, 87);
            this.L_x1.Name = "L_x1";
            this.L_x1.Size = new System.Drawing.Size(27, 13);
            this.L_x1.TabIndex = 5;
            this.L_x1.Text = "x1 =";
            // 
            // TB_x1
            // 
            this.TB_x1.Location = new System.Drawing.Point(46, 84);
            this.TB_x1.Name = "TB_x1";
            this.TB_x1.Size = new System.Drawing.Size(57, 20);
            this.TB_x1.TabIndex = 6;
            // 
            // TB_x2
            // 
            this.TB_x2.Location = new System.Drawing.Point(46, 133);
            this.TB_x2.Name = "TB_x2";
            this.TB_x2.Size = new System.Drawing.Size(57, 20);
            this.TB_x2.TabIndex = 8;
            // 
            // L_x2
            // 
            this.L_x2.AutoSize = true;
            this.L_x2.Location = new System.Drawing.Point(16, 136);
            this.L_x2.Name = "L_x2";
            this.L_x2.Size = new System.Drawing.Size(27, 13);
            this.L_x2.TabIndex = 7;
            this.L_x2.Text = "x2 =";
            // 
            // L_rectangulos
            // 
            this.L_rectangulos.AutoSize = true;
            this.L_rectangulos.Location = new System.Drawing.Point(16, 169);
            this.L_rectangulos.Name = "L_rectangulos";
            this.L_rectangulos.Size = new System.Drawing.Size(87, 13);
            this.L_rectangulos.TabIndex = 9;
            this.L_rectangulos.Text = "No. Rectangulos";
            // 
            // L_n
            // 
            this.L_n.AutoSize = true;
            this.L_n.Location = new System.Drawing.Point(18, 188);
            this.L_n.Name = "L_n";
            this.L_n.Size = new System.Drawing.Size(22, 13);
            this.L_n.TabIndex = 10;
            this.L_n.Text = "n =";
            // 
            // TB_n
            // 
            this.TB_n.Location = new System.Drawing.Point(46, 185);
            this.TB_n.Name = "TB_n";
            this.TB_n.Size = new System.Drawing.Size(57, 20);
            this.TB_n.TabIndex = 11;
            // 
            // BTN_ok
            // 
            this.BTN_ok.Location = new System.Drawing.Point(231, 13);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(164, 41);
            this.BTN_ok.TabIndex = 12;
            this.BTN_ok.Text = "OK";
            this.BTN_ok.UseVisualStyleBackColor = true;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // RB_sumasSuperiores
            // 
            this.RB_sumasSuperiores.AutoSize = true;
            this.RB_sumasSuperiores.Location = new System.Drawing.Point(247, 136);
            this.RB_sumasSuperiores.Name = "RB_sumasSuperiores";
            this.RB_sumasSuperiores.Size = new System.Drawing.Size(148, 17);
            this.RB_sumasSuperiores.TabIndex = 13;
            this.RB_sumasSuperiores.TabStop = true;
            this.RB_sumasSuperiores.Text = "Calcule Sumas Superiores";
            this.RB_sumasSuperiores.UseVisualStyleBackColor = true;
            // 
            // RB_sumasInferiores
            // 
            this.RB_sumasInferiores.AutoSize = true;
            this.RB_sumasInferiores.Location = new System.Drawing.Point(247, 159);
            this.RB_sumasInferiores.Name = "RB_sumasInferiores";
            this.RB_sumasInferiores.Size = new System.Drawing.Size(141, 17);
            this.RB_sumasInferiores.TabIndex = 14;
            this.RB_sumasInferiores.TabStop = true;
            this.RB_sumasInferiores.Text = "Calcule Sumas Inferiores";
            this.RB_sumasInferiores.UseVisualStyleBackColor = true;
            // 
            // RB_ambas
            // 
            this.RB_ambas.AutoSize = true;
            this.RB_ambas.Location = new System.Drawing.Point(247, 182);
            this.RB_ambas.Name = "RB_ambas";
            this.RB_ambas.Size = new System.Drawing.Size(57, 17);
            this.RB_ambas.TabIndex = 15;
            this.RB_ambas.TabStop = true;
            this.RB_ambas.Text = "Ambas";
            this.RB_ambas.UseVisualStyleBackColor = true;
            // 
            // AreaBajoCurva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 217);
            this.Controls.Add(this.RB_ambas);
            this.Controls.Add(this.RB_sumasInferiores);
            this.Controls.Add(this.RB_sumasSuperiores);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.TB_n);
            this.Controls.Add(this.L_n);
            this.Controls.Add(this.L_rectangulos);
            this.Controls.Add(this.TB_x2);
            this.Controls.Add(this.L_x2);
            this.Controls.Add(this.TB_x1);
            this.Controls.Add(this.L_x1);
            this.Controls.Add(this.L_limite2);
            this.Controls.Add(this.L_limite1);
            this.Controls.Add(this.L_fx);
            this.Controls.Add(this.TB_funcion);
            this.Controls.Add(this.L_funcion);
            this.Name = "AreaBajoCurva";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_funcion;
        private System.Windows.Forms.TextBox TB_funcion;
        private System.Windows.Forms.Label L_fx;
        private System.Windows.Forms.Label L_limite1;
        private System.Windows.Forms.Label L_limite2;
        private System.Windows.Forms.Label L_x1;
        private System.Windows.Forms.TextBox TB_x1;
        private System.Windows.Forms.TextBox TB_x2;
        private System.Windows.Forms.Label L_x2;
        private System.Windows.Forms.Label L_rectangulos;
        private System.Windows.Forms.Label L_n;
        private System.Windows.Forms.TextBox TB_n;
        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.RadioButton RB_sumasSuperiores;
        private System.Windows.Forms.RadioButton RB_sumasInferiores;
        private System.Windows.Forms.RadioButton RB_ambas;
    }
}

