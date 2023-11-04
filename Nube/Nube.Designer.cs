namespace Nube
{
    partial class Nube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nube));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.MenuArchivos = new System.Windows.Forms.Panel();
            this.btnDll = new System.Windows.Forms.Button();
            this.btnVideos = new System.Windows.Forms.Button();
            this.btnRar_Zip = new System.Windows.Forms.Button();
            this.btnProgramas = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.txtDirArchivo = new System.Windows.Forms.TextBox();
            this.btnEncontrarArchivo = new System.Windows.Forms.Button();
            this.DV_Principal = new System.Windows.Forms.DataGridView();
            this.archivo = new System.Windows.Forms.OpenFileDialog();
            this.DV_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_Descargar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MenuArchivos.SuspendLayout();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(3, 3);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(87, 21);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(579, 339);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnSubirArchivo.TabIndex = 1;
            this.btnSubirArchivo.Text = "Subir";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.BtnSubirArchivo_Click);
            // 
            // MenuArchivos
            // 
            this.MenuArchivos.BackColor = System.Drawing.Color.LightSalmon;
            this.MenuArchivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuArchivos.Controls.Add(this.btnDll);
            this.MenuArchivos.Controls.Add(this.btnVideos);
            this.MenuArchivos.Controls.Add(this.btnRar_Zip);
            this.MenuArchivos.Controls.Add(this.btnProgramas);
            this.MenuArchivos.Controls.Add(this.btnPdf);
            this.MenuArchivos.Controls.Add(this.btnOtros);
            this.MenuArchivos.Controls.Add(this.btnImagenes);
            this.MenuArchivos.Controls.Add(this.btnDocumentos);
            this.MenuArchivos.Controls.Add(this.btnAudio);
            this.MenuArchivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuArchivos.Location = new System.Drawing.Point(0, 0);
            this.MenuArchivos.Name = "MenuArchivos";
            this.MenuArchivos.Size = new System.Drawing.Size(107, 364);
            this.MenuArchivos.TabIndex = 2;
            // 
            // btnDll
            // 
            this.btnDll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(51)))));
            this.btnDll.FlatAppearance.BorderSize = 0;
            this.btnDll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDll.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDll.Location = new System.Drawing.Point(0, 111);
            this.btnDll.Name = "btnDll";
            this.btnDll.Size = new System.Drawing.Size(107, 31);
            this.btnDll.TabIndex = 5;
            this.btnDll.Text = "DLL files";
            this.btnDll.UseVisualStyleBackColor = false;
            // 
            // btnVideos
            // 
            this.btnVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnVideos.FlatAppearance.BorderSize = 0;
            this.btnVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideos.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideos.Location = new System.Drawing.Point(0, 333);
            this.btnVideos.Name = "btnVideos";
            this.btnVideos.Size = new System.Drawing.Size(107, 31);
            this.btnVideos.TabIndex = 5;
            this.btnVideos.Text = "Videos";
            this.btnVideos.UseVisualStyleBackColor = false;
            // 
            // btnRar_Zip
            // 
            this.btnRar_Zip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnRar_Zip.FlatAppearance.BorderSize = 0;
            this.btnRar_Zip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRar_Zip.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRar_Zip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRar_Zip.Location = new System.Drawing.Point(0, 296);
            this.btnRar_Zip.Name = "btnRar_Zip";
            this.btnRar_Zip.Size = new System.Drawing.Size(107, 31);
            this.btnRar_Zip.TabIndex = 5;
            this.btnRar_Zip.Text = "Rar/Zip";
            this.btnRar_Zip.UseVisualStyleBackColor = false;
            // 
            // btnProgramas
            // 
            this.btnProgramas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnProgramas.FlatAppearance.BorderSize = 0;
            this.btnProgramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramas.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProgramas.Location = new System.Drawing.Point(0, 259);
            this.btnProgramas.Name = "btnProgramas";
            this.btnProgramas.Size = new System.Drawing.Size(107, 31);
            this.btnProgramas.TabIndex = 5;
            this.btnProgramas.Text = "Programas";
            this.btnProgramas.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(51)))));
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPdf.Location = new System.Drawing.Point(0, 222);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(107, 31);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "Pdfs";
            this.btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnOtros
            // 
            this.btnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(51)))));
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtros.Location = new System.Drawing.Point(0, 185);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(107, 31);
            this.btnOtros.TabIndex = 5;
            this.btnOtros.Text = "Otros";
            this.btnOtros.UseVisualStyleBackColor = false;
            // 
            // btnImagenes
            // 
            this.btnImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
            this.btnImagenes.FlatAppearance.BorderSize = 0;
            this.btnImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagenes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImagenes.Location = new System.Drawing.Point(0, 148);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(107, 31);
            this.btnImagenes.TabIndex = 5;
            this.btnImagenes.Text = "Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = false;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(51)))));
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 74);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(107, 31);
            this.btnDocumentos.TabIndex = 5;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(51)))));
            this.btnAudio.FlatAppearance.BorderSize = 0;
            this.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudio.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAudio.Location = new System.Drawing.Point(0, 37);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(107, 31);
            this.btnAudio.TabIndex = 5;
            this.btnAudio.Text = "Audio";
            this.btnAudio.UseVisualStyleBackColor = false;
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.DarkOrange;
            this.ToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar.Controls.Add(this.btnMinimize);
            this.ToolBar.Controls.Add(this.btnExit);
            this.ToolBar.Controls.Add(this.lblBienvenida);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(107, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(559, 31);
            this.ToolBar.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(484, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 31);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(519, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTodo.Location = new System.Drawing.Point(0, 0);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(107, 31);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = false;
            // 
            // txtDirArchivo
            // 
            this.txtDirArchivo.AllowDrop = true;
            this.txtDirArchivo.Location = new System.Drawing.Point(114, 340);
            this.txtDirArchivo.Name = "txtDirArchivo";
            this.txtDirArchivo.ReadOnly = true;
            this.txtDirArchivo.Size = new System.Drawing.Size(394, 20);
            this.txtDirArchivo.TabIndex = 5;
            this.txtDirArchivo.Text = "Inserte su archivo aqui";
            // 
            // btnEncontrarArchivo
            // 
            this.btnEncontrarArchivo.Location = new System.Drawing.Point(514, 340);
            this.btnEncontrarArchivo.Name = "btnEncontrarArchivo";
            this.btnEncontrarArchivo.Size = new System.Drawing.Size(34, 20);
            this.btnEncontrarArchivo.TabIndex = 6;
            this.btnEncontrarArchivo.Text = "...";
            this.btnEncontrarArchivo.UseVisualStyleBackColor = true;
            this.btnEncontrarArchivo.Click += new System.EventHandler(this.BtnEncontrarArchivo_Click);
            // 
            // DV_Principal
            // 
            this.DV_Principal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.DV_Principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DV_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DV_Principal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DV_Nombre,
            this.DV_Tipo,
            this.DV_Peso,
            this.DV_Fecha,
            this.DV_Descargar});
            this.DV_Principal.Location = new System.Drawing.Point(107, 28);
            this.DV_Principal.Name = "DV_Principal";
            this.DV_Principal.Size = new System.Drawing.Size(558, 307);
            this.DV_Principal.TabIndex = 7;
            // 
            // archivo
            // 
            this.archivo.FileName = "openFileDialog1";
            // 
            // DV_Nombre
            // 
            this.DV_Nombre.HeaderText = "Nombre";
            this.DV_Nombre.Name = "DV_Nombre";
            this.DV_Nombre.ReadOnly = true;
            this.DV_Nombre.Width = 207;
            // 
            // DV_Tipo
            // 
            this.DV_Tipo.HeaderText = "Tipo";
            this.DV_Tipo.Name = "DV_Tipo";
            this.DV_Tipo.ReadOnly = true;
            this.DV_Tipo.Width = 35;
            // 
            // DV_Peso
            // 
            this.DV_Peso.HeaderText = "Peso";
            this.DV_Peso.Name = "DV_Peso";
            this.DV_Peso.ReadOnly = true;
            // 
            // DV_Fecha
            // 
            this.DV_Fecha.HeaderText = "Fecha";
            this.DV_Fecha.Name = "DV_Fecha";
            this.DV_Fecha.ReadOnly = true;
            this.DV_Fecha.Width = 110;
            // 
            // DV_Descargar
            // 
            this.DV_Descargar.HeaderText = "Descargar";
            this.DV_Descargar.Name = "DV_Descargar";
            this.DV_Descargar.ReadOnly = true;
            this.DV_Descargar.Text = "Descargar";
            this.DV_Descargar.Width = 65;
            // 
            // Nube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(666, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnEncontrarArchivo);
            this.Controls.Add(this.txtDirArchivo);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MenuArchivos);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.DV_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Nube_Load);
            this.MenuArchivos.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV_Principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubirArchivo;
        public System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel MenuArchivos;
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnDll;
        private System.Windows.Forms.Button btnVideos;
        private System.Windows.Forms.Button btnRar_Zip;
        private System.Windows.Forms.Button btnProgramas;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.TextBox txtDirArchivo;
        private System.Windows.Forms.Button btnEncontrarArchivo;
        private System.Windows.Forms.DataGridView DV_Principal;
        private System.Windows.Forms.OpenFileDialog archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_Fecha;
        private System.Windows.Forms.DataGridViewButtonColumn DV_Descargar;
    }
}