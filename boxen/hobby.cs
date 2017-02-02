using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace boxen
{
    public class hobby
    {
        public string Activiteit { get; set; }
        public string Categorie { get; set; }
        public BitmapImage Symbool { get; set; }

        public hobby (string nCategorie, string nActiviteit, BitmapImage nSymbool)
        { this.Activiteit = nActiviteit;
            this.Categorie = nCategorie;
            this.Symbool = nSymbool;
        }
    }
}
