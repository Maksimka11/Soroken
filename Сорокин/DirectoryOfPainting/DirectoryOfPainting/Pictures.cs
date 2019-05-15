using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DirectoryOfPainting
{
    public partial class Pictures : Form
    {
        /// <summary>
        /// форма ввода и редактирования картин
        /// </summary>
        public Pictures()
        {
            InitializeComponent();
            //заполняем комбобокс с художниками
            LoadArtists();
            //по-умолчанию дата создания - сегодняшнее число
            Picture.pDateOfCreate = DateTime.Today; 
        }

        //объект класса Picture
        public Picture Picture = new Picture();

        /// <summary>
        /// метод загрузки комбобокса с художниками
        /// </summary>
        private void LoadArtists()
        {
            //пишем SQL по отбору данных по художнику, сортируем по фамилии
            var sql = @"select * from Artists order by aLastName";
            var da = new OleDbDataAdapter(sql, Db.Connection);
            var ds = new DataSet();
            da.Fill(ds);
            //свзяываем отобанные данные с компонентом комбобокс
            cbArtist.DataSource = ds.Tables[0];
            cbArtist.DisplayMember = "aLastName";
            cbArtist.ValueMember = "aId";
        }

        private void Pictures_Load(object sender, EventArgs e)
        {
            //устанавливаем значения компонентов при редактировании
            tbName.Text = Picture.pName;
            tbGenre.Text = Picture.pGenre;
            dtpDateOfCreate.Value = Picture.pDateOfCreate;
            cbArtist.SelectedValue = Picture.pArtist;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //проверяем выбор художника
            if (cbArtist.SelectedIndex < 0)
            {
                MessageBox.Show(@"Выберите художника!");
                cbArtist.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //проверяем на заполненность названия картины 
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show(@"Введите название!");
                tbName.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //проверяем на заполненность жанра картины 
            if (string.IsNullOrEmpty(tbGenre.Text))
            {
                MessageBox.Show(@"Введите жанр!");
                tbGenre.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //присваиваем данные из компонентов объекту классса Picture
            Picture.pArtist = (int)cbArtist.SelectedValue;
            Picture.pName = tbName.Text;
            Picture.pGenre = tbGenre.Text;
            Picture.pDateOfCreate = dtpDateOfCreate.Value;

        }
    }
}
