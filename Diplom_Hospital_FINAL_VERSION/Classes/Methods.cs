using Diplom_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Microsoft.Win32;
using System.Data;

namespace Diplom_Hospital.Classes
{
    public class Methods
    {
        //Методы для LogOfReceiptsPage
        public static string GetCellTextBoxValue(DataGrid dataGrid, OrderDeyails item, int columnIndex)
        {
            DataGridCell cell = GetCell(dataGrid, item, columnIndex);
            if (cell != null)
            {
                TextBox textBox = FindVisualChild<TextBox>(cell);
                if (textBox != null)
                {
                    return textBox.Text;
                }
            }
            return string.Empty;
        }

        public static DataGridCell GetCell(DataGrid dataGrid, OrderDeyails item, int columnIndex)
        {
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(item);
            if (row != null)
            {
                DataGridCellsPresenter presenter = FindVisualChild<DataGridCellsPresenter>(row);
                if (presenter != null)
                {
                    DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(columnIndex);
                    return cell;
                }
            }
            return null;
        }
        public static T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }
        /////
        //Методы для OrderPage
        public static void NewPdfReportLogRecept(DataGrid dg, string leadparag, string tableName, string fileName)
        {
            try
            {
                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);

                // Выбор пути и имени файла через диалоговое окно
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"{fileName}.pdf"; // Название по умолчанию
                if (saveFileDialog.ShowDialog() == true)
                {
                    string path = saveFileDialog.FileName;

                    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                    pdfDoc.Open();
                    string imagePath = "LogoDoc/CRBLogo.jpg";

                    Paragraph leadparagraph = new Paragraph($"{leadparag}", font);
                    leadparagraph.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(leadparagraph);

                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);

                    image.ScaleToFit(pdfDoc.PageSize.Width / 2, pdfDoc.PageSize.Height / 2);
                    image.Alignment = 1;

                    pdfDoc.Add(image);

                    var spacer = new iTextSharp.text.Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfDoc.Add(spacer);

                    Paragraph paragraph = new Paragraph($"{tableName}", font);
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(paragraph);
                    pdfDoc.Add(spacer);

                    PdfPTable table = new PdfPTable(dg.Columns.Count);
                    foreach (DataGridColumn column in dg.Columns)
                    {
                        table.AddCell(new Phrase(column.Header.ToString(), font));
                    }

                    // Добавление данных из DataGrid
                    foreach (var item in dg.Items)
                    {
                        var row = item as LogOfReceipts;
                        if (row != null)
                        {
                            table.AddCell(new Phrase(row.IdMedicine.ToString(), font));
                            table.AddCell(new Phrase(row.DateRecepts.ToString(), font));
                            table.AddCell(new Phrase(row.Medicine.MedicineName, font));
                            table.AddCell(new Phrase(row.Medicine.Category.NameCategory, font));
                            table.AddCell(new Phrase(row.Medicine.Description, font));
                            table.AddCell(new Phrase(row.QuantityReceipts.ToString(), font));
                            table.AddCell(new Phrase(row.ImplementationMonth.ToString(), font));
                            table.AddCell(new Phrase(row.ImplementationYear.ToString(), font));
                            table.AddCell(new Phrase(row.IdHospitalDepartament.ToString(), font));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    MessageBox.Show($"Отчет сохранен по пути: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /////
        public static void NewPdfReportOrderBasket(DataGrid dg, string leadparag, string tableName, string fileName)
        {
            try
            {
                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);

                // Выбор пути и имени файла через диалоговое окно
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"{fileName}.pdf"; // Название по умолчанию
                if (saveFileDialog.ShowDialog() == true)
                {
                    string path = saveFileDialog.FileName;

                    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                    pdfDoc.Open();
                    string imagePath = "LogoDoc/CRBLogo.jpg";

                    Paragraph leadparagraph = new Paragraph($"{leadparag}", font);
                    leadparagraph.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(leadparagraph);

                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);

                    image.ScaleToFit(pdfDoc.PageSize.Width / 2, pdfDoc.PageSize.Height / 2);
                    image.Alignment = 1;

                    pdfDoc.Add(image);

                    var spacer = new iTextSharp.text.Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfDoc.Add(spacer);

                    Paragraph paragraph = new Paragraph($"{tableName}", font);
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(paragraph);
                    pdfDoc.Add(spacer);

                    PdfPTable table = new PdfPTable(dg.Columns.Count);
                    foreach (DataGridColumn column in dg.Columns)
                    {
                        table.AddCell(new Phrase(column.Header.ToString(), font));
                    }

                    // Добавление данных из DataGrid
                    foreach (var item in dg.Items)
                    {
                        var row = item as OrderDeyails;
                        if (row != null)
                        {
                            table.AddCell(new Phrase(row.IdOrder.ToString(), font));
                            table.AddCell(new Phrase(row.IdMedicine.ToString(), font));
                            table.AddCell(new Phrase(row.Medicine.MedicineName, font));
                            table.AddCell(new Phrase(row.Medicine.Category.NameCategory, font));
                            table.AddCell(new Phrase(row.Medicine.Description, font));
                            table.AddCell(new Phrase(row.Quantity.ToString(), font));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    MessageBox.Show($"Отчет сохранен по пути: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
