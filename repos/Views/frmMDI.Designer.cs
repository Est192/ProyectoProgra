﻿namespace InvSis.Views
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            splitMDI = new SplitContainer();
            groupMDI1 = new GroupBox();
            btnRegMov = new Button();
            btnClose = new Button();
            btnCambiarUsuario = new Button();
            btnAPI = new Button();
            btnRepInv = new Button();
            btnRepAud = new Button();
            btnGesRoles = new Button();
            btnAdmUsr = new Button();
            btnAdmProd = new Button();
            lblBienvenida = new Label();
            btnGestionarPermisos = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMDI).BeginInit();
            splitMDI.Panel1.SuspendLayout();
            splitMDI.Panel2.SuspendLayout();
            splitMDI.SuspendLayout();
            groupMDI1.SuspendLayout();
            SuspendLayout();
            // 
            // splitMDI
            // 
            splitMDI.Dock = DockStyle.Fill;
            splitMDI.Location = new Point(0, 0);
            splitMDI.Name = "splitMDI";
            // 
            // splitMDI.Panel1
            // 
            splitMDI.Panel1.Controls.Add(groupMDI1);
            splitMDI.Panel1.Controls.Add(btnClose);
            // 
            // splitMDI.Panel2
            // 
            splitMDI.Panel2.AutoScroll = true;
            splitMDI.Panel2.BackColor = Color.Transparent;
            splitMDI.Panel2.BackgroundImage = Properties.Resources.inventario_e1548898364548_Photoroom;
            splitMDI.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitMDI.Panel2.Controls.Add(lblBienvenida);
            splitMDI.Size = new Size(1666, 906);
            splitMDI.SplitterDistance = 315;
            splitMDI.TabIndex = 0;
            // 
            // groupMDI1
            // 
            groupMDI1.Controls.Add(btnGestionarPermisos);
            groupMDI1.Controls.Add(btnCambiarUsuario);
            groupMDI1.Controls.Add(btnRegMov);
            groupMDI1.Controls.Add(btnAPI);
            groupMDI1.Controls.Add(btnRepInv);
            groupMDI1.Controls.Add(btnRepAud);
            groupMDI1.Controls.Add(btnGesRoles);
            groupMDI1.Controls.Add(btnAdmUsr);
            groupMDI1.Controls.Add(btnAdmProd);
            groupMDI1.Location = new Point(3, 2);
            groupMDI1.Margin = new Padding(3, 2, 3, 2);
            groupMDI1.Name = "groupMDI1";
            groupMDI1.Padding = new Padding(3, 2, 3, 2);
            groupMDI1.Size = new Size(309, 807);
            groupMDI1.TabIndex = 0;
            groupMDI1.TabStop = false;
            // 
            // btnRegMov
            // 
            btnRegMov.BackColor = Color.FromArgb(230, 242, 248);
            btnRegMov.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegMov.Image = Properties.Resources._9068689_cycle_movement_icon;
            btnRegMov.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegMov.Location = new Point(-3, 354);
            btnRegMov.Margin = new Padding(3, 2, 3, 2);
            btnRegMov.Name = "btnRegMov";
            btnRegMov.Size = new Size(312, 86);
            btnRegMov.TabIndex = 7;
            btnRegMov.Text = "Registrar Movimientos";
            btnRegMov.TextAlign = ContentAlignment.MiddleRight;
            btnRegMov.UseVisualStyleBackColor = false;
            btnRegMov.Click += btnRegMov_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.PeachPuff;
            btnClose.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources._392517_close_delete_remove_icon;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(3, 806);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(312, 86);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cerrar Ventanas";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.BackColor = Color.FromArgb(230, 242, 248);
            btnCambiarUsuario.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarUsuario.Image = Properties.Resources._8673648_ic_fluent_people_swap_filled_icon;
            btnCambiarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiarUsuario.Location = new Point(-3, 714);
            btnCambiarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(312, 86);
            btnCambiarUsuario.TabIndex = 0;
            btnCambiarUsuario.Text = "Cambio de\r\nUsuario";
            btnCambiarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnCambiarUsuario.UseVisualStyleBackColor = false;
            btnCambiarUsuario.Click += btnCambiarUsuario_Click;
            // 
            // btnAPI
            // 
            btnAPI.BackColor = Color.FromArgb(230, 242, 248);
            btnAPI.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAPI.Image = Properties.Resources._103289_api_icon;
            btnAPI.ImageAlign = ContentAlignment.MiddleLeft;
            btnAPI.Location = new Point(-3, 624);
            btnAPI.Margin = new Padding(3, 2, 3, 2);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new Size(312, 86);
            btnAPI.TabIndex = 5;
            btnAPI.Text = "API";
            btnAPI.TextAlign = ContentAlignment.MiddleRight;
            btnAPI.UseVisualStyleBackColor = false;
            btnAPI.Click += btnAPI_Click;
            // 
            // btnRepInv
            // 
            btnRepInv.BackColor = Color.FromArgb(230, 242, 248);
            btnRepInv.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRepInv.Image = Properties.Resources._4295569_bulleted_close_list_catalogue_checklist_icon;
            btnRepInv.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepInv.Location = new Point(-3, 444);
            btnRepInv.Margin = new Padding(3, 2, 3, 2);
            btnRepInv.Name = "btnRepInv";
            btnRepInv.Size = new Size(312, 86);
            btnRepInv.TabIndex = 4;
            btnRepInv.Text = "Reporte de\r\nInventario";
            btnRepInv.TextAlign = ContentAlignment.MiddleRight;
            btnRepInv.UseVisualStyleBackColor = false;
            btnRepInv.Click += btnRepInv_Click;
            // 
            // btnRepAud
            // 
            btnRepAud.BackColor = Color.FromArgb(230, 242, 248);
            btnRepAud.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRepAud.Image = Properties.Resources._9044242_cloud_auditing_icon;
            btnRepAud.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepAud.Location = new Point(-3, 534);
            btnRepAud.Margin = new Padding(3, 2, 3, 2);
            btnRepAud.Name = "btnRepAud";
            btnRepAud.Size = new Size(312, 86);
            btnRepAud.TabIndex = 3;
            btnRepAud.Text = "Reportes de Auditoría";
            btnRepAud.TextAlign = ContentAlignment.MiddleRight;
            btnRepAud.UseVisualStyleBackColor = false;
            btnRepAud.Click += btnRepAud_Click;
            // 
            // btnGesRoles
            // 
            btnGesRoles.BackColor = Color.FromArgb(230, 242, 248);
            btnGesRoles.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGesRoles.Image = Properties.Resources._7352780_theater_masks_roles_artists_icon;
            btnGesRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnGesRoles.Location = new Point(-3, 264);
            btnGesRoles.Margin = new Padding(3, 2, 3, 2);
            btnGesRoles.Name = "btnGesRoles";
            btnGesRoles.Size = new Size(312, 86);
            btnGesRoles.TabIndex = 2;
            btnGesRoles.Text = "Gestionar Roles";
            btnGesRoles.TextAlign = ContentAlignment.MiddleRight;
            btnGesRoles.UseVisualStyleBackColor = false;
            btnGesRoles.Click += btnGesRoles_Click;
            // 
            // btnAdmUsr
            // 
            btnAdmUsr.BackColor = Color.FromArgb(230, 242, 248);
            btnAdmUsr.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmUsr.Image = Properties.Resources._4213440_community_group_leader_people_team_icon;
            btnAdmUsr.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmUsr.Location = new Point(-3, 84);
            btnAdmUsr.Margin = new Padding(3, 2, 3, 2);
            btnAdmUsr.Name = "btnAdmUsr";
            btnAdmUsr.Size = new Size(312, 86);
            btnAdmUsr.TabIndex = 1;
            btnAdmUsr.Text = "Administrar Usuarios";
            btnAdmUsr.TextAlign = ContentAlignment.MiddleRight;
            btnAdmUsr.UseVisualStyleBackColor = false;
            btnAdmUsr.Click += btnAdmUsr_Click;
            // 
            // btnAdmProd
            // 
            btnAdmProd.BackColor = Color.FromArgb(230, 242, 248);
            btnAdmProd.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmProd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdmProd.Image = Properties.Resources._4945342_document_documents_files_folder_format_icon__1_;
            btnAdmProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmProd.Location = new Point(-3, -2);
            btnAdmProd.Margin = new Padding(3, 2, 3, 2);
            btnAdmProd.Name = "btnAdmProd";
            btnAdmProd.Size = new Size(312, 86);
            btnAdmProd.TabIndex = 0;
            btnAdmProd.Text = "Administrar Productos";
            btnAdmProd.TextAlign = ContentAlignment.MiddleRight;
            btnAdmProd.UseVisualStyleBackColor = false;
            btnAdmProd.Click += btnAdmProd_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.FromArgb(230, 242, 248);
            lblBienvenida.Font = new Font("MS PGothic", 52F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblBienvenida.ForeColor = SystemColors.ActiveCaptionText;
            lblBienvenida.Location = new Point(398, 254);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(520, 104);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido al Sistema\r\nde Inventarios";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGestionarPermisos
            // 
            btnGestionarPermisos.BackColor = Color.FromArgb(230, 242, 248);
            btnGestionarPermisos.Font = new Font("MS Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionarPermisos.Image = Properties.Resources._9068689_cycle_movement_icon;
            btnGestionarPermisos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionarPermisos.Location = new Point(-3, 174);
            btnGestionarPermisos.Margin = new Padding(3, 2, 3, 2);
            btnGestionarPermisos.Name = "btnGestionarPermisos";
            btnGestionarPermisos.Size = new Size(312, 86);
            btnGestionarPermisos.TabIndex = 8;
            btnGestionarPermisos.Text = "Gestionar permisos";
            btnGestionarPermisos.TextAlign = ContentAlignment.MiddleRight;
            btnGestionarPermisos.UseVisualStyleBackColor = false;
            btnGestionarPermisos.Click += btnGestionarPermisos_Click;
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1666, 906);
            Controls.Add(splitMDI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Inventarios";
            WindowState = FormWindowState.Maximized;
            splitMDI.Panel1.ResumeLayout(false);
            splitMDI.Panel2.ResumeLayout(false);
            splitMDI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitMDI).EndInit();
            splitMDI.ResumeLayout(false);
            groupMDI1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMDI;
        private GroupBox groupMDI1;
        private Button btnAdmProd;
        private Button btnAdmUsr;
        private Button btnRepAud;
        private Button btnGesRoles;
        private Button btnRepInv;
        private Button btnAPI;
        private Button btnClose;
        private Button btnRegMov;
        private Label lblBienvenida;
        private Button btnCambiarUsuario;
        private Button btnGestionarPermisos;
    }
}