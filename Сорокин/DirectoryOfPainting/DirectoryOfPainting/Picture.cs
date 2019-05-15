using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryOfPainting
{
    /// <summary>
    /// описание картины
    /// </summary>
    public class Picture
    {
        //Идентификатор
        public int pId { get; set; }
        //Название картины
        public string pName { get; set; }
        //Художник
        public int pArtist { get; set; }
        //Дата создания
        public DateTime pDateOfCreate { get; set; }
        //Жанр картины
        public string pGenre { get; set; }

    }
}
