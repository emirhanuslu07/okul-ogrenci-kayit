using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul_kayit.model
{
   public class ogrenci
    {
        public int Id { get; set; }
        public int okulno { get; set; }
        public string? ad { get; set; }
        public string? soyad { get; set; }

        public virtual sinif? Sınıf { get; set; }






    }
}
