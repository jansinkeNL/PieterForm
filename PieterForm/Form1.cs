using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LiteDatabase db = new LiteDatabase(@".\PictoWorld.db");

        int dezeCat = 0;
        int ditScherm = 0;
        List<PictureBox> schermAfbeeldingen = new List<PictureBox>();


        private void Form1_Load(object sender, EventArgs e)
        {
            //var CurrentCats = db.GetCollection<Categorie>();
            //var CurrentCat = CurrentCats.FindOne(x => x.parent==0);
            //var CurrentCats2 = new Categorie { id=1, parent = 0, afbeelding = "kruiwagen.jpg", naam = "Kruiwagen", uitgeschakeld = false, volgorde = 0 };
            //CurrentCats.Insert(CurrentCats2);
            //CurrentCats.Delete(CurrentCat);
            //CurrentCats.Delete(1);
            //Titel.Text = CurrentCat.naam;
            //pictureBoxC1R1.Image = Image.FromFile(@".\Images\Kruiwagen.jpg");
            ShowCat(dezeCat, ditScherm);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var CurrentCats = db.GetCollection<Categorie>();
            var CurrentCats2 = new Categorie { id = 2, parent = 1, afbeelding = "Dieren.jpg", naam = "Dieren2", uitgeschakeld = false, volgorde = 1 };
            CurrentCats.Insert(CurrentCats2);
        }
        private void ShowCat(int id, int scherm)
        {
            var CurrentCats = db.GetCollection<Categorie>();
            var CurrentCat = CurrentCats.FindOne(x => x.parent == 0);
            Titel.Text = CurrentCat.naam;
            var categorien = CurrentCats.Query().Where(X => X.parent == id).OrderBy(X => X.volgorde).ToList();
            

        }
    }
}
