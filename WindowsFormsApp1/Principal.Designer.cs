namespace WindowsFormsApp1
{
    partial class Principal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.stsCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsCoordenadasDelPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdgPaletaDeColores = new System.Windows.Forms.ColorDialog();
            this.ofdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.fdgLetra = new System.Windows.Forms.FontDialog();
            this.btnColorSeleccionado = new System.Windows.Forms.Button();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.lblGrosor = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGetColor = new System.Windows.Forms.Button();
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCubeta = new System.Windows.Forms.Button();
            this.btnBrocha = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnPentagono = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPaletaDeColores = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.paintArea = new System.Windows.Forms.PictureBox();
            this.btnBotonActivo = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.stsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(973, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsCoordenadas,
            this.stsSeparator,
            this.stsCoordenadasDelPanel});
            this.stsPrincipal.Location = new System.Drawing.Point(0, 548);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(973, 25);
            this.stsPrincipal.TabIndex = 1;
            this.stsPrincipal.Text = "stsPrincipal";
            // 
            // stsCoordenadas
            // 
            this.stsCoordenadas.Name = "stsCoordenadas";
            this.stsCoordenadas.Size = new System.Drawing.Size(155, 20);
            this.stsCoordenadas.Text = "Pixeles en tiempo real";
            // 
            // stsSeparator
            // 
            this.stsSeparator.Name = "stsSeparator";
            this.stsSeparator.Size = new System.Drawing.Size(13, 20);
            this.stsSeparator.Text = "|";
            // 
            // stsCoordenadasDelPanel
            // 
            this.stsCoordenadasDelPanel.Name = "stsCoordenadasDelPanel";
            this.stsCoordenadasDelPanel.Size = new System.Drawing.Size(120, 20);
            this.stsCoordenadasDelPanel.Text = "Pixeles del panel";
            // 
            // ofdAbrirArchivo
            // 
            this.ofdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // btnColorSeleccionado
            // 
            this.btnColorSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorSeleccionado.BackColor = System.Drawing.Color.Black;
            this.btnColorSeleccionado.Location = new System.Drawing.Point(898, 40);
            this.btnColorSeleccionado.Name = "btnColorSeleccionado";
            this.btnColorSeleccionado.Size = new System.Drawing.Size(64, 64);
            this.btnColorSeleccionado.TabIndex = 2;
            this.btnColorSeleccionado.UseVisualStyleBackColor = false;
            this.btnColorSeleccionado.Click += new System.EventHandler(this.btnColorSeleccionado_Click);
            // 
            // nudGrosor
            // 
            this.nudGrosor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGrosor.Location = new System.Drawing.Point(897, 220);
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(64, 22);
            this.nudGrosor.TabIndex = 4;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.ValueChanged += new System.EventHandler(this.nudGrosor_ValueChanged);
            // 
            // lblGrosor
            // 
            this.lblGrosor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrosor.AutoSize = true;
            this.lblGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosor.Location = new System.Drawing.Point(897, 200);
            this.lblGrosor.Name = "lblGrosor";
            this.lblGrosor.Size = new System.Drawing.Size(67, 18);
            this.lblGrosor.TabIndex = 5;
            this.lblGrosor.Text = "Grosor:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnGetColor);
            this.splitContainer1.Panel1.Controls.Add(this.txtEscribir);
            this.splitContainer1.Panel1.Controls.Add(this.btnLinea);
            this.splitContainer1.Panel1.Controls.Add(this.btnCubeta);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrocha);
            this.splitContainer1.Panel1.Controls.Add(this.btnTexto);
            this.splitContainer1.Panel1.Controls.Add(this.btnTriangulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnPentagono);
            this.splitContainer1.Panel1.Controls.Add(this.btnRectangulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnCirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrador);
            this.splitContainer1.Panel1.Controls.Add(this.btnPaletaDeColores);
            this.splitContainer1.Panel1.Controls.Add(this.btnLapiz);
            this.splitContainer1.Panel1MinSize = 1;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel2.Controls.Add(this.paintArea);
            this.splitContainer1.Size = new System.Drawing.Size(880, 514);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnGetColor
            // 
            this.btnGetColor.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.colorselector;
            this.btnGetColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetColor.Location = new System.Drawing.Point(112, 364);
            this.btnGetColor.Name = "btnGetColor";
            this.btnGetColor.Size = new System.Drawing.Size(64, 64);
            this.btnGetColor.TabIndex = 12;
            this.btnGetColor.UseVisualStyleBackColor = true;
            this.btnGetColor.Click += new System.EventHandler(this.btnGetColor_Click);
            // 
            // txtEscribir
            // 
            this.txtEscribir.AccessibleDescription = "Escribe el texto aqui...";
            this.txtEscribir.Location = new System.Drawing.Point(22, 454);
            this.txtEscribir.Multiline = true;
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEscribir.Size = new System.Drawing.Size(154, 56);
            this.txtEscribir.TabIndex = 11;
            this.txtEscribir.Tag = "Escribe el texto aqui...";
            this.txtEscribir.Text = "Escribe tu texto aqui...";
            this.txtEscribir.Visible = false;
            // 
            // btnLinea
            // 
            this.btnLinea.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Line;
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinea.Location = new System.Drawing.Point(22, 364);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(64, 64);
            this.btnLinea.TabIndex = 10;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCubeta
            // 
            this.btnCubeta.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fill;
            this.btnCubeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCubeta.Location = new System.Drawing.Point(112, 292);
            this.btnCubeta.Name = "btnCubeta";
            this.btnCubeta.Size = new System.Drawing.Size(64, 64);
            this.btnCubeta.TabIndex = 9;
            this.btnCubeta.UseVisualStyleBackColor = true;
            this.btnCubeta.Click += new System.EventHandler(this.btnCubeta_Click);
            // 
            // btnBrocha
            // 
            this.btnBrocha.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Brush;
            this.btnBrocha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrocha.Location = new System.Drawing.Point(22, 292);
            this.btnBrocha.Name = "btnBrocha";
            this.btnBrocha.Size = new System.Drawing.Size(64, 64);
            this.btnBrocha.TabIndex = 8;
            this.btnBrocha.UseVisualStyleBackColor = true;
            this.btnBrocha.Click += new System.EventHandler(this.btnBrocha_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.newfont;
            this.btnTexto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTexto.Location = new System.Drawing.Point(112, 222);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(64, 64);
            this.btnTexto.TabIndex = 7;
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.triangle;
            this.btnTriangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangulo.Location = new System.Drawing.Point(22, 222);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(64, 64);
            this.btnTriangulo.TabIndex = 6;
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnPentagono
            // 
            this.btnPentagono.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pentagono;
            this.btnPentagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPentagono.Location = new System.Drawing.Point(112, 152);
            this.btnPentagono.Name = "btnPentagono";
            this.btnPentagono.Size = new System.Drawing.Size(64, 64);
            this.btnPentagono.TabIndex = 5;
            this.btnPentagono.UseVisualStyleBackColor = true;
            this.btnPentagono.Click += new System.EventHandler(this.btnPentagono_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rectangle;
            this.btnRectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangulo.Location = new System.Drawing.Point(22, 152);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(64, 64);
            this.btnRectangulo.TabIndex = 4;
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.circle;
            this.btnCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCirculo.Location = new System.Drawing.Point(112, 82);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(64, 64);
            this.btnCirculo.TabIndex = 3;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Borrador;
            this.btnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrador.Location = new System.Drawing.Point(22, 82);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(64, 64);
            this.btnBorrador.TabIndex = 2;
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPaletaDeColores
            // 
            this.btnPaletaDeColores.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.paleta;
            this.btnPaletaDeColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaletaDeColores.Location = new System.Drawing.Point(112, 12);
            this.btnPaletaDeColores.Name = "btnPaletaDeColores";
            this.btnPaletaDeColores.Size = new System.Drawing.Size(64, 64);
            this.btnPaletaDeColores.TabIndex = 1;
            this.btnPaletaDeColores.UseVisualStyleBackColor = true;
            this.btnPaletaDeColores.Click += new System.EventHandler(this.btnPaletaDeColores_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.editar;
            this.btnLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLapiz.Location = new System.Drawing.Point(22, 12);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(64, 64);
            this.btnLapiz.TabIndex = 0;
            this.btnLapiz.UseVisualStyleBackColor = true;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // paintArea
            // 
            this.paintArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintArea.BackColor = System.Drawing.Color.White;
            this.paintArea.Location = new System.Drawing.Point(4, 4);
            this.paintArea.Name = "paintArea";
            this.paintArea.Size = new System.Drawing.Size(707, 506);
            this.paintArea.TabIndex = 0;
            this.paintArea.TabStop = false;
            this.paintArea.SizeChanged += new System.EventHandler(this.paintArea_SizeChanged);
            this.paintArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseDown);
            this.paintArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseMove);
            this.paintArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseUp);
            // 
            // btnBotonActivo
            // 
            this.btnBotonActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBotonActivo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.editar;
            this.btnBotonActivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBotonActivo.Location = new System.Drawing.Point(898, 110);
            this.btnBotonActivo.Name = "btnBotonActivo";
            this.btnBotonActivo.Size = new System.Drawing.Size(64, 64);
            this.btnBotonActivo.TabIndex = 3;
            this.btnBotonActivo.UseVisualStyleBackColor = true;
            this.btnBotonActivo.Click += new System.EventHandler(this.btnBotonActivo_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 573);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblGrosor);
            this.Controls.Add(this.nudGrosor);
            this.Controls.Add(this.btnBotonActivo);
            this.Controls.Add(this.btnColorSeleccionado);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "Principal";
            this.Text = "PaintITH";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.stsPrincipal.ResumeLayout(false);
            this.stsPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel stsCoordenadas;
        private System.Windows.Forms.ToolStripStatusLabel stsCoordenadasDelPanel;
        private System.Windows.Forms.ColorDialog cdgPaletaDeColores;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivo;
        private System.Windows.Forms.SaveFileDialog sfdGuardarArchivo;
        private System.Windows.Forms.FontDialog fdgLetra;
        private System.Windows.Forms.Button btnColorSeleccionado;
        private System.Windows.Forms.Button btnBotonActivo;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.Label lblGrosor;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCubeta;
        private System.Windows.Forms.Button btnBrocha;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnPentagono;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnPaletaDeColores;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.PictureBox paintArea;
        private System.Windows.Forms.ToolStripStatusLabel stsSeparator;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.Button btnGetColor;
    }
}

