namespace Escuela
{
    partial class Form1
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
            Matricula = new Label();
            Nombre = new Label();
            nudSemestre = new Label();
            Grupo = new Label();
            Especialidad = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtGrupo = new TextBox();
            txtEspecialidad = new TextBox();
            dgvAlumnos = new DataGridView();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Location = new Point(35, 64);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(60, 15);
            Matricula.TabIndex = 0;
            Matricula.Text = "Matricula:";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(35, 121);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(54, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre:";
            // 
            // nudSemestre
            // 
            nudSemestre.AutoSize = true;
            nudSemestre.Location = new Point(303, 64);
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(58, 15);
            nudSemestre.TabIndex = 2;
            nudSemestre.Text = "Semestre:";
            nudSemestre.Click += label2_Click;
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(303, 121);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(43, 15);
            Grupo.TabIndex = 3;
            Grupo.Text = "Grupo:";
            // 
            // Especialidad
            // 
            Especialidad.AutoSize = true;
            Especialidad.Location = new Point(303, 195);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(75, 15);
            Especialidad.TabIndex = 4;
            Especialidad.Text = "Especialidad:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(101, 60);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(352, 113);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(100, 23);
            txtGrupo.TabIndex = 7;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(381, 187);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 8;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(42, 260);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.Size = new Size(706, 172);
            dgvAlumnos.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(587, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(587, 121);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(587, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(361, 56);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtGrupo);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Controls.Add(Especialidad);
            Controls.Add(Grupo);
            Controls.Add(nudSemestre);
            Controls.Add(Nombre);
            Controls.Add(Matricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Matricula;
        private Label Nombre;
        private Label nudSemestre;
        private Label Grupo;
        private Label Especialidad;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtGrupo;
        private TextBox txtEspecialidad;
        private DataGridView dgvAlumnos;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private NumericUpDown numericUpDown1;
    }
}
