using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryOfPainting
{
    
    public partial class Artists : Form
    {
     /// <summary>
     /// форма ввода  и редактирования художника
     /// </summary>
        public Artists()
        {
            InitializeComponent();
            //по-умолчанию дата рождения - сегодняшнее число
            Artist.aDateBirthday = DateTime.Today;
        }

        //объект класса Artist
        public Artist Artist = new Artist();

        private void Artists_Load(object sender, EventArgs e)
        {
            //устанавливаем значения компонентов при редактировании
            tbFirstName.Text = Artist.aFirstName;
            tbLastName.Text = Artist.aLastName;
            tbFatherName.Text = Artist.aFatherName;
            tbStyle.Text = Artist.aStyle;
            dtpDateBirthday.Value = Artist.aDateBirthday;
        }

        /// <summary>
        /// обработка кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //проверяем на заполненность имени 
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                //сообщение
                MessageBox.Show(@"Введите имя!");
                //устанавливаем фокус
                tbFirstName.Focus();
                //не закрываем форму
                DialogResult = DialogResult.None;
                return;
            }
            //проверяем на заполненность фамилии 
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show(@"Введите фамилию!");
                tbLastName.Focus();
                DialogResult = DialogResult.None;
                return;
            }
            //проверяем на заполненность отчества 
            if (string.IsNullOrEmpty(tbFatherName.Text))
            {
                MessageBox.Show(@"Введите отчество!");
                tbFatherName.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //проверяем на заполненность стиля 
            if (string.IsNullOrEmpty(tbStyle.Text))
            {
                MessageBox.Show(@"Введите стиль художника!");
                tbStyle.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //присваиваем данные из компонентов объекту классса Artist
            Artist.aFirstName = tbFirstName.Text;
            Artist.aLastName = tbLastName.Text;
            Artist.aFatherName = tbFatherName.Text;
            Artist.aStyle = tbStyle.Text;
            Artist.aDateBirthday = dtpDateBirthday.Value;

        }
    }
}
