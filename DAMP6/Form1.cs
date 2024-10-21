using AutoMapper;
using DAL.BUS.Service;
using DAL.BUS.ViewModel;
using DAMP6.DAL.Entities;

namespace DAMP6
{
    public partial class Form1 : Form
    {
        List<SinhVienVM> _sinhViens;
        ISinhVienService _sinhVienService;
        private int? selectedPhuHuynhId;
        private int selectedSinhVienId;

        public Form1()
        {
            _sinhVienService = new SinhVienService();
            InitializeComponent();
            LoadPhuHuynhToComboBox();
            LoadPhuHuynhToTimKiemComboBox();
            LoadFormDataSinhVien();
        }

        private void LoadPhuHuynhToComboBox()
        {
            var phuHuynhs = _sinhVienService.GetAllPhuHuynh();
            cb_phuhuynh.DataSource = phuHuynhs;
            cb_phuhuynh.DisplayMember = "Ten";
            cb_phuhuynh.ValueMember = "Id";
        }

        private void LoadPhuHuynhToTimKiemComboBox()
        {
            var phuHuynhs = _sinhVienService.GetAllPhuHuynh();
            cb_timkiem.DataSource = phuHuynhs;
            cb_timkiem.DisplayMember = "Ten";
            cb_timkiem.ValueMember = "Id";
        }


        private void LoadFormDataSinhVien()
        {
            dgv_sinhvien.Columns.Clear();
            dgv_sinhvien.Columns.Add("clm_stt", "STT");
            dgv_sinhvien.Columns.Add("clm_ten", "Tên Sinh Viên");
            dgv_sinhvien.Columns.Add("clm_email", "Email");
            dgv_sinhvien.Columns.Add("clm_sdt", "Số điện thoại");
            dgv_sinhvien.Columns.Add("clm_diachi", "Địa chỉ");
            dgv_sinhvien.Columns.Add("clm_phuhuynh", "Phụ huynh");
        }

        private void LoadGridDataSinhVien()
        {
            _sinhViens = _sinhVienService.GetAll();
            dgv_sinhvien.Rows.Clear();

            int stt = 1;
            foreach (var sv in _sinhViens)
            {
                dgv_sinhvien.Rows.Add(
                    stt++,
                    sv.Ten,
                    sv.Email,
                    sv.Sdt,
                    sv.Diachi,
                    sv.PhuHuynh != null ? sv.PhuHuynh.Ten : "null"
                );
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var selectedPhId = cb_phuhuynh.SelectedValue;
            if (selectedPhId != null)
            {
                var sinhVienVM = new SinhVienCreateVM
                {
                    Ten = txt_ten.Text,
                    Email = txt_email.Text,
                    Sdt = txt_sdt.Text,
                    Diachi = txt_diachi.Text,
                    IdPh = int.Parse(cb_phuhuynh.SelectedValue.ToString())
                };
                var result = _sinhVienService.Create(sinhVienVM);
                MessageBox.Show(result, "Thông báo");
                LoadGridDataSinhVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phụ huynh.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sinhVienVM = new SinhVienUpdateVM
            {
                Id = selectedSinhVienId,
                Ten = txt_ten.Text,
                Email = txt_email.Text,
                Sdt = txt_sdt.Text,
                Diachi = txt_diachi.Text,
                IdPh = int.Parse(cb_phuhuynh.SelectedValue.ToString())
            };

            var result = _sinhVienService.Update(sinhVienVM);
            MessageBox.Show(result ? "Sửa thành công" : "Sửa thất bại", "Thông báo");
            LoadGridDataSinhVien();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedSinhVienId != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var result = _sinhVienService.Delete(selectedSinhVienId);
                    MessageBox.Show(result ? "Xóa thành công" : "Xóa thất bại", "Thông báo");
                    LoadGridDataSinhVien();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên.");
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadGridDataSinhVien();
        }

        private void dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgv_sinhvien.Rows.Count)
                {
                    return;
                }
                int stt = int.Parse(dgv_sinhvien.Rows[e.RowIndex].Cells["clm_stt"].Value.ToString());
                var selectedSinhVien = _sinhViens[stt - 1];
                selectedSinhVienId = selectedSinhVien.Id;
                txt_ten.Text = selectedSinhVien.Ten;
                txt_email.Text = selectedSinhVien.Email;
                txt_sdt.Text = selectedSinhVien.Sdt;
                txt_diachi.Text = selectedSinhVien.Diachi;
                selectedPhuHuynhId = selectedSinhVien.IdPh;
                cb_phuhuynh.SelectedValue = selectedPhuHuynhId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.ToLower();
            var filterType = cb_timkiem.SelectedItem.ToString();

            var filteredList = _sinhViens.Where(sv =>
            {
                if (filterType == "Tên")
                    return sv.Ten.ToLower().Contains(keyword);
                else
                    return sv.Email.ToLower().Contains(keyword);
            }).ToList();

            dgv_sinhvien.Rows.Clear();
            int stt = 1;
            foreach (var sv in filteredList)
            {
                dgv_sinhvien.Rows.Add(
                    stt++,
                    sv.Ten,
                    sv.Email,
                    sv.Sdt,
                    sv.Diachi,
                    sv.PhuHuynh != null ? sv.PhuHuynh.Ten : "null"
                );
            }
        }
    }
}
