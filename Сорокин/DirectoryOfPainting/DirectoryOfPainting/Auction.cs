using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryOfPainting
{
    /// <summary>
    /// описание аукциона
    /// </summary>
    public class Auction
    {
        //Идентификатор
        public int auId { get; set; }
        //Дата проведения аукциона
        public DateTime auDate { get; set; }
        //Интересующая картина
        public int auPicture { get; set; }
        //Стоимость картины
        public int auPrice { get; set; }
        //Адрес проведения
        public string auAddress { get; set; }
    }
}
