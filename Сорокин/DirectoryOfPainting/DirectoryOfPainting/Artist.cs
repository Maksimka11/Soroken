using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryOfPainting
{
    /// <summary>
    /// описание художника
    /// </summary>
    public class Artist
    {
        //Идентификатор
        public int aId { get; set; }
        //Имя
        public string aFirstName { get; set; }
        //Фамилия
        public string aLastName { get; set; }
        //Отчество
        public string aFatherName { get; set; }
        //Дата рождения
        public DateTime aDateBirthday { get; set; }
        //Используемый стиль
        public string aStyle { get; set; }

    }
}
