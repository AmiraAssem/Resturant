namespace Restaurant_Project_Files_
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tap_panel = new System.Windows.Forms.Panel();
            this.fixedpic = new System.Windows.Forms.PictureBox();
            this.panel_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.fixed_pan = new System.Windows.Forms.Panel();
            this.Chart_btn = new System.Windows.Forms.Button();
            this.btn_delivery = new System.Windows.Forms.Button();
            this.btn_offers = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.menu_btn = new ns1.BunifuImageButton();
            this.side = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_home = new System.Windows.Forms.Button();
            this.Animated_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_imgbtn = new ns1.BunifuImageButton();
            this.home_imgbtn = new ns1.BunifuImageButton();
            this.close_bt = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Fixed_home_panel = new System.Windows.Forms.Panel();
            this.timer_Home = new System.Windows.Forms.Timer(this.components);
            this.timer_home_fixedpic = new System.Windows.Forms.Timer(this.components);
            this.menu_timer = new System.Windows.Forms.Timer(this.components);
            this.tap_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedpic)).BeginInit();
            this.fixed_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Animated_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_imgbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_imgbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tap_panel
            // 
            this.tap_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.tap_panel.Controls.Add(this.fixedpic);
            this.panel_animator.SetDecoration(this.tap_panel, BunifuAnimatorNS.DecorationType.None);
            this.tap_panel.Location = new System.Drawing.Point(351, 34);
            this.tap_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tap_panel.Name = "tap_panel";
            this.tap_panel.Size = new System.Drawing.Size(143, 146);
            this.tap_panel.TabIndex = 24;
            // 
            // fixedpic
            // 
            this.panel_animator.SetDecoration(this.fixedpic, BunifuAnimatorNS.DecorationType.None);
            this.fixedpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedpic.Image = ((System.Drawing.Image)(resources.GetObject("fixedpic.Image")));
            this.fixedpic.Location = new System.Drawing.Point(0, 0);
            this.fixedpic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fixedpic.Name = "fixedpic";
            this.fixedpic.Size = new System.Drawing.Size(143, 146);
            this.fixedpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fixedpic.TabIndex = 28;
            this.fixedpic.TabStop = false;
            // 
            // panel_animator
            // 
            this.panel_animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panel_animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panel_animator.DefaultAnimation = animation1;
            // 
            // fixed_pan
            // 
            this.fixed_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fixed_pan.Controls.Add(this.Chart_btn);
            this.fixed_pan.Controls.Add(this.btn_delivery);
            this.fixed_pan.Controls.Add(this.btn_offers);
            this.fixed_pan.Controls.Add(this.btn_customers);
            this.fixed_pan.Controls.Add(this.btn_order);
            this.fixed_pan.Controls.Add(this.btn_menu);
            this.fixed_pan.Controls.Add(this.menu_btn);
            this.fixed_pan.Controls.Add(this.side);
            this.fixed_pan.Controls.Add(this.pictureBox2);
            this.fixed_pan.Controls.Add(this.bt_home);
            this.panel_animator.SetDecoration(this.fixed_pan, BunifuAnimatorNS.DecorationType.None);
            this.fixed_pan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fixed_pan.Location = new System.Drawing.Point(0, 0);
            this.fixed_pan.Name = "fixed_pan";
            this.fixed_pan.Size = new System.Drawing.Size(265, 758);
            this.fixed_pan.TabIndex = 54;
            // 
            // Chart_btn
            // 
            this.panel_animator.SetDecoration(this.Chart_btn, BunifuAnimatorNS.DecorationType.None);
            this.Chart_btn.FlatAppearance.BorderSize = 0;
            this.Chart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chart_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart_btn.ForeColor = System.Drawing.Color.White;
            this.Chart_btn.Image = ((System.Drawing.Image)(resources.GetObject("Chart_btn.Image")));
            this.Chart_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart_btn.Location = new System.Drawing.Point(22, 559);
            this.Chart_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chart_btn.Name = "Chart_btn";
            this.Chart_btn.Size = new System.Drawing.Size(230, 63);
            this.Chart_btn.TabIndex = 33;
            this.Chart_btn.Text = "      Chart";
            this.Chart_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chart_btn.UseVisualStyleBackColor = true;
            this.Chart_btn.Click += new System.EventHandler(this.Chart_btn_Click);
            // 
            // btn_delivery
            // 
            this.panel_animator.SetDecoration(this.btn_delivery, BunifuAnimatorNS.DecorationType.None);
            this.btn_delivery.FlatAppearance.BorderSize = 0;
            this.btn_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivery.ForeColor = System.Drawing.Color.White;
            this.btn_delivery.Image = ((System.Drawing.Image)(resources.GetObject("btn_delivery.Image")));
            this.btn_delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delivery.Location = new System.Drawing.Point(17, 307);
            this.btn_delivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(230, 63);
            this.btn_delivery.TabIndex = 32;
            this.btn_delivery.Text = "       Delivery";
            this.btn_delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delivery.UseVisualStyleBackColor = true;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // btn_offers
            // 
            this.panel_animator.SetDecoration(this.btn_offers, BunifuAnimatorNS.DecorationType.None);
            this.btn_offers.FlatAppearance.BorderSize = 0;
            this.btn_offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_offers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_offers.ForeColor = System.Drawing.Color.White;
            this.btn_offers.Image = ((System.Drawing.Image)(resources.GetObject("btn_offers.Image")));
            this.btn_offers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_offers.Location = new System.Drawing.Point(19, 496);
            this.btn_offers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_offers.Name = "btn_offers";
            this.btn_offers.Size = new System.Drawing.Size(230, 63);
            this.btn_offers.TabIndex = 31;
            this.btn_offers.Text = "     Offers";
            this.btn_offers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_offers.UseVisualStyleBackColor = true;
            this.btn_offers.Click += new System.EventHandler(this.btn_offers_Click);
            // 
            // btn_customers
            // 
            this.panel_animator.SetDecoration(this.btn_customers, BunifuAnimatorNS.DecorationType.None);
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Image = ((System.Drawing.Image)(resources.GetObject("btn_customers.Image")));
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(19, 433);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(230, 63);
            this.btn_customers.TabIndex = 30;
            this.btn_customers.Text = "       Customers";
            this.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_order
            // 
            this.panel_animator.SetDecoration(this.btn_order, BunifuAnimatorNS.DecorationType.None);
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Image")));
            this.btn_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_order.Location = new System.Drawing.Point(17, 370);
            this.btn_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(230, 63);
            this.btn_order.TabIndex = 29;
            this.btn_order.Text = "       Delivery Boy";
            this.btn_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_menu
            // 
            this.panel_animator.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(19, 244);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(230, 63);
            this.btn_menu.TabIndex = 26;
            this.btn_menu.Text = "       Menu";
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.panel_animator.SetDecoration(this.menu_btn, BunifuAnimatorNS.DecorationType.None);
            this.menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn.Image")));
            this.menu_btn.ImageActive = null;
            this.menu_btn.Location = new System.Drawing.Point(-13, 0);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(93, 61);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_btn.TabIndex = 23;
            this.menu_btn.TabStop = false;
            this.menu_btn.Zoom = 10;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click_1);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.side, BunifuAnimatorNS.DecorationType.None);
            this.side.Location = new System.Drawing.Point(3, 181);
            this.side.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(12, 63);
            this.side.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.panel_animator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 63);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // bt_home
            // 
            this.panel_animator.SetDecoration(this.bt_home, BunifuAnimatorNS.DecorationType.None);
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.ForeColor = System.Drawing.Color.White;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_home.Location = new System.Drawing.Point(19, 181);
            this.bt_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(230, 63);
            this.bt_home.TabIndex = 18;
            this.bt_home.Text = "       Home";
            this.bt_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click_1);
            // 
            // Animated_panel
            // 
            this.Animated_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Animated_panel.Controls.Add(this.pictureBox1);
            this.panel_animator.SetDecoration(this.Animated_panel, BunifuAnimatorNS.DecorationType.None);
            this.Animated_panel.Location = new System.Drawing.Point(180, 34);
            this.Animated_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Animated_panel.Name = "Animated_panel";
            this.Animated_panel.Size = new System.Drawing.Size(143, 146);
            this.Animated_panel.TabIndex = 25;
            this.Animated_panel.Visible = false;
            // 
            // pictureBox1
            // 
            this.panel_animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1192, 34);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.BackColor = System.Drawing.Color.Transparent;
            this.panel_animator.SetDecoration(this.home_label, BunifuAnimatorNS.DecorationType.None);
            this.home_label.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.ForeColor = System.Drawing.Color.SteelBlue;
            this.home_label.Location = new System.Drawing.Point(556, 86);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(399, 35);
            this.home_label.TabIndex = 62;
            this.home_label.Text = "..... Find your Favourite Food ....";
            this.home_label.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(682, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Restaurant";
            this.label1.UseMnemonic = false;
            // 
            // login_imgbtn
            // 
            this.login_imgbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_animator.SetDecoration(this.login_imgbtn, BunifuAnimatorNS.DecorationType.None);
            this.login_imgbtn.Image = ((System.Drawing.Image)(resources.GetObject("login_imgbtn.Image")));
            this.login_imgbtn.ImageActive = null;
            this.login_imgbtn.Location = new System.Drawing.Point(1138, 38);
            this.login_imgbtn.Name = "login_imgbtn";
            this.login_imgbtn.Size = new System.Drawing.Size(52, 34);
            this.login_imgbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_imgbtn.TabIndex = 51;
            this.login_imgbtn.TabStop = false;
            this.login_imgbtn.Zoom = 10;
            this.login_imgbtn.Click += new System.EventHandler(this.login_imgbtn_Click);
            // 
            // home_imgbtn
            // 
            this.home_imgbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_animator.SetDecoration(this.home_imgbtn, BunifuAnimatorNS.DecorationType.None);
            this.home_imgbtn.Image = ((System.Drawing.Image)(resources.GetObject("home_imgbtn.Image")));
            this.home_imgbtn.ImageActive = null;
            this.home_imgbtn.Location = new System.Drawing.Point(1096, 38);
            this.home_imgbtn.Name = "home_imgbtn";
            this.home_imgbtn.Size = new System.Drawing.Size(51, 34);
            this.home_imgbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_imgbtn.TabIndex = 50;
            this.home_imgbtn.TabStop = false;
            this.home_imgbtn.Zoom = 10;
            this.home_imgbtn.Click += new System.EventHandler(this.home_imgbtn_Click);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.close_bt, BunifuAnimatorNS.DecorationType.None);
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.Gray;
            this.close_bt.Image = ((System.Drawing.Image)(resources.GetObject("close_bt.Image")));
            this.close_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_bt.Location = new System.Drawing.Point(1147, -1);
            this.close_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(37, 34);
            this.close_bt.TabIndex = 40;
            this.close_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.button11, BunifuAnimatorNS.DecorationType.None);
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(1106, -1);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 35);
            this.button11.TabIndex = 26;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_animator.SetDecoration(this.button12, BunifuAnimatorNS.DecorationType.None);
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(1061, -2);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(37, 35);
            this.button12.TabIndex = 25;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Fixed_home_panel
            // 
            this.panel_animator.SetDecoration(this.Fixed_home_panel, BunifuAnimatorNS.DecorationType.None);
            this.Fixed_home_panel.Location = new System.Drawing.Point(266, 181);
            this.Fixed_home_panel.Name = "Fixed_home_panel";
            this.Fixed_home_panel.Size = new System.Drawing.Size(926, 577);
            this.Fixed_home_panel.TabIndex = 64;
            // 
            // timer_Home
            // 
            this.timer_Home.Enabled = true;
            this.timer_Home.Interval = 2000;
            this.timer_Home.Tick += new System.EventHandler(this.timer_Home_Tick);
            // 
            // timer_home_fixedpic
            // 
            this.timer_home_fixedpic.Enabled = true;
            this.timer_home_fixedpic.Interval = 350;
            this.timer_home_fixedpic.Tick += new System.EventHandler(this.timer_home_fixedpic_Tick);
            // 
            // menu_timer
            // 
            this.menu_timer.Interval = 20;
            this.menu_timer.Tick += new System.EventHandler(this.menu_timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1192, 756);
            this.Controls.Add(this.Fixed_home_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_label);
            this.Controls.Add(this.Animated_panel);
            this.Controls.Add(this.fixed_pan);
            this.Controls.Add(this.login_imgbtn);
            this.Controls.Add(this.home_imgbtn);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.tap_panel);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.flowLayoutPanel1);
            this.panel_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tap_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fixedpic)).EndInit();
            this.fixed_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Animated_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_imgbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_imgbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel tap_panel;
        private System.Windows.Forms.PictureBox fixedpic;
        private System.Windows.Forms.Button close_bt;
        private BunifuAnimatorNS.BunifuTransition panel_animator;
        private System.Windows.Forms.Timer timer_Home;
        private System.Windows.Forms.Timer timer_home_fixedpic;
        private ns1.BunifuImageButton home_imgbtn;
        private ns1.BunifuImageButton login_imgbtn;
        private System.Windows.Forms.Panel fixed_pan;
        private ns1.BunifuImageButton menu_btn;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Panel Animated_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Fixed_home_panel;
        private System.Windows.Forms.Timer menu_timer;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_offers;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_delivery;
        private System.Windows.Forms.Button Chart_btn;
    }
}