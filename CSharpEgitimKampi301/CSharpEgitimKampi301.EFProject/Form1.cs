using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities(); //entitty'nin olduğu modele ulaşmamız lazım

        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide= new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);

            db.SaveChanges(); //değişiklikleri veri tabanına kaydetmek için

            MessageBox.Show("Rehber Başarıyla Eklendi!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id); //silinecek değeri buluyor
            db.Guide.Remove(removeValue);
            db.SaveChanges(); 

            MessageBox.Show("Rehber Başarıyla Silindi!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName=txtName.Text;
            updateValue.GuideSurname=txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList(); //ef'de where şartı lambda expression gibi çalışır
            dataGridView1.DataSource = values; //hepsini değil sadece sağlayan değerleri getirecek

        }
    }
}
