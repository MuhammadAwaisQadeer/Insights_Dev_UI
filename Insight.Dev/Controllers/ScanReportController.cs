using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using Insight.Dev.Services;
using Insight.Dev.Models;
using CsvHelper;
using System.Globalization;
using System.Text;

namespace Insight.Dev.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ScanReportController : ControllerBase
    {
        private readonly ScanService _scanService;

        public ScanReportController(ScanService scanService)
        {
            _scanService = scanService;
        }

        [HttpGet("export/pdf")]
        public IActionResult ExportPdf()
        {
            var scans = _scanService.GetScans();

            using var memoryStream = new MemoryStream();
            using var writer = new PdfWriter(memoryStream);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            // **Title with Bold Formatting**
            PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            Paragraph title = new Paragraph(new Text("Scan Report").SetFont(boldFont).SetFontSize(18))
                .SetTextAlignment(TextAlignment.CENTER);
            document.Add(title);

            // **Table with Headers**
            Table table = new Table(4).UseAllAvailableWidth();
            PdfFont tableHeaderFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Scan Name").SetFont(tableHeaderFont))));
            table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Network Range").SetFont(tableHeaderFont))));
            table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Status").SetFont(tableHeaderFont))));
            table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Last Run").SetFont(tableHeaderFont))));

            // **Adding Data Rows**
            foreach (var scan in scans)
            {
                table.AddCell(new Cell().Add(new Paragraph(scan.ScanName)));
                table.AddCell(new Cell().Add(new Paragraph(scan.NetworkRange)));
                table.AddCell(new Cell().Add(new Paragraph(scan.Status)));
                table.AddCell(new Cell().Add(new Paragraph(scan.LastRun.ToString("g"))));
            }

            document.Add(table);
            document.Close();

            return File(memoryStream.ToArray(), "application/pdf", "ScanReport.pdf");
        }

        [HttpGet("export/csv")]
        public IActionResult ExportCsv()
        {
            var scans = _scanService.GetScans();
            using var memoryStream = new MemoryStream();
            using var writer = new StreamWriter(memoryStream, Encoding.UTF8);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(scans);
            writer.Flush();
            return File(memoryStream.ToArray(), "text/csv", "ScanReport.csv");
        }
    }
}
