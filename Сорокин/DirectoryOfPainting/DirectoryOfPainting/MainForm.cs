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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //загружаем данные по аукционам
            LoadAuctions();
            //загружаем данные по художникам
            LoadArtists();
            //загружаем данные по картинам
            LoadPictures();
        }

        /// <summary>
        /// загрузка художников
        /// </summary>
        private void LoadArtists()
        {
            //пишем SQL по отбору данных по художникам, сортируем по фамилии
            var sql = @"select * from Artists order by aLastName ";
            var da = new OleDbDataAdapter(sql, Db.Connection);
            var ds = new DataSet();
            da.Fill(ds);
            //свзяываем отобанные данные с компонентом datagridview
            dgvArtists.DataSource = ds;
            dgvArtists.DataMember = ds.Tables[0].TableName;
            //не показываем столбец с ИД
            dgvArtists.Columns["aId"].Visible = false;
            //устанавливаем заголовок столбца
            dgvArtists.Columns["aFirstName"].HeaderText = @"Имя";
            //устанавдиваем ширину столбца
            dgvArtists.Columns["aFirstName"].Width = 100;
            dgvArtists.Columns["aLastName"].HeaderText = @"Фамилия";
            dgvArtists.Columns["aLastName"].Width = 100;
            dgvArtists.Columns["aFatherName"].HeaderText = @"Отчество";
            dgvArtists.Columns["aFatherName"].Width = 100;
            dgvArtists.Columns["aDateBirthday"].HeaderText = @"Дата рождения";
            dgvArtists.Columns["aDateBirthday"].Width = 200;
            dgvArtists.Columns["aStyle"].HeaderText = @"Стиль";
            dgvArtists.Columns["aStyle"].Width = 100; 
        }

        /// <summary>
        /// загрузка картин
        /// </summary>
        private void LoadPictures()
        {
            //пишем SQL по отбору данных по картинам, сортируем по названию
            var sql = @"select aId, pId, pName, pArtist, pDateOfCreate, pGenre from Pictures, Artists where pArtist=aId order by pName ";
            var da = new OleDbDataAdapter(sql, Db.Connection);
            var ds = new DataSet();
            da.Fill(ds);
            //свзяываем отобанные данные с компонентом datagridview
            dgvPictures.DataSource = ds;
            dgvPictures.DataMember = ds.Tables[0].TableName;
            //не показываем столбец с ИД
            dgvPictures.Columns["pId"].Visible = false;
            dgvPictures.Columns["aId"].Visible = false;
            //устанавливаем заголовок столбца
            dgvPictures.Columns["pName"].HeaderText = @"Название";
            //устанавдиваем ширину столбца
            dgvPictures.Columns["pName"].Width = 100;
            dgvPictures.Columns["pArtist"].HeaderText = @"Художник";
            dgvPictures.Columns["pArtist"].Width = 70;
            dgvPictures.Columns["pDateOfCreate"].HeaderText = @"Дата создания";
            dgvPictures.Columns["pDateOfCreate"].Width = 200;
            dgvPictures.Columns["pGenre"].HeaderText = @"Жанр";
            dgvPictures.Columns["pGenre"].Width = 100;
        }

        /// <summary>
        /// загрузка аукциона
        /// </summary>
        private void LoadAuctions()
        {
            //пишем SQL по отбору данных по аукционам, сортируем по дате проведения
            var sql = @"select auId, auAddress, auPicture, pId, auPrice, auDate  from  Auctions, Pictures where auPicture=pId order by auDate desc";
            var da = new OleDbDataAdapter(sql, Db.Connection);
            var ds = new DataSet();
            da.Fill(ds);
            //свзяываем отобанные данные с компонентом datagridview
            dgvAuctions.DataSource = ds;
            dgvAuctions.DataMember = ds.Tables[0].TableName;
            //не показываем столбец с ИД
            dgvAuctions.Columns["auId"].Visible = false;
            dgvAuctions.Columns["pId"].Visible = false;
            //устанавливаем заголовок столбца
            dgvAuctions.Columns["auAddress"].HeaderText = @"Адрес проведения";
            //устанавдиваем ширину столбца
            dgvAuctions.Columns["auAddress"].Width = 150;
            dgvAuctions.Columns["auPicture"].HeaderText = @"Картина";
            dgvAuctions.Columns["auPicture"].Width = 70;
            dgvAuctions.Columns["auPrice"].HeaderText = @"Стоимость";
            dgvAuctions.Columns["auPrice"].Width = 100;
            dgvAuctions.Columns["auDate"].HeaderText = @"Дата проведения";
            dgvAuctions.Columns["auDate"].Width = 200;
        }



        /// <summary>
        /// добавление аукциона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuAdd_Click(object sender, EventArgs e)
        {
            //создаем форму редактирования
            var f = new Auctions();
            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по добавлению данных о аукционе
                var cmd = new OleDbCommand(@"insert into Auctions (auAddress, auDate, auPicture, auPrice) values (?,?,?,?)")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для добавления данных
                cmd.Parameters.AddWithValue(@"auAddress", f.Auction.auAddress);
                cmd.Parameters.AddWithValue(@"auDate", f.Auction.auDate);
                cmd.Parameters.AddWithValue(@"auPicture", f.Auction.auPicture);
                cmd.Parameters.AddWithValue(@"auPrice", f.Auction.auPrice);
                //выполняем запрос по добавлению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadAuctions();
            }

        }

        /// <summary>
        /// редактирование аукциона
        /// </summary>
        private void btnAuChange_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvAuctions.CurrentCell == null) return;
            //индекс выделенной ячейки
            var i = dgvAuctions.CurrentCell.RowIndex;
            //создаем форму редактирования
            var f = new Auctions();
            //заплняем объект класса Auction данными из datagridview
            f.Auction.auId = (int)dgvAuctions.Rows[i].Cells["auId"].Value;
            f.Auction.auPicture = (int)dgvAuctions.Rows[i].Cells["pId"].Value;
            f.Auction.auAddress = Convert.ToString(dgvAuctions.Rows[i].Cells["auAddress"].Value);
            f.Auction.auDate = Convert.ToDateTime(dgvAuctions.Rows[i].Cells["auDate"].Value);
            f.Auction.auPrice = Convert.ToInt32(dgvAuctions.Rows[i].Cells["auPrice"].Value);
            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по изменению данных о аукционе
                var cmd = new OleDbCommand(@"update Auctions set auAddress=?, auPicture=?, auDate=?, auPrice=? where auId=?")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для изменения данных
                cmd.Parameters.AddWithValue(@"auAddress", f.Auction.auAddress);
                cmd.Parameters.AddWithValue(@"auPicture", f.Auction.auPicture);
                cmd.Parameters.AddWithValue(@"auDate", f.Auction.auDate);
                cmd.Parameters.AddWithValue(@"auPrice", f.Auction.auPrice);
                cmd.Parameters.AddWithValue(@"auId", f.Auction.auId);
                //выполняем запрос по изменению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadAuctions();
            }
        }

        /// <summary>
        /// удаление аукциона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuDel_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvAuctions.CurrentCell == null) return;
            //диалог подтверждения удаления
            if (MessageBox.Show(@"Удалить?", @"Удалить", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            //индекс выделенной ячейки
            var i = dgvAuctions.CurrentCell.RowIndex;
            //идентификатор записи
            var id = dgvAuctions.Rows[i].Cells["auId"].Value;
            //sql по удалению аукциона
            var cmd = new OleDbCommand(@"delete from Auctions where auId=?")
            {
                Connection = Db.Connection,
                CommandType = CommandType.Text
            };
            //запоняем параметры для удаления данных
            cmd.Parameters.AddWithValue(@"auId", id);
            //выполняем запрос по удалению
            cmd.ExecuteNonQuery();
            //обновляем данные в datagridview
            LoadAuctions();
        }

        /// <summary>
        /// добавление художника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArAdd_Click(object sender, EventArgs e)
        {
            //создаем форму редактирования
            var f = new Artists();
            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по добавлению данных о художнике
                var cmd = new OleDbCommand(@"insert into Artists (aFirstName, aLastName, aFatherName, aDateBirthday, aStyle) values (?,?,?,?,?)")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для добавления данных
                cmd.Parameters.AddWithValue(@"aFirstName", f.Artist.aFirstName);
                cmd.Parameters.AddWithValue(@"aLastName", f.Artist.aLastName);
                cmd.Parameters.AddWithValue(@"aFatherName", f.Artist.aFatherName);
                cmd.Parameters.AddWithValue(@"aDateBirthday", f.Artist.aDateBirthday);
                cmd.Parameters.AddWithValue(@"aStyle", f.Artist.aStyle);
                //выполняем запрос по добавлению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadArtists();
            }

        }

        /// <summary>
        /// редактирование художника
        /// </summary>
        private void btnArChange_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvArtists.CurrentCell == null) return;
            //индекс выделенной ячейки
            var i = dgvArtists.CurrentCell.RowIndex;
            //создаем форму редактирования
            var f = new Artists();
            //заплняем объект класса Artist данными из datagridview
            f.Artist.aId = (int)dgvArtists.Rows[i].Cells["aId"].Value;
            f.Artist.aFirstName = Convert.ToString(dgvArtists.Rows[i].Cells["aFirstName"].Value); 
            f.Artist.aLastName = Convert.ToString(dgvArtists.Rows[i].Cells["aLastName"].Value);
            f.Artist.aDateBirthday = Convert.ToDateTime(dgvArtists.Rows[i].Cells["aDateBirthday"].Value);
            f.Artist.aFatherName = Convert.ToString(dgvArtists.Rows[i].Cells["aFatherName"].Value);
            f.Artist.aStyle = Convert.ToString(dgvArtists.Rows[i].Cells["aStyle"].Value);

            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по изменению данных о художнике
                var cmd = new OleDbCommand(@"update Artists set aFirstName=?, aLastName=?, aFatherName=?, aDateBirthday=?, aStyle=? where aId=?")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для изменения данных
                cmd.Parameters.AddWithValue(@"aFirstName", f.Artist.aFirstName);
                cmd.Parameters.AddWithValue(@"aLastName", f.Artist.aLastName);
                cmd.Parameters.AddWithValue(@"aFatherName", f.Artist.aFatherName);
                cmd.Parameters.AddWithValue(@"aDateBirthday", f.Artist.aDateBirthday);
                cmd.Parameters.AddWithValue(@"aStyle", f.Artist.aStyle);
                cmd.Parameters.AddWithValue(@"aId", f.Artist.aId);
                //выполняем запрос по изменению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadArtists();
            }

        }

        /// <summary>
        /// удаление художника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArDel_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvArtists.CurrentCell == null) return;
            //диалог подтверждения удаления
            if (MessageBox.Show(@"Удалить?", @"Удалить", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            //индекс выделенной ячейки
            var i = dgvArtists.CurrentCell.RowIndex;
            //идентификатор записи
            var id = dgvArtists.Rows[i].Cells["auId"].Value;
            //sql по удалению художника
            var cmd = new OleDbCommand(@"delete from Artists where aId=?")
            {
                Connection = Db.Connection,
                CommandType = CommandType.Text
            };
            //запоняем параметры для удаления данных
            cmd.Parameters.AddWithValue(@"aId", id);
            //выполняем запрос по удалению
            cmd.ExecuteNonQuery();
            //обновляем данные в datagridview
            LoadArtists();

        }

        /// <summary>
        /// добавление картины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPicAdd_Click(object sender, EventArgs e)
        {
            //создаем форму редактирования
            var f = new Pictures();
            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по добавлению данных о картине
                var cmd = new OleDbCommand(@"insert into Pictures (pName, pDateOfCreate, pArtist, pGenre) values (?,?,?,?)")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для добавления данных
                cmd.Parameters.AddWithValue(@"pName", f.Picture.pName);
                cmd.Parameters.AddWithValue(@"pDateOfCreate", f.Picture.pDateOfCreate);
                cmd.Parameters.AddWithValue(@"pArtist", f.Picture.pArtist);
                cmd.Parameters.AddWithValue(@"pGenre", f.Picture.pGenre);
                //выполняем запрос по добавлению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadPictures();
            }

        }

        /// <summary>
        /// редактирование картины
        /// </summary>
        private void btnPicChange_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvPictures.CurrentCell == null) return;
            //индекс выделенной ячейки
            var i = dgvPictures.CurrentCell.RowIndex;
            //создаем форму редактирования
            var f = new Pictures();
            //заплняем объект класса Picture данными из datagridview
            f.Picture.pId = (int)dgvPictures.Rows[i].Cells["pId"].Value;
            f.Picture.pArtist = (int)dgvPictures.Rows[i].Cells["aId"].Value;
            f.Picture.pName = Convert.ToString(dgvPictures.Rows[i].Cells["pName"].Value);
            f.Picture.pGenre = Convert.ToString(dgvPictures.Rows[i].Cells["pGenre"].Value);
            f.Picture.pDateOfCreate = Convert.ToDateTime(dgvPictures.Rows[i].Cells["pDateOfCreate"].Value);
            //показываем диалог с редактированием 
            if (f.ShowDialog() == DialogResult.OK)
            {
                //если нажали кнопку ОК пишем SQL по изменению данных о картине
                var cmd = new OleDbCommand(@"update Pictures set pName=?, pArtist=?, pDateOfCreate=?, pGenre=? where pId=?")
                {
                    Connection = Db.Connection,
                    CommandType = CommandType.Text
                };
                //запоняем параметры для изменения данных
                cmd.Parameters.AddWithValue(@"pName", f.Picture.pName);
                cmd.Parameters.AddWithValue(@"pArtist", f.Picture.pArtist);
                cmd.Parameters.AddWithValue(@"pDateOfCreate", f.Picture.pDateOfCreate);
                cmd.Parameters.AddWithValue(@"pGenre", f.Picture.pGenre);
                cmd.Parameters.AddWithValue(@"pId", f.Picture.pId);
                //выполняем запрос по изменению
                cmd.ExecuteNonQuery();
                //обновляем данные в datagridview
                LoadPictures();
            }

        }

        /// <summary>
        /// удаление картины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPicDel_Click(object sender, EventArgs e)
        {
            //если нет выделенной ячейки, то выходим
            if (dgvPictures.CurrentCell == null) return;
            //диалог подтверждения удаления
            if (MessageBox.Show(@"Удалить?", @"Удалить", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            //индекс выделенной ячейки
            var i = dgvPictures.CurrentCell.RowIndex;
            //идентификатор записи
            var id = dgvPictures.Rows[i].Cells["pId"].Value;
            //sql по удалению картины
            var cmd = new OleDbCommand(@"delete from Pictures where pId=?")
            {
                Connection = Db.Connection,
                CommandType = CommandType.Text
            };
            //запоняем параметры для удаления данных
            cmd.Parameters.AddWithValue(@"pId", id);
            //выполняем запрос по удалению
            cmd.ExecuteNonQuery();
            //обновляем данные в datagridview
            LoadPictures();

        }

        private void dgvAuctions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAuChange_Click(sender, e);

        }

        private void dgvArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnArChange_Click(sender, e);
        }

        private void dgvPicture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPicChange_Click(sender, e);
        }
    }
}
