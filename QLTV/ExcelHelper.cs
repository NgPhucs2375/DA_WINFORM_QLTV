using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLTV
{
    public static class ExcelHelper
    {
        public static void ExportToExcel(DataGridView dgv, string title)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportData";

                // 1. Tiêu đề cột
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    // Format Header đậm, nền xám
                    worksheet.Cells[1, i].Font.Bold = true;
                    worksheet.Cells[1, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                // 2. Dữ liệu dòng
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        // Thêm dấu ' ở đầu để Excel hiểu là Text (tránh lỗi mất số 0 ở SĐT)
                        object cellValue = dgv.Rows[i].Cells[j].Value;
                        string val = cellValue != null ? cellValue.ToString() : "";
                        worksheet.Cells[i + 2, j + 1] = "'" + val;
                    }
                }

                // 3. Auto fit cột cho đẹp
                worksheet.Columns.AutoFit();

                // 4. Hiển thị Excel
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (excelApp != null) excelApp.Quit();
            }
            finally
            {
                // Giải phóng bộ nhớ COM (Rất quan trọng để không bị treo tiến trình Excel ngầm)
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
            }
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch { }
            finally { GC.Collect(); }
        }
    }
}