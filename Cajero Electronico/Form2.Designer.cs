namespace Cajero_Electronico
{
    partial class Form2
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
            this.Dinero = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Cuenta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Deposito = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Retiro_Rapido = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Estado_De_Cuenta = new System.Windows.Forms.Button();
            this.Btn_Movimientos_Recientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_principal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Movimientos_Recientes = new System.Windows.Forms.Panel();
            this.ListaMovimientos = new System.Windows.Forms.ListView();
            this.ColumnaMovimientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.Estado_de_Cuenta = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Nombre2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Retiro_Rapido = new System.Windows.Forms.Panel();
            this.Retirar = new System.Windows.Forms.Button();
            this.RetirarX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Retirar100 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Retirar50 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Retirar20 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Deposito_Rapido = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.NCuentaDestinatario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CantidadDeposito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Panel_principal.SuspendLayout();
            this.Movimientos_Recientes.SuspendLayout();
            this.Estado_de_Cuenta.SuspendLayout();
            this.Retiro_Rapido.SuspendLayout();
            this.Deposito_Rapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dinero
            // 
            this.Dinero.AutoSize = true;
            this.Dinero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dinero.Location = new System.Drawing.Point(195, 144);
            this.Dinero.Name = "Dinero";
            this.Dinero.Size = new System.Drawing.Size(54, 19);
            this.Dinero.TabIndex = 7;
            this.Dinero.Text = "Dinero";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nombre.Location = new System.Drawing.Point(200, 142);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(219, 28);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre de Usuario";
            // 
            // Cuenta
            // 
            this.Cuenta.AutoSize = true;
            this.Cuenta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cuenta.Location = new System.Drawing.Point(195, 106);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(135, 19);
            this.Cuenta.TabIndex = 5;
            this.Cuenta.Text = "Número de Cuenta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 53);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.Deposito);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Btn_Retiro_Rapido);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Btn_Estado_De_Cuenta);
            this.panel2.Controls.Add(this.Btn_Movimientos_Recientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 367);
            this.panel2.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Location = new System.Drawing.Point(0, 226);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 27);
            this.panel9.TabIndex = 30;
            // 
            // Deposito
            // 
            this.Deposito.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Deposito.FlatAppearance.BorderSize = 0;
            this.Deposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposito.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Deposito.Location = new System.Drawing.Point(5, 226);
            this.Deposito.Name = "Deposito";
            this.Deposito.Size = new System.Drawing.Size(147, 27);
            this.Deposito.TabIndex = 29;
            this.Deposito.Text = "Deposito Rápido";
            this.Deposito.UseVisualStyleBackColor = false;
            this.Deposito.Click += new System.EventHandler(this.Deposito_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 334);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 36);
            this.button5.TabIndex = 16;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 80);
            this.label1.TabIndex = 10;
            this.label1.Text = "Banco Central";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(0, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 27);
            this.panel5.TabIndex = 15;
            // 
            // Btn_Retiro_Rapido
            // 
            this.Btn_Retiro_Rapido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Retiro_Rapido.FlatAppearance.BorderSize = 0;
            this.Btn_Retiro_Rapido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Retiro_Rapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retiro_Rapido.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retiro_Rapido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Retiro_Rapido.Location = new System.Drawing.Point(5, 193);
            this.Btn_Retiro_Rapido.Name = "Btn_Retiro_Rapido";
            this.Btn_Retiro_Rapido.Size = new System.Drawing.Size(147, 27);
            this.Btn_Retiro_Rapido.TabIndex = 14;
            this.Btn_Retiro_Rapido.Text = "Retiro Rápido";
            this.Btn_Retiro_Rapido.UseVisualStyleBackColor = false;
            this.Btn_Retiro_Rapido.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 27);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 27);
            this.panel3.TabIndex = 13;
            // 
            // Btn_Estado_De_Cuenta
            // 
            this.Btn_Estado_De_Cuenta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Estado_De_Cuenta.FlatAppearance.BorderSize = 0;
            this.Btn_Estado_De_Cuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Estado_De_Cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estado_De_Cuenta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estado_De_Cuenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Estado_De_Cuenta.Location = new System.Drawing.Point(3, 127);
            this.Btn_Estado_De_Cuenta.Name = "Btn_Estado_De_Cuenta";
            this.Btn_Estado_De_Cuenta.Size = new System.Drawing.Size(147, 27);
            this.Btn_Estado_De_Cuenta.TabIndex = 12;
            this.Btn_Estado_De_Cuenta.Text = "Estado de Cuenta";
            this.Btn_Estado_De_Cuenta.UseVisualStyleBackColor = false;
            this.Btn_Estado_De_Cuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Movimientos_Recientes
            // 
            this.Btn_Movimientos_Recientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Movimientos_Recientes.FlatAppearance.BorderSize = 0;
            this.Btn_Movimientos_Recientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Movimientos_Recientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Movimientos_Recientes.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Movimientos_Recientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Movimientos_Recientes.Location = new System.Drawing.Point(5, 160);
            this.Btn_Movimientos_Recientes.Name = "Btn_Movimientos_Recientes";
            this.Btn_Movimientos_Recientes.Size = new System.Drawing.Size(147, 27);
            this.Btn_Movimientos_Recientes.TabIndex = 12;
            this.Btn_Movimientos_Recientes.Text = "Movimientos Recientes";
            this.Btn_Movimientos_Recientes.UseVisualStyleBackColor = false;
            this.Btn_Movimientos_Recientes.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(143, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hola";
            // 
            // Panel_principal
            // 
            this.Panel_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.Panel_principal.Controls.Add(this.label3);
            this.Panel_principal.Controls.Add(this.label2);
            this.Panel_principal.Controls.Add(this.Nombre);
            this.Panel_principal.Location = new System.Drawing.Point(475, 71);
            this.Panel_principal.Name = "Panel_principal";
            this.Panel_principal.Size = new System.Drawing.Size(178, 93);
            this.Panel_principal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(68, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecciona la consulta que desees realizar en el menú lateral";
            // 
            // Movimientos_Recientes
            // 
            this.Movimientos_Recientes.Controls.Add(this.ListaMovimientos);
            this.Movimientos_Recientes.Controls.Add(this.label8);
            this.Movimientos_Recientes.Location = new System.Drawing.Point(496, 185);
            this.Movimientos_Recientes.Name = "Movimientos_Recientes";
            this.Movimientos_Recientes.Size = new System.Drawing.Size(157, 87);
            this.Movimientos_Recientes.TabIndex = 13;
            this.Movimientos_Recientes.Visible = false;
            // 
            // ListaMovimientos
            // 
            this.ListaMovimientos.AutoArrange = false;
            this.ListaMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaMovimientos});
            this.ListaMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ListaMovimientos.FullRowSelect = true;
            this.ListaMovimientos.GridLines = true;
            this.ListaMovimientos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListaMovimientos.HideSelection = false;
            this.ListaMovimientos.LabelWrap = false;
            this.ListaMovimientos.Location = new System.Drawing.Point(52, 100);
            this.ListaMovimientos.Name = "ListaMovimientos";
            this.ListaMovimientos.Size = new System.Drawing.Size(413, 233);
            this.ListaMovimientos.TabIndex = 15;
            this.ListaMovimientos.UseCompatibleStateImageBehavior = false;
            this.ListaMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaMovimientos
            // 
            this.ColumnaMovimientos.Text = "Movimientos";
            this.ColumnaMovimientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnaMovimientos.Width = 300;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(23, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Movimientos Recientes";
            // 
            // Estado_de_Cuenta
            // 
            this.Estado_de_Cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.Estado_de_Cuenta.Controls.Add(this.label7);
            this.Estado_de_Cuenta.Controls.Add(this.Nombre2);
            this.Estado_de_Cuenta.Controls.Add(this.label6);
            this.Estado_de_Cuenta.Controls.Add(this.label5);
            this.Estado_de_Cuenta.Controls.Add(this.label4);
            this.Estado_de_Cuenta.Controls.Add(this.Cuenta);
            this.Estado_de_Cuenta.Controls.Add(this.Dinero);
            this.Estado_de_Cuenta.Location = new System.Drawing.Point(479, 285);
            this.Estado_de_Cuenta.Name = "Estado_de_Cuenta";
            this.Estado_de_Cuenta.Size = new System.Drawing.Size(200, 100);
            this.Estado_de_Cuenta.TabIndex = 13;
            this.Estado_de_Cuenta.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(21, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado de Cuenta";
            // 
            // Nombre2
            // 
            this.Nombre2.AutoSize = true;
            this.Nombre2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nombre2.Location = new System.Drawing.Point(195, 182);
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Size = new System.Drawing.Size(65, 19);
            this.Nombre2.TabIndex = 11;
            this.Nombre2.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(43, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Titular de la Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(47, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo de la Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(43, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de Cuenta:";
            // 
            // Retiro_Rapido
            // 
            this.Retiro_Rapido.Controls.Add(this.Retirar);
            this.Retiro_Rapido.Controls.Add(this.RetirarX);
            this.Retiro_Rapido.Controls.Add(this.label11);
            this.Retiro_Rapido.Controls.Add(this.label10);
            this.Retiro_Rapido.Controls.Add(this.panel8);
            this.Retiro_Rapido.Controls.Add(this.Retirar100);
            this.Retiro_Rapido.Controls.Add(this.panel7);
            this.Retiro_Rapido.Controls.Add(this.Retirar50);
            this.Retiro_Rapido.Controls.Add(this.panel6);
            this.Retiro_Rapido.Controls.Add(this.Retirar20);
            this.Retiro_Rapido.Controls.Add(this.label9);
            this.Retiro_Rapido.Location = new System.Drawing.Point(279, 71);
            this.Retiro_Rapido.Name = "Retiro_Rapido";
            this.Retiro_Rapido.Size = new System.Drawing.Size(170, 93);
            this.Retiro_Rapido.TabIndex = 14;
            this.Retiro_Rapido.Visible = false;
            // 
            // Retirar
            // 
            this.Retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(200)))));
            this.Retirar.FlatAppearance.BorderSize = 0;
            this.Retirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retirar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.Retirar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Retirar.Location = new System.Drawing.Point(308, 283);
            this.Retirar.Name = "Retirar";
            this.Retirar.Size = new System.Drawing.Size(93, 26);
            this.Retirar.TabIndex = 25;
            this.Retirar.Text = "Siguiente";
            this.Retirar.UseVisualStyleBackColor = false;
            this.Retirar.Click += new System.EventHandler(this.Retirar_Click);
            // 
            // RetirarX
            // 
            this.RetirarX.Location = new System.Drawing.Point(293, 257);
            this.RetirarX.MaxLength = 5;
            this.RetirarX.Name = "RetirarX";
            this.RetirarX.Size = new System.Drawing.Size(108, 20);
            this.RetirarX.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(79, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Digite la cantidad a retirar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(46, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "Retirar otra cantidad:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(83, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 27);
            this.panel8.TabIndex = 21;
            // 
            // Retirar100
            // 
            this.Retirar100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(150)))));
            this.Retirar100.FlatAppearance.BorderSize = 0;
            this.Retirar100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Retirar100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retirar100.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Retirar100.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Retirar100.Location = new System.Drawing.Point(88, 160);
            this.Retirar100.Name = "Retirar100";
            this.Retirar100.Size = new System.Drawing.Size(147, 27);
            this.Retirar100.TabIndex = 20;
            this.Retirar100.Text = "Retirar $100";
            this.Retirar100.UseVisualStyleBackColor = false;
            this.Retirar100.Click += new System.EventHandler(this.Retirar100_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Location = new System.Drawing.Point(83, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 27);
            this.panel7.TabIndex = 19;
            // 
            // Retirar50
            // 
            this.Retirar50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(182)))));
            this.Retirar50.FlatAppearance.BorderSize = 0;
            this.Retirar50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Retirar50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retirar50.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Retirar50.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Retirar50.Location = new System.Drawing.Point(88, 127);
            this.Retirar50.Name = "Retirar50";
            this.Retirar50.Size = new System.Drawing.Size(147, 27);
            this.Retirar50.TabIndex = 18;
            this.Retirar50.Text = "Retirar $50";
            this.Retirar50.UseVisualStyleBackColor = false;
            this.Retirar50.Click += new System.EventHandler(this.Retirar50_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(83, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 27);
            this.panel6.TabIndex = 17;
            // 
            // Retirar20
            // 
            this.Retirar20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(200)))));
            this.Retirar20.FlatAppearance.BorderSize = 0;
            this.Retirar20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Retirar20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retirar20.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Retirar20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Retirar20.Location = new System.Drawing.Point(88, 94);
            this.Retirar20.Name = "Retirar20";
            this.Retirar20.Size = new System.Drawing.Size(147, 27);
            this.Retirar20.TabIndex = 16;
            this.Retirar20.Text = "Retirar $20";
            this.Retirar20.UseVisualStyleBackColor = false;
            this.Retirar20.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(21, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Retiro Rápido";
            // 
            // Deposito_Rapido
            // 
            this.Deposito_Rapido.Controls.Add(this.label13);
            this.Deposito_Rapido.Controls.Add(this.NCuentaDestinatario);
            this.Deposito_Rapido.Controls.Add(this.button1);
            this.Deposito_Rapido.Controls.Add(this.CantidadDeposito);
            this.Deposito_Rapido.Controls.Add(this.label12);
            this.Deposito_Rapido.Controls.Add(this.label14);
            this.Deposito_Rapido.Location = new System.Drawing.Point(305, 198);
            this.Deposito_Rapido.Name = "Deposito_Rapido";
            this.Deposito_Rapido.Size = new System.Drawing.Size(120, 84);
            this.Deposito_Rapido.TabIndex = 26;
            this.Deposito_Rapido.Visible = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(26, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 50);
            this.label13.TabIndex = 28;
            this.label13.Text = "Digite el número de cuenta del destinatario:";
            // 
            // NCuentaDestinatario
            // 
            this.NCuentaDestinatario.Location = new System.Drawing.Point(265, 149);
            this.NCuentaDestinatario.MaxLength = 6;
            this.NCuentaDestinatario.Name = "NCuentaDestinatario";
            this.NCuentaDestinatario.Size = new System.Drawing.Size(108, 20);
            this.NCuentaDestinatario.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(280, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CantidadDeposito
            // 
            this.CantidadDeposito.Location = new System.Drawing.Point(265, 99);
            this.CantidadDeposito.MaxLength = 5;
            this.CantidadDeposito.Name = "CantidadDeposito";
            this.CantidadDeposito.Size = new System.Drawing.Size(108, 20);
            this.CantidadDeposito.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Digite la cantidad a depositar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(21, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "Deposito Rápido";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.Deposito_Rapido);
            this.Controls.Add(this.Movimientos_Recientes);
            this.Controls.Add(this.Panel_principal);
            this.Controls.Add(this.Retiro_Rapido);
            this.Controls.Add(this.Estado_de_Cuenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.Panel_principal.ResumeLayout(false);
            this.Panel_principal.PerformLayout();
            this.Movimientos_Recientes.ResumeLayout(false);
            this.Movimientos_Recientes.PerformLayout();
            this.Estado_de_Cuenta.ResumeLayout(false);
            this.Estado_de_Cuenta.PerformLayout();
            this.Retiro_Rapido.ResumeLayout(false);
            this.Retiro_Rapido.PerformLayout();
            this.Deposito_Rapido.ResumeLayout(false);
            this.Deposito_Rapido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Dinero;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Cuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_Retiro_Rapido;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Estado_De_Cuenta;
        private System.Windows.Forms.Button Btn_Movimientos_Recientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_principal;
        private System.Windows.Forms.Panel Estado_de_Cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nombre2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Movimientos_Recientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Retiro_Rapido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Retirar20;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Retirar100;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Retirar50;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RetirarX;
        private System.Windows.Forms.Button Retirar;
        private System.Windows.Forms.ListView ListaMovimientos;
        private System.Windows.Forms.ColumnHeader ColumnaMovimientos;
        private System.Windows.Forms.Panel Deposito_Rapido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CantidadDeposito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NCuentaDestinatario;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Deposito;
    }
}