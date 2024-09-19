using FarmManagement.Bussiness_Layer;
using FarmManagement.Data_Layer.DAO;
using FarmManagement.Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap.Net
{
    public partial class frmMain : Form
    {
        public static frmMain Instance;
        private readonly frmMainService _service;
        private readonly CowDAO _cowDAO;    
        private readonly SheepDAO _sheepDAO;    
        private readonly GoatDAO _goatDAO;  
        public Animal[] ListAnimal { get; set; }
        public frmMain()
        {
            InitializeComponent();
            Instance = this;
            _service = new frmMainService();
            _cowDAO = new CowDAO(); 
            _sheepDAO = new SheepDAO();     
            _goatDAO = new GoatDAO();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongBo = int.Parse(tbBo.Text);
                int soLuongDe = int.Parse(tbDe.Text);
                int soLuongCuu = int.Parse(tbCuu.Text);

                int tongSoCon = soLuongBo + soLuongDe + soLuongCuu;

                ListAnimal = new Animal[tongSoCon];

                for (int i = 0; i < tongSoCon; i++)
                {
                    if (i < soLuongBo)
                    {
                        ListAnimal[i] = new Cow();
                        ListAnimal[i].Name = "Cow";
                        ListAnimal[i].Description = "This is cow";
                    }
                    if (i >= soLuongBo && i < soLuongBo + soLuongDe)
                    {
                        ListAnimal[i] = new Goat();
                        ListAnimal[i].Name = "Goat";
                        ListAnimal[i].Description = "This is goat";
                    }
                    if (i >= soLuongBo + soLuongDe)
                    {
                        ListAnimal[i] = new Sheep();
                        ListAnimal[i].Name = "Sheep";
                        ListAnimal[i].Description = "This is sheep";
                    }
                }

                MessageBox.Show("Khởi tạo trang trại thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKeu_Click(object sender, EventArgs e)
        {
            _service.Keu();
        }

        private void btnVatSua_Click(object sender, EventArgs e)
        {
            _service.VatSua();
        }

        private void BtnDeCon_Click(object sender, EventArgs e)
        {
            _service.DeCon();
        }

        private void btnInsertDB_Click(object sender, EventArgs e)
        {
            _cowDAO.InsertCow(ListAnimal);
            _sheepDAO.InsertSheep(ListAnimal);      
            _goatDAO.InsertGoat(ListAnimal);        
            MessageBox.Show("Insert into Database successfully");
        }
    }
}
