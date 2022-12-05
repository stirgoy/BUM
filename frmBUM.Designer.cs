namespace BUM
{
    partial class frmBUM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUM));
            this.lstJuegos = new System.Windows.Forms.ListView();
            this.colJuego = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSaveFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnadirJuego = new System.Windows.Forms.Button();
            this.btnBorrarJuego = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.txtNombreJuego = new System.Windows.Forms.TextBox();
            this.LstSaves = new System.Windows.Forms.ListBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnBorrarSave = new System.Windows.Forms.Button();
            this.btnAnadirSave = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnAbrirUbicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstJuegos
            // 
            this.lstJuegos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstJuegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstJuegos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJuego,
            this.colSaveFolder});
            this.lstJuegos.FullRowSelect = true;
            this.lstJuegos.GridLines = true;
            this.lstJuegos.HideSelection = false;
            this.lstJuegos.LabelWrap = false;
            this.lstJuegos.Location = new System.Drawing.Point(12, 12);
            this.lstJuegos.MultiSelect = false;
            this.lstJuegos.Name = "lstJuegos";
            this.lstJuegos.Size = new System.Drawing.Size(581, 148);
            this.lstJuegos.TabIndex = 0;
            this.lstJuegos.UseCompatibleStateImageBehavior = false;
            this.lstJuegos.View = System.Windows.Forms.View.Details;
            this.lstJuegos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstJuegos_MouseClick);
            // 
            // colJuego
            // 
            this.colJuego.Text = "Juego";
            this.colJuego.Width = 126;
            // 
            // colSaveFolder
            // 
            this.colSaveFolder.Text = "Carpeta saves";
            this.colSaveFolder.Width = 450;
            // 
            // btnAnadirJuego
            // 
            this.btnAnadirJuego.Location = new System.Drawing.Point(238, 164);
            this.btnAnadirJuego.Name = "btnAnadirJuego";
            this.btnAnadirJuego.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirJuego.TabIndex = 1;
            this.btnAnadirJuego.Text = "Añadir";
            this.btnAnadirJuego.UseVisualStyleBackColor = true;
            this.btnAnadirJuego.Click += new System.EventHandler(this.btnAnadirJuego_Click);
            // 
            // btnBorrarJuego
            // 
            this.btnBorrarJuego.Location = new System.Drawing.Point(518, 164);
            this.btnBorrarJuego.Name = "btnBorrarJuego";
            this.btnBorrarJuego.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarJuego.TabIndex = 2;
            this.btnBorrarJuego.Text = "Borrar";
            this.btnBorrarJuego.UseVisualStyleBackColor = true;
            this.btnBorrarJuego.Click += new System.EventHandler(this.btnBorrarJuego_Click);
            // 
            // FBD
            // 
            this.FBD.Description = "Selecciona la carpeta de saves";
            this.FBD.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FBD.ShowNewFolderButton = false;
            // 
            // txtNombreJuego
            // 
            this.txtNombreJuego.Location = new System.Drawing.Point(12, 166);
            this.txtNombreJuego.Name = "txtNombreJuego";
            this.txtNombreJuego.Size = new System.Drawing.Size(220, 20);
            this.txtNombreJuego.TabIndex = 3;
            // 
            // LstSaves
            // 
            this.LstSaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstSaves.FormattingEnabled = true;
            this.LstSaves.Location = new System.Drawing.Point(12, 217);
            this.LstSaves.Name = "LstSaves";
            this.LstSaves.Size = new System.Drawing.Size(175, 119);
            this.LstSaves.TabIndex = 4;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(12, 345);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(94, 20);
            this.txtSave.TabIndex = 7;
            // 
            // btnBorrarSave
            // 
            this.btnBorrarSave.Location = new System.Drawing.Point(193, 217);
            this.btnBorrarSave.Name = "btnBorrarSave";
            this.btnBorrarSave.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarSave.TabIndex = 6;
            this.btnBorrarSave.Text = "Borrar";
            this.btnBorrarSave.UseVisualStyleBackColor = true;
            this.btnBorrarSave.Click += new System.EventHandler(this.btnBorrarSave_Click);
            // 
            // btnAnadirSave
            // 
            this.btnAnadirSave.Location = new System.Drawing.Point(112, 343);
            this.btnAnadirSave.Name = "btnAnadirSave";
            this.btnAnadirSave.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirSave.TabIndex = 5;
            this.btnAnadirSave.Text = "Añadir";
            this.btnAnadirSave.UseVisualStyleBackColor = true;
            this.btnAnadirSave.Click += new System.EventHandler(this.btnAnadirSave_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(193, 313);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnAbrirUbicacion
            // 
            this.btnAbrirUbicacion.Location = new System.Drawing.Point(319, 164);
            this.btnAbrirUbicacion.Name = "btnAbrirUbicacion";
            this.btnAbrirUbicacion.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirUbicacion.TabIndex = 9;
            this.btnAbrirUbicacion.Text = "Abrir carpeta";
            this.btnAbrirUbicacion.UseVisualStyleBackColor = true;
            this.btnAbrirUbicacion.Click += new System.EventHandler(this.btnAbrirUbicacion_Click);
            // 
            // frmBUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.Controls.Add(this.btnAbrirUbicacion);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnBorrarSave);
            this.Controls.Add(this.btnAnadirSave);
            this.Controls.Add(this.LstSaves);
            this.Controls.Add(this.txtNombreJuego);
            this.Controls.Add(this.btnBorrarJuego);
            this.Controls.Add(this.btnAnadirJuego);
            this.Controls.Add(this.lstJuegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBUM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstJuegos;
        private System.Windows.Forms.ColumnHeader colJuego;
        private System.Windows.Forms.ColumnHeader colSaveFolder;
        private System.Windows.Forms.Button btnAnadirJuego;
        private System.Windows.Forms.Button btnBorrarJuego;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox txtNombreJuego;
        private System.Windows.Forms.ListBox LstSaves;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnBorrarSave;
        private System.Windows.Forms.Button btnAnadirSave;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnAbrirUbicacion;
    }
}

