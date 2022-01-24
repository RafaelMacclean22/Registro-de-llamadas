
namespace Registro_de_llamadas
{
    partial class frmLlamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLlamadas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmInternacional = new System.Windows.Forms.RadioButton();
            this.rbmNacional = new System.Windows.Forms.RadioButton();
            this.rbfInternacional = new System.Windows.Forms.RadioButton();
            this.rbfNacional = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvLlamadas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsCancelar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(492, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de llamadas";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(91, 39);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(291, 39);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(150, 20);
            this.txtMinutos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbmInternacional);
            this.groupBox1.Controls.Add(this.rbmNacional);
            this.groupBox1.Controls.Add(this.rbfInternacional);
            this.groupBox1.Controls.Add(this.rbfNacional);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(43, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de llamadas";
            // 
            // rbmInternacional
            // 
            this.rbmInternacional.AutoSize = true;
            this.rbmInternacional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbmInternacional.Location = new System.Drawing.Point(420, 32);
            this.rbmInternacional.Name = "rbmInternacional";
            this.rbmInternacional.Size = new System.Drawing.Size(114, 17);
            this.rbmInternacional.TabIndex = 3;
            this.rbmInternacional.Text = "Movil Internacional";
            this.rbmInternacional.UseVisualStyleBackColor = true;
            // 
            // rbmNacional
            // 
            this.rbmNacional.AutoSize = true;
            this.rbmNacional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbmNacional.Location = new System.Drawing.Point(295, 32);
            this.rbmNacional.Name = "rbmNacional";
            this.rbmNacional.Size = new System.Drawing.Size(95, 17);
            this.rbmNacional.TabIndex = 2;
            this.rbmNacional.Text = "Movil Nacional";
            this.rbmNacional.UseVisualStyleBackColor = true;
            // 
            // rbfInternacional
            // 
            this.rbfInternacional.AutoSize = true;
            this.rbfInternacional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbfInternacional.Location = new System.Drawing.Point(163, 32);
            this.rbfInternacional.Name = "rbfInternacional";
            this.rbfInternacional.Size = new System.Drawing.Size(105, 17);
            this.rbfInternacional.TabIndex = 1;
            this.rbfInternacional.Text = "Fijo Internacional";
            this.rbfInternacional.UseVisualStyleBackColor = true;
            // 
            // rbfNacional
            // 
            this.rbfNacional.AutoSize = true;
            this.rbfNacional.BackColor = System.Drawing.Color.Transparent;
            this.rbfNacional.Checked = true;
            this.rbfNacional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbfNacional.ImageKey = "(ninguno)";
            this.rbfNacional.Location = new System.Drawing.Point(48, 32);
            this.rbfNacional.Name = "rbfNacional";
            this.rbfNacional.Size = new System.Drawing.Size(86, 17);
            this.rbfNacional.TabIndex = 0;
            this.rbfNacional.TabStop = true;
            this.rbfNacional.Text = "Fijo Nacional";
            this.rbfNacional.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(88, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(288, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Minutos:";
            // 
            // lvLlamadas
            // 
            this.lvLlamadas.BackColor = System.Drawing.SystemColors.InfoText;
            this.lvLlamadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLlamadas.ForeColor = System.Drawing.Color.GhostWhite;
            this.lvLlamadas.GridLines = true;
            this.lvLlamadas.HideSelection = false;
            this.lvLlamadas.Location = new System.Drawing.Point(32, 188);
            this.lvLlamadas.Name = "lvLlamadas";
            this.lvLlamadas.Size = new System.Drawing.Size(655, 169);
            this.lvLlamadas.TabIndex = 6;
            this.lvLlamadas.UseCompatibleStateImageBehavior = false;
            this.lvLlamadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° de Telefono";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo de Llamada";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Minutos";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Import";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descuent.";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Metodo a pagar";
            this.columnHeader6.Width = 335;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Maroon;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsRegistrar,
            this.toolStripButton2,
            this.tsCancelar,
            this.toolStripButton3,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Registrar Llamadas";
            // 
            // tsRegistrar
            // 
            this.tsRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsRegistrar.Name = "tsRegistrar";
            this.tsRegistrar.Size = new System.Drawing.Size(101, 22);
            this.tsRegistrar.Text = "Registrar Llamada";
            this.tsRegistrar.Click += new System.EventHandler(this.tsRegistrar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // tsCancelar
            // 
            this.tsCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsCancelar.Name = "tsCancelar";
            this.tsCancelar.Size = new System.Drawing.Size(96, 22);
            this.tsCancelar.Text = "Cancelar registro";
            this.tsCancelar.Click += new System.EventHandler(this.tsCancelar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "Salir";
            this.toolStripLabel3.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(853, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 64);
            this.panel1.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(642, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 25);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "lblFecha";
            this.lblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // frmLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvLlamadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmLlamadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Llamadas";
            this.Load += new System.EventHandler(this.FrmLlamadas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmInternacional;
        private System.Windows.Forms.RadioButton rbmNacional;
        private System.Windows.Forms.RadioButton rbfInternacional;
        private System.Windows.Forms.RadioButton rbfNacional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvLlamadas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tsRegistrar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel tsCancelar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
    }
}

