namespace ctp_rgres
{
    using System;
    using System.Xml;
    using System.Xml.Linq;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using System.ServiceModel;


    partial class MainForm
    {
        public System.Collections.ArrayList mod_time_array = new System.Collections.ArrayList();
        public System.Collections.ArrayList list_works_curent = new System.Collections.ArrayList();

        public System.Collections.ArrayList all_list_works = new System.Collections.ArrayList();

        public System.Collections.ArrayList list_wokrs_main = new System.Collections.ArrayList();

        public System.Collections.ArrayList _list_wokrs_start = new System.Collections.ArrayList();

        public bool enable_history = false;
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.l_time_begin = new System.Windows.Forms.Label();
            this.l_time_end = new System.Windows.Forms.Label();
            this.l_data = new System.Windows.Forms.Label();
            this.bt_main_start = new System.Windows.Forms.Button();
            this.bt_main_stop = new System.Windows.Forms.Button();
            this.bt_main_mod = new System.Windows.Forms.Button();
            this.bt_CleanForm = new System.Windows.Forms.Button();
            this.btTurn = new System.Windows.Forms.Button();
            this.MainDescr = new ctp_rgres.my_LinkLibel();
            this.data_start = new ctp_rgres.my_time();
            this.time_main_end = new ctp_rgres.my_time();
            this.time_main_begin = new ctp_rgres.my_time();
            this.pic_lk_16 = new ctp_rgres.my_picBox();
            this.pic_lk_18 = new ctp_rgres.my_picBox();
            this.pic_lk_12 = new ctp_rgres.my_picBox();
            this.pic_lk_13 = new ctp_rgres.my_picBox();
            this.pic_lk_20 = new ctp_rgres.my_picBox();
            this.pic_lk_21_01 = new ctp_rgres.my_picBox();
            this.pic_lk_21_02 = new ctp_rgres.my_picBox();
            this.pic_lk_22 = new ctp_rgres.my_picBox();
            this.pic_uzr = new ctp_rgres.my_picBox();
            this.pic_lk_15 = new ctp_rgres.my_picBox();
            this.pic_lk_9b = new ctp_rgres.my_picBox();
            this.pic_lk_9a = new ctp_rgres.my_picBox();
            this.pic_lk_10b = new ctp_rgres.my_picBox();
            this.pic_lk_10a = new ctp_rgres.my_picBox();
            this.pic_vo_2 = new ctp_rgres.my_picBox();
            this.pic_vo_1 = new ctp_rgres.my_picBox();
            this.pic_lk_11b = new ctp_rgres.my_picBox();
            this.pic_lk_11a = new ctp_rgres.my_picBox();
            this.pic_lk_8b = new ctp_rgres.my_picBox();
            this.pic_lk_8a = new ctp_rgres.my_picBox();
            this.pic_dm_4 = new ctp_rgres.my_picBox();
            this.pic_dm_3 = new ctp_rgres.my_picBox();
            this.pic_dm_2 = new ctp_rgres.my_picBox();
            this.pic_dm_1 = new ctp_rgres.my_picBox();
            this.pic_lk_6b = new ctp_rgres.my_picBox();
            this.pic_lk_6a = new ctp_rgres.my_picBox();
            this.pic_lk_5_b = new ctp_rgres.my_picBox();
            this.pic_lk_5_a = new ctp_rgres.my_picBox();
            this.pic_lk_3_4 = new ctp_rgres.my_picBox();
            this.pic_lk_1_2 = new ctp_rgres.my_picBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_21_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_21_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_uzr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_9b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_9a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_10b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_10a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vo_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vo_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_11b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_11a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_8b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_8a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_6b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_6a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_5_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_5_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_3_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_1_2)).BeginInit();
            this.SuspendLayout();
            // 
            // l_time_begin
            // 
            resources.ApplyResources(this.l_time_begin, "l_time_begin");
            this.l_time_begin.ForeColor = System.Drawing.SystemColors.Window;
            this.l_time_begin.Name = "l_time_begin";
            // 
            // l_time_end
            // 
            resources.ApplyResources(this.l_time_end, "l_time_end");
            this.l_time_end.ForeColor = System.Drawing.SystemColors.Window;
            this.l_time_end.Name = "l_time_end";
            // 
            // l_data
            // 
            resources.ApplyResources(this.l_data, "l_data");
            this.l_data.ForeColor = System.Drawing.SystemColors.Window;
            this.l_data.Name = "l_data";
            // 
            // bt_main_start
            // 
            resources.ApplyResources(this.bt_main_start, "bt_main_start");
            this.bt_main_start.BackColor = System.Drawing.SystemColors.Control;
            this.bt_main_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_main_start.Name = "bt_main_start";
            this.bt_main_start.UseVisualStyleBackColor = false;
            this.bt_main_start.Click += new System.EventHandler(this.bt_main_start_Click);
            // 
            // bt_main_stop
            // 
            resources.ApplyResources(this.bt_main_stop, "bt_main_stop");
            this.bt_main_stop.BackColor = System.Drawing.SystemColors.Control;
            this.bt_main_stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_main_stop.FlatAppearance.BorderSize = 0;
            this.bt_main_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_main_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_main_stop.Name = "bt_main_stop";
            this.bt_main_stop.UseVisualStyleBackColor = false;
            this.bt_main_stop.Click += new System.EventHandler(this.bt_main_stop_Click);
            // 
            // bt_main_mod
            // 
            resources.ApplyResources(this.bt_main_mod, "bt_main_mod");
            this.bt_main_mod.BackColor = System.Drawing.SystemColors.Control;
            this.bt_main_mod.Name = "bt_main_mod";
            this.bt_main_mod.UseVisualStyleBackColor = false;
            this.bt_main_mod.Click += new System.EventHandler(this.bt_main_mod_Click);
            // 
            // bt_CleanForm
            // 
            resources.ApplyResources(this.bt_CleanForm, "bt_CleanForm");
            this.bt_CleanForm.BackColor = System.Drawing.SystemColors.Control;
            this.bt_CleanForm.Name = "bt_CleanForm";
            this.bt_CleanForm.UseVisualStyleBackColor = false;
            this.bt_CleanForm.Click += new System.EventHandler(this.bt_CleanForm_Click);
            // 
            // btTurn
            // 
            resources.ApplyResources(this.btTurn, "btTurn");
            this.btTurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTurn.Image = global::ctp_rgres.Properties.Resources.Downloads;
            this.btTurn.Name = "btTurn";
            this.btTurn.UseVisualStyleBackColor = true;
            this.btTurn.Click += new System.EventHandler(this.btTurn_Click);
            // 
            // MainDescr
            // 
            resources.ApplyResources(this.MainDescr, "MainDescr");
            this.MainDescr.Name = "MainDescr";
            this.MainDescr.TabStop = true;
            this.MainDescr.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.MainDescr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainDescr_LinkClicked);
            // 
            // data_start
            // 
            resources.ApplyResources(this.data_start, "data_start");
            this.data_start.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.data_start.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.data_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_start.Name = "data_start";
            this.data_start.ShowUpDown = true;
            // 
            // time_main_end
            // 
            resources.ApplyResources(this.time_main_end, "time_main_end");
            this.time_main_end.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.time_main_end.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.time_main_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_main_end.Name = "time_main_end";
            this.time_main_end.ShowUpDown = true;
            // 
            // time_main_begin
            // 
            resources.ApplyResources(this.time_main_begin, "time_main_begin");
            this.time_main_begin.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.time_main_begin.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.time_main_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_main_begin.Name = "time_main_begin";
            this.time_main_begin.ShowUpDown = true;
            // 
            // pic_lk_16
            // 
            resources.ApplyResources(this.pic_lk_16, "pic_lk_16");
            this.pic_lk_16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_16.Name = "pic_lk_16";
            this.pic_lk_16.TabStop = false;
            this.pic_lk_16.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_18
            // 
            resources.ApplyResources(this.pic_lk_18, "pic_lk_18");
            this.pic_lk_18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_18.Name = "pic_lk_18";
            this.pic_lk_18.TabStop = false;
            this.pic_lk_18.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_12
            // 
            resources.ApplyResources(this.pic_lk_12, "pic_lk_12");
            this.pic_lk_12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_12.Name = "pic_lk_12";
            this.pic_lk_12.TabStop = false;
            this.pic_lk_12.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_13
            // 
            resources.ApplyResources(this.pic_lk_13, "pic_lk_13");
            this.pic_lk_13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_13.Name = "pic_lk_13";
            this.pic_lk_13.TabStop = false;
            this.pic_lk_13.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_20
            // 
            resources.ApplyResources(this.pic_lk_20, "pic_lk_20");
            this.pic_lk_20.BackColor = System.Drawing.Color.Transparent;
            this.pic_lk_20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_20.Name = "pic_lk_20";
            this.pic_lk_20.TabStop = false;
            this.pic_lk_20.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_21_01
            // 
            resources.ApplyResources(this.pic_lk_21_01, "pic_lk_21_01");
            this.pic_lk_21_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_21_01.Name = "pic_lk_21_01";
            this.pic_lk_21_01.TabStop = false;
            this.pic_lk_21_01.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_21_02
            // 
            resources.ApplyResources(this.pic_lk_21_02, "pic_lk_21_02");
            this.pic_lk_21_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_21_02.Name = "pic_lk_21_02";
            this.pic_lk_21_02.TabStop = false;
            this.pic_lk_21_02.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_22
            // 
            resources.ApplyResources(this.pic_lk_22, "pic_lk_22");
            this.pic_lk_22.BackColor = System.Drawing.Color.Transparent;
            this.pic_lk_22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_22.Name = "pic_lk_22";
            this.pic_lk_22.TabStop = false;
            this.pic_lk_22.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_uzr
            // 
            resources.ApplyResources(this.pic_uzr, "pic_uzr");
            this.pic_uzr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_uzr.Name = "pic_uzr";
            this.pic_uzr.TabStop = false;
            this.pic_uzr.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_15
            // 
            resources.ApplyResources(this.pic_lk_15, "pic_lk_15");
            this.pic_lk_15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_15.Name = "pic_lk_15";
            this.pic_lk_15.TabStop = false;
            this.pic_lk_15.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_9b
            // 
            resources.ApplyResources(this.pic_lk_9b, "pic_lk_9b");
            this.pic_lk_9b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_9b.Name = "pic_lk_9b";
            this.pic_lk_9b.TabStop = false;
            this.pic_lk_9b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_9a
            // 
            resources.ApplyResources(this.pic_lk_9a, "pic_lk_9a");
            this.pic_lk_9a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_9a.Name = "pic_lk_9a";
            this.pic_lk_9a.TabStop = false;
            this.pic_lk_9a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_10b
            // 
            resources.ApplyResources(this.pic_lk_10b, "pic_lk_10b");
            this.pic_lk_10b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_10b.Name = "pic_lk_10b";
            this.pic_lk_10b.TabStop = false;
            this.pic_lk_10b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_10a
            // 
            resources.ApplyResources(this.pic_lk_10a, "pic_lk_10a");
            this.pic_lk_10a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_10a.Name = "pic_lk_10a";
            this.pic_lk_10a.TabStop = false;
            this.pic_lk_10a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_vo_2
            // 
            resources.ApplyResources(this.pic_vo_2, "pic_vo_2");
            this.pic_vo_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_vo_2.Name = "pic_vo_2";
            this.pic_vo_2.TabStop = false;
            this.pic_vo_2.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_vo_1
            // 
            resources.ApplyResources(this.pic_vo_1, "pic_vo_1");
            this.pic_vo_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_vo_1.Name = "pic_vo_1";
            this.pic_vo_1.TabStop = false;
            this.pic_vo_1.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_11b
            // 
            resources.ApplyResources(this.pic_lk_11b, "pic_lk_11b");
            this.pic_lk_11b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_11b.Name = "pic_lk_11b";
            this.pic_lk_11b.TabStop = false;
            this.pic_lk_11b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_11a
            // 
            resources.ApplyResources(this.pic_lk_11a, "pic_lk_11a");
            this.pic_lk_11a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_11a.Name = "pic_lk_11a";
            this.pic_lk_11a.TabStop = false;
            this.pic_lk_11a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_8b
            // 
            resources.ApplyResources(this.pic_lk_8b, "pic_lk_8b");
            this.pic_lk_8b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_8b.Name = "pic_lk_8b";
            this.pic_lk_8b.TabStop = false;
            this.pic_lk_8b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_8a
            // 
            resources.ApplyResources(this.pic_lk_8a, "pic_lk_8a");
            this.pic_lk_8a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_8a.Name = "pic_lk_8a";
            this.pic_lk_8a.TabStop = false;
            this.pic_lk_8a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_dm_4
            // 
            resources.ApplyResources(this.pic_dm_4, "pic_dm_4");
            this.pic_dm_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_dm_4.Name = "pic_dm_4";
            this.pic_dm_4.TabStop = false;
            this.pic_dm_4.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_dm_3
            // 
            resources.ApplyResources(this.pic_dm_3, "pic_dm_3");
            this.pic_dm_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_dm_3.Name = "pic_dm_3";
            this.pic_dm_3.TabStop = false;
            this.pic_dm_3.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_dm_2
            // 
            resources.ApplyResources(this.pic_dm_2, "pic_dm_2");
            this.pic_dm_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_dm_2.Name = "pic_dm_2";
            this.pic_dm_2.TabStop = false;
            this.pic_dm_2.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_dm_1
            // 
            resources.ApplyResources(this.pic_dm_1, "pic_dm_1");
            this.pic_dm_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_dm_1.Name = "pic_dm_1";
            this.pic_dm_1.TabStop = false;
            this.pic_dm_1.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_6b
            // 
            resources.ApplyResources(this.pic_lk_6b, "pic_lk_6b");
            this.pic_lk_6b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_6b.Name = "pic_lk_6b";
            this.pic_lk_6b.TabStop = false;
            this.pic_lk_6b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_6a
            // 
            resources.ApplyResources(this.pic_lk_6a, "pic_lk_6a");
            this.pic_lk_6a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_6a.Name = "pic_lk_6a";
            this.pic_lk_6a.TabStop = false;
            this.pic_lk_6a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_5_b
            // 
            resources.ApplyResources(this.pic_lk_5_b, "pic_lk_5_b");
            this.pic_lk_5_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_5_b.Name = "pic_lk_5_b";
            this.pic_lk_5_b.TabStop = false;
            this.pic_lk_5_b.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_5_a
            // 
            resources.ApplyResources(this.pic_lk_5_a, "pic_lk_5_a");
            this.pic_lk_5_a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_5_a.Name = "pic_lk_5_a";
            this.pic_lk_5_a.TabStop = false;
            this.pic_lk_5_a.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_3_4
            // 
            resources.ApplyResources(this.pic_lk_3_4, "pic_lk_3_4");
            this.pic_lk_3_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_3_4.Name = "pic_lk_3_4";
            this.pic_lk_3_4.TabStop = false;
            this.pic_lk_3_4.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_lk_1_2
            // 
            resources.ApplyResources(this.pic_lk_1_2, "pic_lk_1_2");
            this.pic_lk_1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lk_1_2.Name = "pic_lk_1_2";
            this.pic_lk_1_2.TabStop = false;
            this.pic_lk_1_2.Click += new System.EventHandler(this.pic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.MainDescr);
            this.Controls.Add(this.btTurn);
            this.Controls.Add(this.bt_CleanForm);
            this.Controls.Add(this.bt_main_mod);
            this.Controls.Add(this.bt_main_stop);
            this.Controls.Add(this.bt_main_start);
            this.Controls.Add(this.data_start);
            this.Controls.Add(this.l_data);
            this.Controls.Add(this.time_main_end);
            this.Controls.Add(this.l_time_end);
            this.Controls.Add(this.l_time_begin);
            this.Controls.Add(this.time_main_begin);
            this.Controls.Add(this.pic_lk_16);
            this.Controls.Add(this.pic_lk_18);
            this.Controls.Add(this.pic_lk_12);
            this.Controls.Add(this.pic_lk_13);
            this.Controls.Add(this.pic_lk_20);
            this.Controls.Add(this.pic_lk_21_01);
            this.Controls.Add(this.pic_lk_21_02);
            this.Controls.Add(this.pic_lk_22);
            this.Controls.Add(this.pic_uzr);
            this.Controls.Add(this.pic_lk_15);
            this.Controls.Add(this.pic_lk_9b);
            this.Controls.Add(this.pic_lk_9a);
            this.Controls.Add(this.pic_lk_10b);
            this.Controls.Add(this.pic_lk_10a);
            this.Controls.Add(this.pic_vo_2);
            this.Controls.Add(this.pic_vo_1);
            this.Controls.Add(this.pic_lk_11b);
            this.Controls.Add(this.pic_lk_11a);
            this.Controls.Add(this.pic_lk_8b);
            this.Controls.Add(this.pic_lk_8a);
            this.Controls.Add(this.pic_dm_4);
            this.Controls.Add(this.pic_dm_3);
            this.Controls.Add(this.pic_dm_2);
            this.Controls.Add(this.pic_dm_1);
            this.Controls.Add(this.pic_lk_6b);
            this.Controls.Add(this.pic_lk_6a);
            this.Controls.Add(this.pic_lk_5_b);
            this.Controls.Add(this.pic_lk_5_a);
            this.Controls.Add(this.pic_lk_3_4);
            this.Controls.Add(this.pic_lk_1_2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_21_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_21_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_uzr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_9b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_9a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_10b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_10a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vo_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vo_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_11b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_11a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_8b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_8a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dm_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_6b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_6a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_5_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_5_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_3_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lk_1_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private my_picBox pic_vo_1;
        private my_picBox pic_vo_2;
        private my_picBox pic_lk_1_2;
        private my_picBox pic_lk_3_4;
        private my_picBox pic_lk_5_a;
        private my_picBox pic_lk_5_b;
        private my_picBox pic_lk_6a;
        private my_picBox pic_lk_6b;
        private my_picBox pic_dm_1;
        private my_picBox pic_dm_2;
        private my_picBox pic_dm_3;
        private my_picBox pic_dm_4;
        private my_picBox pic_lk_8a;
        private my_picBox pic_lk_8b;
        private my_picBox pic_lk_11a;
        private my_picBox pic_lk_11b;
        private my_picBox pic_lk_10a;
        private my_picBox pic_lk_10b;
        private my_picBox pic_lk_9a;
        private my_picBox pic_lk_9b;
        private my_picBox pic_lk_15;
        private my_picBox pic_lk_22;
        private my_picBox pic_lk_21_02;
        private my_picBox pic_lk_21_01;
        private my_picBox pic_uzr;
        private my_picBox pic_lk_20;
        private my_picBox pic_lk_13;
        private my_picBox pic_lk_12;
        private my_picBox pic_lk_18;
        private my_picBox pic_lk_16;
        private my_time time_main_begin;
        private System.Windows.Forms.Label l_time_begin;
        private System.Windows.Forms.Label l_time_end;
        private my_time time_main_end;
        private System.Windows.Forms.Label l_data;
        private my_time data_start;
        private System.Windows.Forms.Button bt_main_start;
        private System.Windows.Forms.Button bt_main_stop;
        private System.Windows.Forms.Button bt_main_mod;
        private System.Windows.Forms.Button bt_CleanForm;
        private System.Windows.Forms.Button btTurn;
        private my_LinkLibel MainDescr;
    }

    public class dinamic_time_forms
    {
        public System.Windows.Forms.Label label_begin;
        public System.Windows.Forms.Label label_end;
        public my_time data_begin;
        public my_time time_begin;
        public my_time time_end;

        public my_time main_time_begin;
        public my_time main_time_end;


        public System.Windows.Forms.Button botton_remove;

        public my_LinkLibel botton_link;

        public System.Windows.Forms.Control.ControlCollection _Control;

        public MainForm _mainform;

        public bool undo_elements = false;

        public my_time add_elements_time_downs(my_time im_src)
        {
            my_time re_trg = new my_time();

            re_trg.Font = new System.Drawing.Font(im_src.Font, im_src.Font.Style);
            re_trg.Format = im_src.Format;
            re_trg.CustomFormat = im_src.CustomFormat;
            re_trg.Location = new System.Drawing.Point(im_src.Location.X, im_src.Location.Y + 50);
            re_trg.Size = new System.Drawing.Size(im_src.Size.Width, im_src.Height);
            re_trg.Anchor = im_src.Anchor;
            re_trg.ShowUpDown = im_src.ShowUpDown;
            re_trg.Value = im_src.Value;
            return re_trg;
        }

        public void add_element_link_label(System.Windows.Forms.LinkLabel im_src, System.Collections.ArrayList im_curr_work_list = null,System.Collections.ArrayList im_all_works_elements = null) {

            if (im_curr_work_list == null) {
                return;
            }

            if (im_all_works_elements == null)
            {
                return;
            }

            my_LinkLibel re_LinkLabel = new my_LinkLibel();

            re_LinkLabel.ActiveLinkColor = im_src.ActiveLinkColor;
            re_LinkLabel.LinkColor = im_src.LinkColor;
            re_LinkLabel.VisitedLinkColor = im_src.VisitedLinkColor;
            re_LinkLabel.Font = new System.Drawing.Font(im_src.Font, im_src.Font.Style);
            re_LinkLabel.Location = new System.Drawing.Point(im_src.Location.X, im_src.Location.Y + 50);
            re_LinkLabel.Size = new System.Drawing.Size(im_src.Size.Width, im_src.Height);
            re_LinkLabel.Anchor = im_src.Anchor;

            re_LinkLabel.curr_work_list = im_curr_work_list;
            re_LinkLabel.all_work_elements = im_all_works_elements;

            re_LinkLabel.Text = im_src.Text;

            re_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.show_array_alements);

            botton_link = re_LinkLabel;
            botton_link.remove_botton = botton_remove;

            _Control.Add(botton_link);
        }


        public void show_array_alements(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {

            ShowWorksElement ShowLinkWorksElement = new ShowWorksElement((System.Collections.ArrayList)botton_link.curr_work_list, _mainform,this.botton_link, (System.Collections.ArrayList)botton_link.all_work_elements);
            ShowLinkWorksElement.Show();
        }


        public System.Windows.Forms.Label add_elements_label_downs(System.Windows.Forms.Label im_src)
        {
            System.Windows.Forms.Label re_trg = new System.Windows.Forms.Label();

            re_trg.Font = new System.Drawing.Font(im_src.Font, im_src.Font.Style);
            re_trg.ForeColor = im_src.ForeColor;
            re_trg.Location = new System.Drawing.Point(im_src.Location.X, im_src.Location.Y + 50);
            re_trg.Size = new System.Drawing.Size(im_src.Size.Width, im_src.Height);
            re_trg.Anchor = im_src.Anchor;
            re_trg.Text = im_src.Text;

            return re_trg;
        }

        public void value_revers_time(my_time im_src, my_time im_trg) {
            im_trg.Value = im_src.Value;

        }

        public void add_button_right_time(my_time im_right_element)
        {
            System.Windows.Forms.Button re_button = new System.Windows.Forms.Button();

            re_button.Location = new System.Drawing.Point(im_right_element.Location.X + 100, im_right_element.Location.Y);
            re_button.Size = new System.Drawing.Size(38, im_right_element.Size.Height);
            re_button.Anchor = im_right_element.Anchor;

            //            re_button.Image=new

            re_button.BackColor = System.Drawing.Color.White;
            re_button.Cursor = System.Windows.Forms.Cursors.Hand;
            re_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            re_button.FlatAppearance.BorderSize = 0;
            re_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;

            try
            {

                re_button.Image = System.Drawing.Image.FromFile("undo_24.ico");
            }
            catch (Exception)
            {

            }

            re_button.Click += new System.EventHandler(this.remove_element);

            botton_remove = re_button;

            _Control.Add(re_button);

            // return re_button;
        }


        public void remove_element(object sender, System.EventArgs e) {

            if (this._mainform.enable_history)
            {

                System.Windows.Forms.MessageBox.Show("Режим формы \"Исторические значения \".\n Изменения запрещены!", "Режим работы формы", System.Windows.Forms.MessageBoxButtons.OK , System.Windows.Forms.MessageBoxIcon.Warning);

                return;
            }

            _Control.Remove((System.Windows.Forms.Button)sender);

            _Control.Remove(label_begin);
            _Control.Remove(label_end);
            _Control.Remove(time_begin);
            _Control.Remove(time_end);
            _Control.Remove(botton_link);


            _mainform.mod_time_array.Remove(this);

            if (_mainform.mod_time_array.Count > 0)
            {
                dinamic_time_forms last_element_array_time = (dinamic_time_forms)_mainform.mod_time_array[_mainform.mod_time_array.Count - 1];

                last_element_array_time.time_end.Enabled = !last_element_array_time.time_end.Enabled;
                // Установка фокуса
                last_element_array_time.time_end.Focus();

                if (last_element_array_time.botton_remove != null)
                {
                    last_element_array_time.botton_remove.Enabled = !last_element_array_time.botton_remove.Enabled;
                }
            } else
            {
                this.main_time_begin.Enabled = !this.main_time_begin.Enabled;
                this.main_time_end.Enabled = !this.main_time_end.Enabled;

            }

            //list_wokrs_main
            
            if (this._mainform.list_wokrs_main.Count > 0)
            {
                System.Collections.ArrayList _remove_last_array = (System.Collections.ArrayList)this._mainform.list_wokrs_main[this._mainform.list_wokrs_main.Count - 1];

                foreach (wokrs_element element_undo in _remove_last_array)
                {
                    element_undo.undo_change_form_pic_delete();
                }

                this._mainform.list_wokrs_main.Remove(_remove_last_array);

                System.Collections.ArrayList _last_works_array = (System.Collections.ArrayList)this._mainform.list_wokrs_main[this._mainform.list_wokrs_main.Count - 1];

                foreach (wokrs_element element_undo in _last_works_array)
                {
                    element_undo.undo_change_form_pic();
                }


            }

            undo_elements = true;
        }

    }


    public class my_time : System.Windows.Forms.DateTimePicker
    {


    }

    public class my_LinkLibel : System.Windows.Forms.LinkLabel
    {
        public System.Collections.ArrayList curr_work_list = null;
        public System.Collections.ArrayList all_work_elements = null;
        public System.Collections.ArrayList works_elements = new System.Collections.ArrayList();

        public System.Windows.Forms.Button remove_botton = null;

        public bool history_remove_button = false;
    }



    public class wokrs_element : my_picBox
    {

        new public string tm = "";
        new public bool status_load = false;
        new public bool status_event = false;

        new public bool initial_point = false;
        new public bool end_point = false;
        new public bool transit_point = false;

        private my_picBox _pic_form;

        private System.DateTime bedin_data;
        private System.DateTime begin_time;
        private System.DateTime end_time;

        public wokrs_element(my_picBox im_object)
        {
            _pic_form = im_object;

            tm = im_object.tm;
            status_load = im_object.status_load;
            status_event = im_object.status_event;
            initial_point = im_object.initial_point;

            end_point = im_object.end_point;
            transit_point = im_object.transit_point;
        }

        public void RegistrDataStart(System.DateTime im_begin_data, System.DateTime im_begin_time) {
            bedin_data = im_begin_data;
            begin_time = im_begin_time;

        }

        public void RegistrDataEnd(System.DateTime im_end_time)
        {
            end_time    = im_end_time;
        }

        public string get_data_begin()
        {
            string _data_begin;

            _data_begin = this.bedin_data.ToString("yyyyMMdd");

            return _data_begin;
        }

        public string get_data_end()
        {
            string _data_end;

            _data_end = this.bedin_data.ToString("yyyyMMdd");

            if (this.begin_time > this.end_time )
            {
                _data_end = this.bedin_data.AddDays(1).ToString("yyyyMMdd");
            }

            return _data_end;
        }


        public string get_time_begin()
        {
            string _time_begin;

            _time_begin = this.begin_time.ToString("HHmm");

            return _time_begin;
        }

        public string get_time_end()
        {
            string _time_end;

            _time_end = this.end_time.ToString("HHmm");

            return _time_end;
        }

        public void undo_change_form_pic_delete()
        {
            _pic_form.set_initial();
        }

        public void undo_change_form_pic()
        {
            _pic_form.set_initial();
            //_pic_form.status_load   = true;
            _pic_form.status_event  = true;
            _pic_form.set_wokrs();
    }

}

    public class my_picBox : System.Windows.Forms.PictureBox {
        public MainForm _mainform;

        public string tm = "";
        public bool status_load = false;
        public bool status_event = false;

        public bool initial_point = false;
        public bool end_point = false;
        public bool transit_point = false;

        public int count_parent = 0;

        public my_picBox[] parentTM;

        private int count_parent_tm_array = 0;
        
        public void history_img()
        {
            try
            {

                this.Image = System.Drawing.Image.FromFile(this.tm + "_YELOW.PNG"); //меняем картинку
            }
            catch (Exception)
            {

            }
        }

        public void init_img() {
            try
            {

                this.Image = System.Drawing.Image.FromFile(this.tm + "_BLUE.PNG"); //меняем картинку
            }
            catch (Exception)
            {

            }
        }

        public void init_parentTM(int im_count)
        {
            parentTM = new my_picBox[im_count];
        }


        public void add_parent(my_picBox im_tm) {
            parentTM[count_parent_tm_array] = im_tm;
            count_parent_tm_array++;
        }

        public void set_wokrs()
        {
            if (!this.status_load)
            {
                if (this.status_event)
                {
                    this.status_load = true;
                    try
                    {

                        this.Image = System.Drawing.Image.FromFile(this.tm + "_GREEN.PNG"); //меняем картинку
                    }
                    catch (Exception)
                    {

                    }

                }
            }
        }

        public void set_initial()
        {
            this.status_load = false;
            this.status_event = false;
            this.init_img();
        }


    public void set_pic_event() {
            if (!this.status_load)
            {
                if (!this.status_event)
                {
                    this.status_event = true;

                    try{
                        this.Image = System.Drawing.Image.FromFile(this.tm + "_RED.PNG"); //меняем картинку

                    }catch (Exception){

                    }

                    _mainform.list_works_curent.Add(this);

                }
                else
                {
                    this.status_event = false;
                    this.init_img();
                    _mainform.list_works_curent.Remove(this);
                }
            }
            else
            {
                if (this.status_event)
                {
                    this.status_load = false;
                    this.status_event = false;

                    this.init_img();

                    _mainform.list_works_curent.Remove(this);
                }

            }

        }

    }

    [DataContract(Namespace = "ctp-config")] 
    public class config_integration {
        [DataMember] public string direct_exchange = "";
        [DataMember] public string path_save        = "SET_HOURS";
        [DataMember] public string uri              = "uri:faulty-knowledge-equipment";
        [DataMember] public string uid_handler      = "cba162f7-8c63-11e6-82a1-6c3be51ac8bc";
        [DataMember] public string url_soap         = "";

    }


    public class integration_1c
    {

        private string _path_config = "CONF";
        private string _path_file_config = "system_form.conf";

        private config_integration _config_integration;

        public bool isInitialized = false;

        ws_exchange_form.ExchangeDataDevelopmentsForm iSOAP = new ws_exchange_form.ExchangeDataDevelopmentsForm();

        public System.Collections.ArrayList Parametrs = new System.Collections.ArrayList();

        public integration_1c()
        {

            string MessageErrorFileIntegration              = "Нет файла настройки для интегруции с 1C\n Работа приложения в демо режиме.";
            string MessageErrorFileIntegration_serialise    = "Ошибка чтения файла настройки для интегруции с 1C!\n Работа приложения в демо режиме.";
            string CaptionMessage                           = "Предупреждение";


            string[] chek_type_exchange = new string[] { "SOAP", "FILE" };

            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK;

            // Есть ли папка с настройками
            if (!System.IO.Directory.Exists(_path_config))
            {
                // нет папки и нет наработки, тут возвращаем ошибку и сообщаем об этом пользователю после выхода
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            string _path_set_config = System.IO.Path.GetFullPath(this._path_config);

            // Получим значения из настройки. Если файла не будет то ошибку!!! И в демо режим

            config_integration iconfig_integration = new config_integration();

            string _filename_integration = _path_set_config + "\\" + this._path_file_config;

            if (!System.IO.File.Exists(_filename_integration))
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            var iParametrs_confObject = new DataContractSerializer( typeof(config_integration));


            Stream FileConfig =     File.OpenRead(_filename_integration);

            try
            {

                iconfig_integration = (config_integration)iParametrs_confObject.ReadObject(FileConfig); // Десериализация
                FileConfig.Close();

            }
            catch (Exception )
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                FileConfig.Close();
                return;

            }

            if ( ( iconfig_integration.uri == null ) || (iconfig_integration.uid_handler == null) || (iconfig_integration.path_save == null) )
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            if ((iconfig_integration.uri == "") || (iconfig_integration.uid_handler == "") || (iconfig_integration.path_save == "") || (iconfig_integration.direct_exchange == "") )
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            if  (Array.IndexOf(chek_type_exchange,iconfig_integration.direct_exchange) == -1 )
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            //            if ((iconfig_integration.direct_exchange.ToString().Trim() != "SOAP".ToString() ) ) ||  (iconfig_integration.direct_exchange.ToString().ToUpper().Trim() != "FILE") )
            //            {
            //                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
            //                return;
            //            }

            // Теперь если все ок. Провеим и папку куда писать наработку .... :-)
            string temp_path = System.IO.Path.GetFullPath(iconfig_integration.path_save);
            if (!System.IO.Directory.Exists(temp_path))
            {
                System.Windows.Forms.MessageBox.Show(MessageErrorFileIntegration_serialise, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            this._config_integration = iconfig_integration;

            this.isInitialized = true;

        }

        // Самое главное проверяем на волидность данных полученных из 1С о состоянии оборудования.
        public System.Collections.ArrayList get()
        {
            System.Collections.ArrayList _wokrsElement = new System.Collections.ArrayList();

            // Тут проверяем файл и смотрим на то есть ли он, дальше будем его считывать и проверять состоянии ТМ на корректность работы



            return _wokrsElement;
        }

        public void set( System.Collections.ArrayList im_array_data)
        {


            // Тут проверим что у нас в масивах и начинаем формировать данне для передачи в 1С по SAOP . Причем делаем передачу асинхронно.
            // Будем проверять билеты на кооректность получения данных. Но прежде чем передать в 1С пишем все в пакеты передачи то есть в XML формат. После того проверим на волидность передачи. Но это все в отдельном транше
            // Самое главное проверяем на волидность данных полученных из 1С о состоянии оборудования.

            // И так начнем.

            if (!this.isInitialized) {
                return;
            }


            string _path_set    = this._config_integration.path_save; //"SET_HOURS";
            string _path_set_file;

            string uri          = this._config_integration.uri;
            string uid_handler  = this._config_integration.uid_handler;



            // Так ошибки нет, значит формируем файл . Маска фыйла это UID посылки
            // Значит надо его получить и трансформировать в название файла
            System.Guid _UID = System.Guid.NewGuid();
            string sUID = _UID.ToString();

            _path_set = System.IO.Path.GetFullPath(_path_set);
            _path_set_file = _path_set + "\\" + sUID + ".xml";

            if (this._config_integration.direct_exchange == "SOAP")
            {
                iSOAP.Url = this._config_integration.url_soap;
            }

            // тут переделываем весь механизм выгрузки данных. Но делаем все по универсальной схеме :-)

            ws_exchange_form.im_data im_parametr = new ws_exchange_form.im_data();

            im_parametr.DATA_CREATE     = "19000101000000";
            im_parametr.DEPATMENT       = "CTP";
            im_parametr.UID             = sUID;
            im_parametr.UID_HANDLER     = uid_handler;
            im_parametr.WOKRS           = "RGRES";
            im_parametr.DIRECT          = "SET";

            if (Parametrs.Count > 0)
            {
                foreach (StractParametrs1CIntegration iParametrs in Parametrs)
                {
                    if (iParametrs.NameParametrs == "DATA_CREATE")
                    {
                        System.DateTime iDataBegin = (System.DateTime)iParametrs.ValueParametrs;
                        im_parametr.DATA_CREATE = iDataBegin.ToString("yyyyMMdd") + "000000";
                    }
                }
            }

            ws_exchange_form.WA_RUN[] temp_run = new ws_exchange_form.WA_RUN[im_array_data.Count];

            int _count_run = 1;
            // Тут по цикла бежим массива и получаем массив точек
            foreach (System.Collections.ArrayList wokrs_hours in im_array_data )
            {
                ws_exchange_form.WA_TM[] temp_tm = new ws_exchange_form.WA_TM[wokrs_hours.Count];

                int _count_tm = 0;
                _count_tm = 0;
                foreach ( wokrs_element _works_element in wokrs_hours)
                {
                    temp_tm[_count_tm] = new ws_exchange_form.WA_TM();
                    temp_tm[_count_tm].TM_NAME          = _works_element.tm.ToString(); ;
                    temp_tm[_count_tm].TM_DATE_BEGIN    = _works_element.get_data_begin().ToString();
                    temp_tm[_count_tm].TM_TIME_BEGIN    = _works_element.get_time_begin().ToString();
                    temp_tm[_count_tm].TM_DATE_END      = _works_element.get_data_end().ToString();
                    temp_tm[_count_tm].TM_TIME_END      = _works_element.get_time_end().ToString();
                    _count_tm++;

                }

                temp_run[_count_run-1] = new ws_exchange_form.WA_RUN();
                temp_run[_count_run-1].NUMBER = _count_run.ToString();

                temp_run[_count_run - 1].TM = temp_tm;

                _count_run++;
            }

            im_parametr.RUN = temp_run;

            // тут или передача, или запись в файл что в настройке

            XmlSerializer SZ_IM_DATA = new XmlSerializer(typeof(ws_exchange_form.im_data));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            ns.Add("uri", this._config_integration.uri);


            if (this._config_integration.direct_exchange == "FILE")
            {

                StreamWriter Writer_XML = new StreamWriter(_path_set_file);
                SZ_IM_DATA.Serialize(Writer_XML, im_parametr, ns);
                Writer_XML.Close();

            }

            if (this._config_integration.direct_exchange == "SOAP")
            {
                ws_exchange_form.WA_RETURN[] re_return = iSOAP.set(im_parametr);

                foreach (ws_exchange_form.WA_RETURN Message in re_return)
                {

                    System.Windows.Forms.MessageBoxIcon iCon = new System.Windows.Forms.MessageBoxIcon();
                    if (Message.STATUS == "E")
                    {
                        iCon = System.Windows.Forms.MessageBoxIcon.Error;

                    }
                    else
                    {
                        iCon = System.Windows.Forms.MessageBoxIcon.Information;
                    }

                    System.Windows.Forms.MessageBox.Show(Message.MESSAGE.ToString(), "Результат синхронизации", System.Windows.Forms.MessageBoxButtons.OK, iCon);

                }

            }


        }


    }

    public class StractParametrs1CIntegration
    {
        public string NameParametrs;
        public object ValueParametrs;
    }

    public class ShowWorksElement {
        private System.Collections.ArrayList _curr_array_element = new System.Collections.ArrayList();
        private MainForm _mainForm;
        private my_LinkLibel _LinkElemrnt;
        private System.Windows.Forms.Form _ShowWorksElement;

        private System.Collections.ArrayList _all_works_element = new System.Collections.ArrayList();

        private System.Collections.ArrayList _curr_works = new System.Collections.ArrayList();


        public ShowWorksElement(System.Collections.ArrayList im_curr_element = null, MainForm im_mainForm = null, my_LinkLibel im_LinkElemrnt = null, System.Collections.ArrayList im_all_works_element = null) {
            if (im_curr_element == null) {
                return;
            }

            if (im_mainForm == null){
                return;
            }

            if (im_LinkElemrnt == null){
                return;
            }

            if (im_all_works_element == null)
            {
                return;
            }

            _curr_array_element = im_curr_element;
            _mainForm = im_mainForm;
            _LinkElemrnt = im_LinkElemrnt;

            _all_works_element = im_all_works_element;

        }

        public void Show() {

            if ((_mainForm.enable_history) && !(_LinkElemrnt.LinkVisited))
            {
                return;
            }

            _ShowWorksElement = new System.Windows.Forms.Form();


            _LinkElemrnt.LinkVisited = !_LinkElemrnt.LinkVisited;
            _mainForm.enable_history = !_mainForm.enable_history;

            System.Windows.Forms.Control[] temp_find_element;

            temp_find_element = _mainForm.Controls.Find("bt_main_stop", true);

            if (temp_find_element.Length > 0)
            {
                System.Windows.Forms.Button bt_main_stop = (System.Windows.Forms.Button)temp_find_element[0];
                bt_main_stop.Enabled = !bt_main_stop.Enabled;
            }


            temp_find_element = _mainForm.Controls.Find("bt_main_mod", true);

            if (temp_find_element.Length > 0)
            {
                System.Windows.Forms.Button bt_main_mod = (System.Windows.Forms.Button)temp_find_element[0];
                bt_main_mod.Enabled = !bt_main_mod.Enabled;
            }


            temp_find_element = _mainForm.Controls.Find("bt_CleanForm", true);

            if (temp_find_element.Length > 0)
            {
                System.Windows.Forms.Button bt_CleanForm = (System.Windows.Forms.Button)temp_find_element[0];
                bt_CleanForm.Enabled = !bt_CleanForm.Enabled;
            }

            if ((!(_LinkElemrnt.remove_botton == null)) && (_LinkElemrnt.remove_botton.Enabled))
            {
                _LinkElemrnt.history_remove_button = true;

            }


            // Тут надо пробежаться и скопировать текущее положение дел
            // После того как проверим на кнопку. что с ней не так

            if (_LinkElemrnt.LinkVisited)
            {

                if (!(_LinkElemrnt.remove_botton == null))
                {
                    _LinkElemrnt.remove_botton.Enabled = !_LinkElemrnt.LinkVisited;
                }

                _LinkElemrnt.works_elements.Clear();
                // Запустим на то что есть и подсветим, потом обратно
                foreach (my_picBox var_pic_element in _all_works_element)
                {
                    my_picBox _temp_single = new my_picBox();

                    _temp_single.tm = var_pic_element.tm;
                    _temp_single.Image = var_pic_element.Image;

                    _LinkElemrnt.works_elements.Add(_temp_single);

                    var_pic_element.init_img();

                    var_pic_element.Enabled = !var_pic_element.Enabled;

                }

                foreach (my_picBox var_pic_element in _all_works_element)
                {
                    foreach (wokrs_element _works_element in _curr_array_element)
                    {
                        if (_works_element.tm.ToString() == var_pic_element.tm.ToString())
                        {
                            var_pic_element.history_img();
                        }
                    }

                }

            }
            else
            {

                if ((!(_LinkElemrnt.remove_botton == null)) && (_LinkElemrnt.history_remove_button))
                {
                    _LinkElemrnt.remove_botton.Enabled = !_LinkElemrnt.LinkVisited;

                    _LinkElemrnt.history_remove_button = false;
                }


                foreach (my_picBox var_pic_element in _all_works_element)
                {
                    var_pic_element.Enabled = !var_pic_element.Enabled;
                    foreach (my_picBox _works_element in _LinkElemrnt.works_elements)
                    {
                        if (_works_element.tm.ToString() == var_pic_element.tm.ToString())
                        {
                            var_pic_element.Image = _works_element.Image;
                        }
                    }

                }
                _LinkElemrnt.works_elements.Clear();
            }

            //string temp_tm = "";


            //    foreach (my_picBox var_pic_element in _all_works_element)
            //    {
            //    temp_tm += "," + var_pic_element.tm;

            //    }



            //int Lengt_Show = 0;
            //if ((temp_tm.Length * 10) < 300)
            //{
            //    Lengt_Show = 300;
            //}
            //else
            //{
            //    Lengt_Show = temp_tm.Length * 10;
            //}

            //int _Y = 6;

            //System.Windows.Forms.Label re_text = new System.Windows.Forms.Label();

            //re_text.ForeColor = System.Drawing.Color.Red;
            //re_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold);
            //re_text.Location = new System.Drawing.Point(10, _Y);
            //re_text.Size = new System.Drawing.Size(temp_tm.Length * 10 - 30, 30);
            ////re_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            //re_text.Text = temp_tm;

            //_ShowWorksElement.Location = new System.Drawing.Point(_LinkElemrnt.Location.X - (Lengt_Show + 2), _LinkElemrnt.Location.Y);
            //_ShowWorksElement.DesktopLocation = _ShowWorksElement.Location;
            //_ShowWorksElement.Anchor = _LinkElemrnt.Anchor;
            //_ShowWorksElement.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            //_ShowWorksElement.Size = new System.Drawing.Size(Lengt_Show, 20);
            ////ShowWorksElement.BackColor = _mainForm.BackColor;
            //_ShowWorksElement.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //System.Windows.Forms.Button re_button_close = new System.Windows.Forms.Button();

            //re_button_close.Location = new System.Drawing.Point(Lengt_Show - 30, _Y);
            //re_button_close.BackColor = System.Drawing.Color.White;
            //re_button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            //re_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //re_button_close.FlatAppearance.BorderSize = 0;
            //re_button_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            //re_button_close.Size = new System.Drawing.Size(30, 30);
            //re_button_close.Text = "X";
            //re_button_close.Click += new System.EventHandler(this.CloseForm);

            //_ShowWorksElement.Controls.Add(re_button_close);
            //_ShowWorksElement.Controls.Add(re_text);

            //_ShowWorksElement.ShowDialog(_mainForm);

        }

        public void CloseForm(object sender, System.EventArgs e) {
            _ShowWorksElement.Close();

            _ShowWorksElement = null;
        }

        private void show_pic()
        {
            // надо пробежаться по элементам и в них установить значение в зеленный свет/ в какой то другой отличный от крассного


        }

        private void restore_pic() {


        }

    }

}

    