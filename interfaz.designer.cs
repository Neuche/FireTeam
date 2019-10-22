

namespace FireTeam
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.restore = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.Maxim = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.Sidebarwrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.chats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Maps = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Reportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Account = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LineSidebbar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Adentro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaAdentro = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MoverInterfaz = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.Sidebarwrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.Adentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(64)))), ((int)(((byte)(79)))));
            this.MenuTop.Controls.Add(this.restore);
            this.MenuTop.Controls.Add(this.close);
            this.MenuTop.Controls.Add(this.Maxim);
            this.MenuTop.Controls.Add(this.minimizar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.Menu);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1100, 80);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            // 
            // restore
            // 
            this.restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.restore, BunifuAnimatorNS.DecorationType.None);
            this.restore.Image = ((System.Drawing.Image)(resources.GetObject("restore.Image")));
            this.restore.Location = new System.Drawing.Point(1022, 24);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(30, 30);
            this.restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restore.TabIndex = 5;
            this.restore.TabStop = false;
            this.restore.Visible = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1058, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Maxim
            // 
            this.Maxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maxim, BunifuAnimatorNS.DecorationType.None);
            this.Maxim.Image = ((System.Drawing.Image)(resources.GetObject("Maxim.Image")));
            this.Maxim.Location = new System.Drawing.Point(1022, 24);
            this.Maxim.Name = "Maxim";
            this.Maxim.Size = new System.Drawing.Size(30, 30);
            this.Maxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maxim.TabIndex = 3;
            this.Maxim.TabStop = false;
            this.Maxim.Click += new System.EventHandler(this.Maxim_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(986, 24);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AnimacionSidebar.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.InitialImage = ((System.Drawing.Image)(resources.GetObject("Menu.InitialImage")));
            this.Menu.Location = new System.Drawing.Point(12, 24);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(30, 30);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Sidebarwrapper
            // 
            this.Sidebarwrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(229)))), ((int)(((byte)(205)))));
            this.Sidebarwrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.Sidebarwrapper, BunifuAnimatorNS.DecorationType.None);
            this.Sidebarwrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebarwrapper.Location = new System.Drawing.Point(0, 80);
            this.Sidebarwrapper.Name = "Sidebarwrapper";
            this.Sidebarwrapper.Size = new System.Drawing.Size(300, 520);
            this.Sidebarwrapper.TabIndex = 1;
            this.Sidebarwrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarWrapper_Paint);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.chats);
            this.Sidebar.Controls.Add(this.Maps);
            this.Sidebar.Controls.Add(this.signout);
            this.Sidebar.Controls.Add(this.Reportes);
            this.Sidebar.Controls.Add(this.Account);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.LineSidebbar);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.ForeColor = System.Drawing.Color.White;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(218)))), ((int)(((byte)(128)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(218)))), ((int)(((byte)(128)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(218)))), ((int)(((byte)(128)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.White;
            this.Sidebar.Location = new System.Drawing.Point(12, 15);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 493);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // chats
            // 
            this.chats.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chats.BackColor = System.Drawing.Color.Transparent;
            this.chats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chats.BorderRadius = 0;
            this.chats.ButtonText = "      Chats";
            this.chats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.chats, BunifuAnimatorNS.DecorationType.None);
            this.chats.DisabledColor = System.Drawing.Color.Gray;
            this.chats.Iconcolor = System.Drawing.Color.Transparent;
            this.chats.Iconimage = ((System.Drawing.Image)(resources.GetObject("chats.Iconimage")));
            this.chats.Iconimage_right = null;
            this.chats.Iconimage_right_Selected = null;
            this.chats.Iconimage_Selected = null;
            this.chats.IconMarginLeft = 0;
            this.chats.IconMarginRight = 0;
            this.chats.IconRightVisible = true;
            this.chats.IconRightZoom = 0D;
            this.chats.IconVisible = true;
            this.chats.IconZoom = 90D;
            this.chats.IsTab = false;
            this.chats.Location = new System.Drawing.Point(15, 104);
            this.chats.Name = "chats";
            this.chats.Normalcolor = System.Drawing.Color.Transparent;
            this.chats.OnHovercolor = System.Drawing.Color.Transparent;
            this.chats.OnHoverTextColor = System.Drawing.Color.White;
            this.chats.selected = false;
            this.chats.Size = new System.Drawing.Size(241, 51);
            this.chats.TabIndex = 10;
            this.chats.Text = "      Chats";
            this.chats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chats.Textcolor = System.Drawing.Color.White;
            this.chats.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chats.Click += new System.EventHandler(this.chats_Click);
            // 
            // Maps
            // 
            this.Maps.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Maps.BackColor = System.Drawing.Color.Transparent;
            this.Maps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maps.BorderRadius = 0;
            this.Maps.ButtonText = "      Maps";
            this.Maps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Maps, BunifuAnimatorNS.DecorationType.None);
            this.Maps.DisabledColor = System.Drawing.Color.Gray;
            this.Maps.Iconcolor = System.Drawing.Color.Transparent;
            this.Maps.Iconimage = ((System.Drawing.Image)(resources.GetObject("Maps.Iconimage")));
            this.Maps.Iconimage_right = null;
            this.Maps.Iconimage_right_Selected = null;
            this.Maps.Iconimage_Selected = null;
            this.Maps.IconMarginLeft = 0;
            this.Maps.IconMarginRight = 0;
            this.Maps.IconRightVisible = true;
            this.Maps.IconRightZoom = 0D;
            this.Maps.IconVisible = true;
            this.Maps.IconZoom = 90D;
            this.Maps.IsTab = false;
            this.Maps.Location = new System.Drawing.Point(15, 221);
            this.Maps.Name = "Maps";
            this.Maps.Normalcolor = System.Drawing.Color.Transparent;
            this.Maps.OnHovercolor = System.Drawing.Color.Transparent;
            this.Maps.OnHoverTextColor = System.Drawing.Color.White;
            this.Maps.selected = false;
            this.Maps.Size = new System.Drawing.Size(241, 51);
            this.Maps.TabIndex = 9;
            this.Maps.Text = "      Maps";
            this.Maps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Maps.Textcolor = System.Drawing.Color.White;
            this.Maps.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maps.Click += new System.EventHandler(this.Maps_Click);
            // 
            // signout
            // 
            this.signout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.signout.BackColor = System.Drawing.Color.Transparent;
            this.signout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signout.BorderRadius = 0;
            this.signout.ButtonText = "      Sign Out";
            this.signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.signout, BunifuAnimatorNS.DecorationType.None);
            this.signout.DisabledColor = System.Drawing.Color.Gray;
            this.signout.Iconcolor = System.Drawing.Color.Transparent;
            this.signout.Iconimage = ((System.Drawing.Image)(resources.GetObject("signout.Iconimage")));
            this.signout.Iconimage_right = null;
            this.signout.Iconimage_right_Selected = null;
            this.signout.Iconimage_Selected = null;
            this.signout.IconMarginLeft = 0;
            this.signout.IconMarginRight = 0;
            this.signout.IconRightVisible = true;
            this.signout.IconRightZoom = 0D;
            this.signout.IconVisible = true;
            this.signout.IconZoom = 90D;
            this.signout.IsTab = false;
            this.signout.Location = new System.Drawing.Point(14, 366);
            this.signout.Name = "signout";
            this.signout.Normalcolor = System.Drawing.Color.Transparent;
            this.signout.OnHovercolor = System.Drawing.Color.Transparent;
            this.signout.OnHoverTextColor = System.Drawing.Color.White;
            this.signout.selected = false;
            this.signout.Size = new System.Drawing.Size(241, 51);
            this.signout.TabIndex = 8;
            this.signout.Text = "      Sign Out";
            this.signout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signout.Textcolor = System.Drawing.Color.White;
            this.signout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // Reportes
            // 
            this.Reportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Reportes.BackColor = System.Drawing.Color.Transparent;
            this.Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reportes.BorderRadius = 0;
            this.Reportes.ButtonText = "      Report";
            this.Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Reportes, BunifuAnimatorNS.DecorationType.None);
            this.Reportes.DisabledColor = System.Drawing.Color.Gray;
            this.Reportes.Iconcolor = System.Drawing.Color.Transparent;
            this.Reportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Reportes.Iconimage")));
            this.Reportes.Iconimage_right = null;
            this.Reportes.Iconimage_right_Selected = null;
            this.Reportes.Iconimage_Selected = null;
            this.Reportes.IconMarginLeft = 0;
            this.Reportes.IconMarginRight = 0;
            this.Reportes.IconRightVisible = true;
            this.Reportes.IconRightZoom = 0D;
            this.Reportes.IconVisible = true;
            this.Reportes.IconZoom = 90D;
            this.Reportes.IsTab = false;
            this.Reportes.Location = new System.Drawing.Point(14, 161);
            this.Reportes.Name = "Reportes";
            this.Reportes.Normalcolor = System.Drawing.Color.Transparent;
            this.Reportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.Reportes.OnHoverTextColor = System.Drawing.Color.White;
            this.Reportes.selected = false;
            this.Reportes.Size = new System.Drawing.Size(241, 51);
            this.Reportes.TabIndex = 6;
            this.Reportes.Text = "      Report";
            this.Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Textcolor = System.Drawing.Color.White;
            this.Reportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Account
            // 
            this.Account.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Account.BorderRadius = 0;
            this.Account.ButtonText = "      Account";
            this.Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Account, BunifuAnimatorNS.DecorationType.None);
            this.Account.DisabledColor = System.Drawing.Color.Gray;
            this.Account.Iconcolor = System.Drawing.Color.Transparent;
            this.Account.Iconimage = ((System.Drawing.Image)(resources.GetObject("Account.Iconimage")));
            this.Account.Iconimage_right = null;
            this.Account.Iconimage_right_Selected = null;
            this.Account.Iconimage_Selected = null;
            this.Account.IconMarginLeft = 0;
            this.Account.IconMarginRight = 0;
            this.Account.IconRightVisible = true;
            this.Account.IconRightZoom = 0D;
            this.Account.IconVisible = true;
            this.Account.IconZoom = 90D;
            this.Account.IsTab = false;
            this.Account.Location = new System.Drawing.Point(14, 294);
            this.Account.Name = "Account";
            this.Account.Normalcolor = System.Drawing.Color.Transparent;
            this.Account.OnHovercolor = System.Drawing.Color.Transparent;
            this.Account.OnHoverTextColor = System.Drawing.Color.White;
            this.Account.selected = false;
            this.Account.Size = new System.Drawing.Size(241, 51);
            this.Account.TabIndex = 5;
            this.Account.Text = "      Account";
            this.Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.Textcolor = System.Drawing.Color.White;
            this.Account.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fire Team";
            // 
            // LineSidebbar
            // 
            this.LineSidebbar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineSidebbar, BunifuAnimatorNS.DecorationType.None);
            this.LineSidebbar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LineSidebbar.LineThickness = 1;
            this.LineSidebbar.Location = new System.Drawing.Point(3, 76);
            this.LineSidebbar.Name = "LineSidebbar";
            this.LineSidebbar.Size = new System.Drawing.Size(252, 1);
            this.LineSidebbar.TabIndex = 2;
            this.LineSidebbar.Transparency = 255;
            this.LineSidebbar.Vertical = false;
            this.LineSidebbar.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.Adentro);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(800, 520);
            this.Wrapper.TabIndex = 2;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // Adentro
            // 
            this.Adentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Adentro.BackgroundImage = global::FireTeam.Properties.Resources.chats;
            this.Adentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Adentro.Controls.Add(this.map2);
            this.AnimacionSidebar.SetDecoration(this.Adentro, BunifuAnimatorNS.DecorationType.None);
            this.Adentro.GradientBottomLeft = System.Drawing.Color.White;
            this.Adentro.GradientBottomRight = System.Drawing.Color.White;
            this.Adentro.GradientTopLeft = System.Drawing.Color.White;
            this.Adentro.GradientTopRight = System.Drawing.Color.White;
            this.Adentro.Location = new System.Drawing.Point(17, 15);
            this.Adentro.Name = "Adentro";
            this.Adentro.Quality = 10;
            this.Adentro.Size = new System.Drawing.Size(771, 493);
            this.Adentro.TabIndex = 15;
            this.Adentro.Paint += new System.Windows.Forms.PaintEventHandler(this.Adentro_Paint);
            // 
            // map2
            // 
            this.map2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map2.BackgroundImage = global::FireTeam.Properties.Resources.chats;
            this.map2.Bearing = 0F;
            this.map2.CanDragMap = true;
            this.AnimacionSidebar.SetDecoration(this.map2, BunifuAnimatorNS.DecorationType.None);
            this.map2.EmptyTileColor = System.Drawing.Color.Navy;
            this.map2.GrayScaleMode = false;
            this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map2.LevelsKeepInMemmory = 5;
            this.map2.Location = new System.Drawing.Point(0, 0);
            this.map2.MarkersEnabled = true;
            this.map2.MaxZoom = 2;
            this.map2.MinZoom = 2;
            this.map2.MouseWheelZoomEnabled = true;
            this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map2.Name = "map2";
            this.map2.NegativeMode = false;
            this.map2.PolygonsEnabled = true;
            this.map2.RetryLoadTile = 0;
            this.map2.RoutesEnabled = true;
            this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map2.ShowTileGridLines = false;
            this.map2.Size = new System.Drawing.Size(771, 493);
            this.map2.TabIndex = 99;
            this.map2.Visible = false;
            this.map2.Zoom = 0D;
            this.map2.Load += new System.EventHandler(this.map2_Load_1);
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.AnimacionSidebar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation6;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // CurvaAdentro
            // 
            this.CurvaAdentro.ElipseRadius = 7;
            this.CurvaAdentro.TargetControl = this.Adentro;
            // 
            // MoverInterfaz
            // 
            this.MoverInterfaz.Fixed = true;
            this.MoverInterfaz.Horizontal = true;
            this.MoverInterfaz.TargetControl = this.MenuTop;
            this.MoverInterfaz.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Sidebarwrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.Sidebarwrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.Adentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel Sidebarwrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox restore;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox Maxim;
        private System.Windows.Forms.PictureBox minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator LineSidebbar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton Account;
        private Bunifu.Framework.UI.BunifuFlatButton Reportes;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton signout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton chats;
        private Bunifu.Framework.UI.BunifuFlatButton Maps;
        private Bunifu.Framework.UI.BunifuGradientPanel Adentro;
        private Bunifu.Framework.UI.BunifuElipse CurvaAdentro;
        private Bunifu.Framework.UI.BunifuDragControl MoverInterfaz;
        private GMap.NET.WindowsForms.GMapControl map2;
    }
}

