using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PizzariaDoZe.DAO;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    internal class ClassGeraPdf
    {
        readonly static string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly static string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        //métodos
        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new()
            {
                Title = "Selecione o local e o nome para salvar seu relatório",
                Filter = "Arquivo|*.pdf",
                FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf"
            };
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "PizzariaDoZe.pdf";
            }
        }

        public static void PdfSabor(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Sabor" + ((id == 0) ? "es" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(3, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Descricao")).SetBorder(Border.NO_BORDER));
                ///table.AddCell(new Cell().Add(new Paragraph("Categoria")).SetBorder(Border.NO_BORDER));
                ///table.AddCell(new Cell().Add(new Paragraph("Tipo")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Foto")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                SaborDAO saborDAO = new(provider, strConnection);
                Sabor sabor = new()
                {
                    Id = id,
                    Descricao = ""
                };
                DataTable linhas = saborDAO.Buscar(sabor);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    ///table.AddCell(new Cell().Add(new Paragraph(ClassEnum.GetDescription((EnumSaborCategoria)char.Parse(row[3].ToString())))).SetBorder(Border.NO_BORDER));
                    ///table.AddCell(new Cell().Add(new Paragraph(ClassEnum.GetDescription((EnumSaborTipo)char.Parse(row[4].ToString())))).SetBorder(Border.NO_BORDER));
                    // busca e seleciona os itens do sabor
                    sabor.Id = int.Parse(row[0].ToString());
                    try
                    {
                        table.AddCell(new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create((byte[])row[2]))).SetBorder(Border.NO_BORDER));
                    }
                    catch
                    {
                        table.AddCell(new Cell().Add(new Paragraph("Sem Imagem")).SetBorder(Border.NO_BORDER));
                    }
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void PdfIngrediente(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Ingrediente" + ((id == 0) ? "s" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(2, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Nome")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                IngredienteDAO ingredienteDAO = new(provider, strConnection);
                Ingrediente ingrediente = new()
                {
                    Id = id,
                    Nome = ""
                };
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    ingrediente.Id = int.Parse(row[0].ToString());
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void PdfCliente(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Cliente" + ((id == 0) ? "s" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(7, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Nome")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("CPF")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Telefone")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Email")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Numero")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Complemento")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                ClienteDAO clienteDAO = new(provider, strConnection);
                Cliente cliente = new()
                {
                    Id = id,
                    Nome = "",
                    CPF = "",
                    Telefone = "",
                    Email = "",
                    Numero = "",
                    Complemento = ""
                };
                DataTable linhas = clienteDAO.Buscar(cliente);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[2].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[3].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[4].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[5].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[6].ToString())).SetBorder(Border.NO_BORDER));
                    cliente.Id = int.Parse(row[0].ToString());
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void PdfFuncionario(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Funcionario" + ((id == 0) ? "s" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(12, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Nome")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("CPF")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Matricula")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Senha")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Carteira de Motorista")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Validade")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Observacao")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Telefone")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Email")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Numero")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Complemento")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                FuncionarioDAO funcionarioDAO = new(provider, strConnection);
                Funcionario funcionario = new()
                {
                    Id = id,
                    Nome = "",
                    CPF = "",
                    Matricula = "",
                    Senha = "",
                    CarteiraDeMotorista = "",
                    Validade= "",
                    Observacao = "",
                    Telefone = "",
                    Email = "",
                    Numero = "",
                    Complemento = ""
                };
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[2].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[3].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[4].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[5].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[6].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[7].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[8].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[9].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[10].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[11].ToString())).SetBorder(Border.NO_BORDER));
                    funcionario.Id = int.Parse(row[0].ToString());
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
