using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PBL3.BLL;
using PBL3.DAL;

namespace PBL3.VIEW
{
    public partial class Invoice : Form
    {
        private int _billId;
        private Bill _bill;
        public Invoice(int billId)
        {
            InitializeComponent();
            _billId = billId;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            _BLL_Bill billBLL = new _BLL_Bill();
            _bill = billBLL.GetBillById(_billId);

            if (_bill == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.");
                this.Close();
                return;
            }

            // Hiển thị thông tin sân
            lbl_Pitch.Text = $"Sân: {_bill.Pitch.PitchName}";
            lbl_Date.Text = $"Ngày: {_bill.Date:dd/MM/yyyy}";
            lbl_Time.Text = $"Khách hàng: {_bill.Customer.Name} (ID: {_bill.CustomerID})";
            lbl_PitchPrice.Text = $"Giá sân: {_bill.Pitch.PitchPrice:N0} VNĐ";

            // Hiển thị danh sách nước
            var drinks = _bill.BillDetails.Select(d => new
            {
                TênNước = d.Drink.DrinkName,
                SốLượng = d.Quantity,
                ĐơnGiá = d.UnitPrice,
                ThànhTiền = d.Quantity * d.UnitPrice
            }).ToList();

            dgv.DataSource = drinks;
            dgv.ClearSelection();

            // Tính tổng
            decimal tongTienNuoc = drinks.Sum(x => x.ThànhTiền ?? 0);
            decimal tong = tongTienNuoc + (_bill.Pitch.PitchPrice ?? 0);
            lbl_DrinkPrice.Text = $"Tổng tiền nước: {tongTienNuoc:N0} VNĐ";
            lbl_Total.Text = $"TỔNG CỘNG: {tong:N0} VNĐ";
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF file (*.pdf)|*.pdf";
            save.FileName = $"HoaDon_{_bill.BillID}.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Nạp font Arial hỗ trợ tiếng Việt
                    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                    doc.Open();

                    // Tiêu đề
                    doc.Add(new Paragraph("HÓA ĐƠN ĐẶT SÂN", titleFont));
                    doc.Add(new Paragraph(" ", textFont));

                    // Thông tin chung
                    doc.Add(new Paragraph($"Mã hóa đơn: {_bill.BillID}", textFont));
                    doc.Add(new Paragraph($"Khách hàng: {_bill.Customer.Name} (ID: {_bill.CustomerID})", textFont));
                    doc.Add(new Paragraph($"Ngày: {_bill.Date:dd/MM/yyyy}", textFont));
                    doc.Add(new Paragraph($"Sân: {_bill.Pitch.PitchName}", textFont));
                    doc.Add(new Paragraph($"Giá sân: {_bill.Pitch.PitchPrice ?? 0:N0} VNĐ", textFont));
                    doc.Add(new Paragraph(" ", textFont));

                    // Bảng nước
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3, 1, 2, 2 });

                    table.AddCell(new Phrase("Tên nước", textFont));
                    table.AddCell(new Phrase("Số lượng", textFont));
                    table.AddCell(new Phrase("Đơn giá", textFont));
                    table.AddCell(new Phrase("Thành tiền", textFont));

                    decimal tongNuoc = 0;

                    foreach (var d in _bill.BillDetails)
                    {
                        string tenNuoc = d.Drink?.DrinkName ?? "";
                        int soLuong = d.Quantity ?? 0;
                        decimal donGia = d.UnitPrice ?? 0;
                        decimal thanhTien = soLuong * donGia;
                        tongNuoc += thanhTien;

                        table.AddCell(new Phrase(tenNuoc, textFont));
                        table.AddCell(new Phrase(soLuong.ToString(), textFont));
                        table.AddCell(new Phrase($"{donGia:N0} VNĐ", textFont));
                        table.AddCell(new Phrase($"{thanhTien:N0} VNĐ", textFont));
                    }

                    doc.Add(table);
                    doc.Add(new Paragraph(" ", textFont));

                    // Tổng cộng
                    decimal tong = tongNuoc + (_bill.Pitch.PitchPrice ?? 0);
                    doc.Add(new Paragraph($"Tổng tiền nước: {tongNuoc:N0} VNĐ", textFont));
                    doc.Add(new Paragraph($"TỔNG CỘNG: {tong:N0} VNĐ", titleFont));

                    doc.Close();
                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message);
                }
            }
        }
    }
}
