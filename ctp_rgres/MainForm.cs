using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ctp_rgres
{
    public partial class MainForm : Form
    {

        string MessageTimeDiff = "Введенныя дата завершения больше даты начало, \n уверенны что работа схемы переходит на другие сутки?";
        string CaptionMessage = "Предупреждение";


        private integration_1c _integration_1c = new integration_1c();



        public struct LS_TimeEnd
        {
            public DateTime data_begin;
            public DateTime time_begin;
            public DateTime time_end;
        }


        private bool SendDataForm( string direct = "STOP")
        {
            bool _result = false;

            if (direct == "CLEAR")
            {
                if (bt_main_start.Enabled)
                {

                    data_start.Value = DateTime.Now;

                    time_main_begin.Value = DateTime.Now;
                    time_main_end.Value = DateTime.Now;


                    // Очистить все
                    foreach (my_picBox var_reload_pic in all_list_works)
                    {
                        var_reload_pic.set_initial();
                    }


                    return true;
                }
            }

            bt_main_start.Enabled = !bt_main_start.Enabled;
            bt_main_stop.Enabled = !bt_main_stop.Enabled;
            bt_main_mod.Enabled = !bt_main_mod.Enabled;
            MainDescr.Enabled = !MainDescr.Enabled;

            data_start.Enabled = !data_start.Enabled;
            time_main_begin.Enabled = !time_main_begin.Enabled;


            // Отменим все эелементы на форме и откроем основные на изменение

            foreach (dinamic_time_forms var_remove_elements in mod_time_array)
            {
                Controls.Remove(var_remove_elements.label_begin);
                Controls.Remove(var_remove_elements.label_end);
                Controls.Remove(var_remove_elements.time_begin);
                Controls.Remove(var_remove_elements.time_end);
                Controls.Remove(var_remove_elements.time_end);
                Controls.Remove(var_remove_elements.botton_remove);
                Controls.Remove(var_remove_elements.botton_link);

            }
            // Тут мы определяем на масиве работы кто у нас посдений для массива
            RegistrationWorksElementEndDate();

            if ( direct == "STOP" )
            {
                // Тут передача в 1С данных из массива

                DateTime iTempDateCreate;
                iTempDateCreate = data_start.Value;

                StractParametrs1CIntegration iParametrs1c = new StractParametrs1CIntegration();

                _integration_1c.Parametrs.Clear();

                iParametrs1c.NameParametrs = "DATA_CREATE";
                iParametrs1c.ValueParametrs = iTempDateCreate;

                _integration_1c.Parametrs.Add(iParametrs1c);

                //_integration_1c.Parametrs.Add();
                _integration_1c.set(list_wokrs_main);
            }

            // Все обнуляем и начинаем с начало
            mod_time_array.Clear();
            InitArrayWokrsElement();

            foreach (my_picBox var_reload_pic in all_list_works)
            {
                var_reload_pic.set_initial();
            }


            time_main_begin.Value = DateTime.Now;
            time_main_end.Value = DateTime.Now;

            // Так же обновим и основную дату 
            data_start.Value = DateTime.Now;

            time_main_begin.Enabled = true;
            time_main_end.Enabled = true;

            return _result;
        }

        public MainForm()
        {
            InitializeComponent();

            data_start.Value = DateTime.Now;
            time_main_begin.Value = DateTime.Now;
            time_main_end.Value = DateTime.Now;

            // Тут Выставим время окончания 23.59.59
            //time_main_end.Value = time_main_end.Value.AddHours(23 - time_main_end.Value.Hour);
            //time_main_end.Value = time_main_end.Value.AddMinutes(59 - time_main_end.Value.Minute);


            bt_main_start.Enabled = true;
            bt_main_stop.Enabled = false;
            bt_main_mod.Enabled = false;

            MainDescr.Enabled = false;


            pic_vo_1.tm = "VO_1"; //
            pic_vo_1.initial_point = true;
            pic_vo_1._mainform = (MainForm)this;


            pic_vo_2.tm = "VO_2"; // 
            pic_vo_2._mainform = (MainForm)this;

            pic_lk_1_2.tm = "LK_1_2"; //
            pic_lk_1_2._mainform = (MainForm)this;

            pic_lk_3_4.tm = "LK_3_4"; //
            pic_lk_3_4._mainform = (MainForm)this;

            pic_lk_5_a.tm = "LK_5_A"; //
            pic_lk_5_a._mainform = (MainForm)this;

            pic_lk_5_b.tm = "LK_5_B"; //
            pic_lk_5_b._mainform = (MainForm)this;

            pic_lk_6a.tm = "LK_6_A"; //
            pic_lk_6a._mainform = (MainForm)this;

            pic_lk_6b.tm = "LK_6_B";
            pic_lk_6b._mainform = (MainForm)this;

            pic_dm_1.tm = "DM_1";
            pic_dm_1._mainform = (MainForm)this;

            pic_dm_2.tm = "DM_2";
            pic_dm_2._mainform = (MainForm)this;

            pic_dm_3.tm = "DM_3";
            pic_dm_3._mainform = (MainForm)this;

            pic_dm_4.tm = "DM_4";
            pic_dm_4._mainform = (MainForm)this;

            pic_lk_8a.tm = "LK_8_A";
            pic_lk_8a._mainform = (MainForm)this;

            pic_lk_8b.tm = "LK_8_B";
            pic_lk_8b._mainform = (MainForm)this;

            pic_lk_11a.tm = "LK_11_A";
            pic_lk_11a._mainform = (MainForm)this;

            pic_lk_11b.tm = "LK_11_B";
            pic_lk_11b._mainform = (MainForm)this;

            pic_lk_10a.tm = "LK_10_A";
            pic_lk_10a._mainform = (MainForm)this;

            pic_lk_10b.tm = "LK_10_B";
            pic_lk_10b._mainform = (MainForm)this;

            pic_lk_9a.tm = "LK_9_A";
            pic_lk_9a._mainform = (MainForm)this;

            pic_lk_9b.tm = "LK_9_B";
            pic_lk_9b._mainform = (MainForm)this;

            pic_lk_15.tm = "LK_15";
            pic_lk_15._mainform = (MainForm)this;

            pic_lk_22.tm = "LK_22";
            pic_lk_22._mainform = (MainForm)this;

            pic_lk_21_02.tm = "LK_21_L";
            pic_lk_21_02._mainform = (MainForm)this;

            pic_lk_21_01.tm = "LK_21_R";
            pic_lk_21_01._mainform = (MainForm)this;

            pic_uzr.tm = "UZR";
            pic_uzr._mainform = (MainForm)this;

            pic_lk_20.tm = "LK_20";
            pic_lk_20._mainform = (MainForm)this;

            pic_lk_13.tm = "LK_13";
            pic_lk_13._mainform = (MainForm)this;

            pic_lk_12.tm = "LK_12";
            pic_lk_12._mainform = (MainForm)this;

            pic_lk_18.tm = "LK_18";
            pic_lk_18._mainform = (MainForm)this;

            pic_lk_16.tm = "LK_16";
            pic_lk_16._mainform = (MainForm)this;

            pic_lk_3_4.init_parentTM(1);
            pic_lk_3_4.add_parent(pic_vo_2);

            pic_lk_5_b.init_parentTM(2);
            pic_lk_5_b.add_parent(pic_lk_3_4);
            pic_lk_5_b.add_parent(pic_vo_2);

            pic_lk_6b.init_parentTM(3);
            pic_lk_6b.add_parent(pic_lk_5_b);
            pic_lk_6b.add_parent(pic_lk_3_4);
            pic_lk_6b.add_parent(pic_vo_2);


            pic_dm_3.init_parentTM(4);
            pic_dm_3.add_parent(pic_lk_6b);
            pic_dm_3.add_parent(pic_lk_5_b);
            pic_dm_3.add_parent(pic_lk_3_4);
            pic_dm_3.add_parent(pic_vo_2);

            pic_dm_4.init_parentTM(4);
            pic_dm_4.add_parent(pic_lk_6b);
            pic_dm_4.add_parent(pic_lk_5_b);
            pic_dm_4.add_parent(pic_lk_3_4);
            pic_dm_4.add_parent(pic_vo_2);

            InitArrayWokrsElement();

        }

        private void InitArrayWokrsElement()
        {
            list_wokrs_main.Clear();

            list_works_curent.Clear();

            all_list_works.Clear();

            all_list_works.Add(pic_vo_1);
            all_list_works.Add(pic_vo_2);
            all_list_works.Add(pic_lk_1_2);
            all_list_works.Add(pic_lk_3_4);
            all_list_works.Add(pic_lk_5_a);
            all_list_works.Add(pic_lk_5_b);
            all_list_works.Add(pic_lk_6a);
            all_list_works.Add(pic_lk_6b);
            all_list_works.Add(pic_dm_1);
            all_list_works.Add(pic_dm_2);
            all_list_works.Add(pic_dm_3);
            all_list_works.Add(pic_dm_4);
            all_list_works.Add(pic_lk_8a);
            all_list_works.Add(pic_lk_8b);
            all_list_works.Add(pic_lk_11a);
            all_list_works.Add(pic_lk_11b);
            all_list_works.Add(pic_lk_10a);
            all_list_works.Add(pic_lk_10b);
            all_list_works.Add(pic_lk_9a);
            all_list_works.Add(pic_lk_9b);
            all_list_works.Add(pic_lk_15);
            all_list_works.Add(pic_lk_22);
            all_list_works.Add(pic_lk_21_02);
            all_list_works.Add(pic_lk_21_01);
            all_list_works.Add(pic_uzr);
            all_list_works.Add(pic_lk_20);
            all_list_works.Add(pic_lk_13);
            all_list_works.Add(pic_lk_12);
            all_list_works.Add(pic_lk_18);
            all_list_works.Add(pic_lk_16);

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
            // Смена изображения при условии нажатия на кнопку
            // Тут нужно проверить в каком статусу у нас сейчас объект.
            // Для этого надо создать собственный класс. В него масиив объектов которые меняются и проверять их статусы
            // Или нужно расширить переопределить класс...

            //pictureBox1.Image = System.Drawing.Image.FromFile("yourFile.jpg"); //меняем картинку

            my_picBox var_object = (my_picBox)sender;


            //            if ((var_object.tm == "DM_3") || (var_object.tm == "DM_4") || (var_object.tm == "LK_5_B"))
            //            {
            //                var_object.set_pic_event();
            //                foreach (my_picBox var_object_coolect in var_object.parentTM) {
            //                    var_object_coolect.set_pic_event();
            //                }

            //            }
            //            else
            //            {
            var_object.set_pic_event();
            //            }


        }

        private void RegistrationWorksElementEndDate(string im_direct = "")
        {
            ArrayList last_array;

            LS_TimeEnd last_end_time = GetLastTime();


            if (list_wokrs_main.Count > 0)
            {
                int _count_extract = 1;

                if (!(im_direct == "")){
                    _count_extract = 2;
                }

                last_array = (ArrayList)list_wokrs_main[list_wokrs_main.Count - _count_extract];

                foreach (wokrs_element temp_load_element in last_array)
                {
                    temp_load_element.RegistrDataEnd(last_end_time.time_end);
                }
            }
        }

        private LS_TimeEnd GetLastTime()
        {
            LS_TimeEnd TimeEnd = new LS_TimeEnd();

            if (mod_time_array.Count == 0)
            {

                TimeEnd.time_end = time_main_end.Value;
                TimeEnd.data_begin = data_start.Value;
                TimeEnd.time_begin = time_main_begin.Value;

            }
            //else if (mod_time_array.Count == 1)
            //{
            //   TimeEnd.time_end = time_main_end.Value;
            //}
            else
            {
                dinamic_time_forms last_element_array_time = (dinamic_time_forms)mod_time_array[mod_time_array.Count - 1];
                TimeEnd.time_end = last_element_array_time.time_end.Value;
                TimeEnd.data_begin = last_element_array_time.data_begin.Value;
                TimeEnd.time_begin = last_element_array_time.time_begin.Value;
            }

            return TimeEnd;
        }

        private void RegistrWorksElement(string im_direct = "")
        {
            ArrayList var_list_wokrs = new ArrayList();
            var_list_wokrs.Clear();

            foreach (my_picBox var_pic_element in list_works_curent)
            {
                if ( var_pic_element.status_event )
                {
                    DateTime var_date_begin = new DateTime();
                    DateTime var_time_begin = new DateTime();

                    var_pic_element.set_wokrs();

                    wokrs_element temp_load_element = new wokrs_element(var_pic_element);
                    if (!(im_direct != ""))
                    {
                        var_date_begin = data_start.Value;
                        var_time_begin = time_main_begin.Value;
                    }else if (im_direct == "MOVE")
                    {
                        dinamic_time_forms last_element_array_time = (dinamic_time_forms)mod_time_array[mod_time_array.Count - 1];

                        var_date_begin = last_element_array_time.data_begin.Value;//data_start.Value;
                        var_time_begin = last_element_array_time.time_begin.Value;
                    }
                    temp_load_element.RegistrDataStart(var_date_begin, var_time_begin);
                    var_list_wokrs.Add(temp_load_element);
                }
            }
            list_wokrs_main.Add(var_list_wokrs);

            if ((!(im_direct != "")))
            {
                _list_wokrs_start.Clear();
                _list_wokrs_start = var_list_wokrs;
            }
            

           // list_works_curent.Clear();
        }


        private void bt_main_start_Click(object sender, EventArgs e)
        {
            bt_main_start.Enabled = !bt_main_start.Enabled;
            bt_main_stop.Enabled = !bt_main_stop.Enabled;
            bt_main_mod.Enabled = !bt_main_mod.Enabled;
            MainDescr.Enabled = !MainDescr.Enabled;

            data_start.Enabled = !data_start.Enabled;

            time_main_begin.Enabled = !time_main_begin.Enabled;

            RegistrWorksElement();

        }


        private void bt_main_stop_Click(object sender, EventArgs e)
        {

                this.SendDataForm("STOP");
        }

        private void bt_main_mod_Click(object sender, EventArgs e)
        {
            // Тут массив оборудования до изменения и время отсчета начало и конец
            my_time var_mod_time_begin = new my_time();
            my_time var_mod_time_end = new my_time();

            Label var_mod_label_begin = new Label();
            Label var_mod_label_end = new Label();

            System.Windows.Forms.LinkLabel var_mod_LinkLabel = new System.Windows.Forms.LinkLabel();

            Button var_remove_botton = new Button();

            dinamic_time_forms element_array_time = new dinamic_time_forms();

            element_array_time._Control = Controls;
            element_array_time._mainform = (MainForm)this;
            element_array_time.main_time_begin  = time_main_begin;
            element_array_time.main_time_end    = time_main_end;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (mod_time_array.Count == 0)
            {
                //Тут проверка на разность даты
                if ( time_main_begin.Value > time_main_end.Value )
                {
                    DialogResult returnQW =  MessageBox.Show(MessageTimeDiff, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                    if (returnQW == DialogResult.No )
                    {
                        return;
                    }
                }

                var_mod_LinkLabel = MainDescr;

                var_mod_time_begin = element_array_time.add_elements_time_downs(time_main_begin);
                var_mod_time_end = element_array_time.add_elements_time_downs(time_main_end);

                var_mod_label_begin = element_array_time.add_elements_label_downs(l_time_begin);
                var_mod_label_end = element_array_time.add_elements_label_downs(l_time_end);

                element_array_time.time_begin = var_mod_time_begin;
                element_array_time.time_end = var_mod_time_end;

                element_array_time.data_begin = data_start;


                if (element_array_time.time_begin.Value > element_array_time.time_end.Value)
                {
                    element_array_time.data_begin.Value = element_array_time.data_begin.Value.AddDays(1);
                }


                element_array_time.label_begin = var_mod_label_begin;
                element_array_time.label_end = var_mod_label_end;

                element_array_time.value_revers_time(var_mod_time_end, var_mod_time_begin);

                //time_main_begin.Enabled = !time_main_begin.Enabled;
                time_main_end.Enabled = !time_main_end.Enabled;
                var_mod_time_begin.Enabled = !var_mod_time_begin.Enabled;

                element_array_time.add_button_right_time(var_mod_time_end);

                mod_time_array.Add(element_array_time);

            }
            else
            {
                dinamic_time_forms last_element_array_time = (dinamic_time_forms)mod_time_array[mod_time_array.Count - 1];

                //Тут проверка на разность даты

                if (last_element_array_time.time_begin.Value > last_element_array_time.time_end.Value)
                {
                    DialogResult returnQW = MessageBox.Show(MessageTimeDiff, CaptionMessage, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
                    if (returnQW == DialogResult.No)
                    {
                        return;
                    }

                }

                var_mod_time_begin = element_array_time.add_elements_time_downs(last_element_array_time.time_begin);
                var_mod_time_end = element_array_time.add_elements_time_downs(last_element_array_time.time_end);

                var_mod_label_begin = element_array_time.add_elements_label_downs(last_element_array_time.label_begin);
                var_mod_label_end = element_array_time.add_elements_label_downs(last_element_array_time.label_end);

                element_array_time.time_begin = var_mod_time_begin;
                element_array_time.time_end = var_mod_time_end;

                var_mod_LinkLabel = (System.Windows.Forms.LinkLabel)last_element_array_time.botton_link;


                element_array_time.data_begin = data_start;

                if (element_array_time.time_begin.Value > element_array_time.time_end.Value)
                {
                    element_array_time.data_begin.Value = element_array_time.data_begin.Value.AddDays(1);
                }

                last_element_array_time.time_end.Enabled = !last_element_array_time.time_end.Enabled;
                var_mod_time_begin.Enabled = !var_mod_time_begin.Enabled;
                if (last_element_array_time.botton_remove != null)
                {
                    last_element_array_time.botton_remove.Enabled = !last_element_array_time.botton_remove.Enabled;
                }

                element_array_time.label_begin = var_mod_label_begin;
                element_array_time.label_end = var_mod_label_end;

                element_array_time.value_revers_time(var_mod_time_end, var_mod_time_begin);

                element_array_time.add_button_right_time(var_mod_time_end);


                mod_time_array.Add(element_array_time);

            }

            Controls.Add(var_mod_time_begin);
            Controls.Add(var_mod_time_end);

            Controls.Add(var_mod_label_begin);
            Controls.Add(var_mod_label_end);

            // Тут Регистрация объекта при изменении
            RegistrWorksElement("MOVE");
            RegistrationWorksElementEndDate("MOVE");


            // Добовляем эелемент управления отображением
            element_array_time.add_element_link_label(var_mod_LinkLabel, (ArrayList)list_wokrs_main[list_wokrs_main.Count - 1], (ArrayList)all_list_works);

            // Тут Выставим время окончания 23.59.59
            //var_mod_time_end.Value = var_mod_time_end.Value.AddHours(23 - var_mod_time_end.Value.Hour);
            //var_mod_time_end.Value = var_mod_time_end.Value.AddMinutes(59 - var_mod_time_end.Value.Minute);

            //Пробуем установить фокус на последне созданный элеент
            var_mod_time_end.Focus();


        }

        private void bt_CleanForm_Click(object sender, EventArgs e)
        {
            // Очистим все форму! Эмуляция как при стоп!
            this.SendDataForm("CLEAR");
        }

        private void btTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainDescr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Тут берем массив то что был при кнопке "Пуск" а не последний :-)
            ShowWorksElement ShowLinkWorksElement = new ShowWorksElement((ArrayList)_list_wokrs_start, (MainForm)this, MainDescr,all_list_works);
            ShowLinkWorksElement.Show();

        }
    }
}
