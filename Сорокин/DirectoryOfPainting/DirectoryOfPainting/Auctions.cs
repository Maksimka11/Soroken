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
    public partial class Auctions : Form
    {
        /// <summary>
        /// форма ввода  и редактирования аукциона
        /// </summary>
        public Auctions()
        {
            InitializeComponent();
            LoadPicture();
            Auction.auDate = DateTime.Today;
        }
        //объект класса Auction
        public Auction Auction = new Auction();

        /// <summary>
        /// метод загрузки комбобокса с картинами
        /// </summary>
        private void LoadPicture()
        {
            //пишем SQL по отбору данных по картинам, сортируем по названию
            var sql = @"select * from Pictures order by pName";
            var da = new OleDbDataAdapter(sql, Db.Connection);
            var ds = new DataSet();
            da.Fill(ds);
            //свзяываем отобанные данные с компонентом комбобокс
            cbPicture.DataSource = ds.Tables[0];
            cbPicture.DisplayMember = "pName";
            cbPicture.ValueMember = "pId";
        }

        private void Auctions_Load(object sender, EventArgs e)
        {
            //устанавливаем значения компонентов при редактировании
            dtpDate.Value = Auction.auDate;
            tbPrice.Text = Convert.ToString(Auction.auPrice);
            cbPicture.SelectedValue = Auction.auPicture;
            tbAddress.Text = Auction.auAddress;

        }

        /// <summary>
        /// обработка кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //проверяем выбор картины
            if (cbPicture.SelectedIndex < 0)
            {
                //сообщение
                MessageBox.Show(@"Выберите картину!");
                //устанавливаем фокус
                cbPicture.Focus();
                //не закрываем форму
                DialogResult = DialogResult.None;
                return;
            }

            //проверяем правильность ввода стоимости
            int d = 0;
            if (!Int32.TryParse(tbPrice.Text, out d))
            {
                MessageBox.Show(@"Неправильно введено значение!");
                tbPrice.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            //проверяем на заполненность адреса
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show(@"Введите имя!");
                tbAddress.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            Auction.auDate = dtpDate.Value;
            Auction.auPicture = (int)cbPicture.SelectedValue;
            Auction.auPrice = Convert.ToInt32(tbPrice.Text);
            Auction.auAddress = tbAddress.Text;
        }
    }
}
