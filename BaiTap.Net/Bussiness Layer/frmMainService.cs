using BaiTap.Net;
using FarmManagement.Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Bussiness_Layer
{
    public class frmMainService
    {
        public void Keu()
        {
            if (frmMain.Instance.ListAnimal == null)
            {
                MessageBox.Show("Vui lòng khởi tạo trang trại trước");
                return;
            }
            string tiengKeu = "";
            for (int i = 0; i < frmMain.Instance.ListAnimal.Length; i++)
            {
                tiengKeu += frmMain.Instance.ListAnimal[i].Sound();
                tiengKeu += "\n";
            }
            MessageBox.Show(tiengKeu);
        }
        public void VatSua()
        {
            if (frmMain.Instance.ListAnimal == null)
            {
                MessageBox.Show("Vui lòng khởi tạo trang trại trước");
                return;
            }
            int tongSoSua = 0;
            for (int i = 0; i < frmMain.Instance.ListAnimal.Length; i++)
            {
                tongSoSua += frmMain.Instance.ListAnimal[i].Milk();
            }
            MessageBox.Show($"Tổng số sữa vắt được: {tongSoSua}");
        }
        public void DeCon()
        {
            if (frmMain.Instance.ListAnimal == null)
            {
                MessageBox.Show("Vui lòng khởi tạo trang trại trước");
                return;
            }
            int tongSoCon = 0;
            for (int i = 0; i < frmMain.Instance.ListAnimal.Length; i++)
            {
                tongSoCon += frmMain.Instance.ListAnimal[i].GiveBirth();
            }
            MessageBox.Show($"Tổng số con đẻ được: {tongSoCon}");
        }
    }
}
