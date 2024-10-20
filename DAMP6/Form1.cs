using AutoMapper;
using DAL.BUS.Service;
using DAL.BUS.ViewModel;
using DAMP6.DAL.Entities;

namespace DAMP6
{
    public partial class Form1 : Form
    {
        List<SinhVienVM> _svs;
        ISinhVienService _sinhVienService;

        public Form1()
        {
            _svs = new List<SinhVienVM>();
            _sinhVienService = new SinhVienService();
            InitializeComponent();
            LoadFormDataSinhVien();
            LoadGridDataSinhVien();
        }


        private void LoadFormDataSinhVien()
        {
            dgv_sinhvien.Columns.Clear();
            dgv_sinhvien.Columns.Add("CLM1", "STT");
            dgv_sinhvien.Columns.Add("CLM2", "Tên");
            dgv_sinhvien.Columns.Add("CLM3", "Email");
            dgv_sinhvien.Columns.Add("CLM4", "SĐT");
            dgv_sinhvien.Columns.Add("CLM5", "Địa chỉ");

            cb_ph.Items.Clear();
            cb_ph.Items.Add("1");
            cb_ph.Items.Add("2");
            cb_ph.Items.Add("3");
            cb_ph.Items.Add("4");
            cb_ph.Items.Add("5");
        }

        private void LoadGridDataSinhVien()
        {
            _svs = _sinhVienService.GetAll();
            dgv_sinhvien.Rows.Clear();
            foreach (var sv in _svs)
            {
                dgv_sinhvien.Rows.Add(
                    (_svs.IndexOf(sv) + 1),
                    sv.Ten,
                    sv.Email,
                    sv.Sdt,
                    sv.Diachi,
                    sv.IdPh
                    );
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txt_id.Text, out id))
            {
                int? idPh = cb_ph.SelectedItem != null ? (int?)cb_ph.SelectedValue : null;
                var newSinhVien = new SinhVienCreateVM
                {
                    Id = id,
                    Ten = txt_ten.Text,
                    Email = txt_email.Text,
                    Sdt = txt_sdt.Text,
                    Diachi = txt_diachi.Text,
                    IdPh = idPh
                };
                string result = _sinhVienService.Create(newSinhVien);

                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txt_id.Text, out id))
            {
                int? idPh = cb_ph.SelectedItem != null ? (int?)cb_ph.SelectedValue : null;
                var updateSinhVien = new SinhVienUpdateVM
                {
                    Id = id,
                    Ten = txt_ten.Text,        
                    Email = txt_email.Text,   
                    Sdt = txt_sdt.Text,        
                    Diachi = txt_diachi.Text, 
                    IdPh = idPh                
                };
                bool success = _sinhVienService.Update(updateSinhVien);

                if (success)
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txt_id.Text, out id))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = _sinhVienService.Delete(id);

                    if (success)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
