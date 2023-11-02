using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IronPdf;
using System.IO;
using IronPdf.Rendering;
using System.Text;

namespace OnlineJobPortal.Presentation.Controllers
{
    //[Authorize(Roles = "Candidate")]
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateResume()
        {
            return View();
        }

        public IActionResult EditResume()
        {
            return View();
        }

        public IActionResult UploadCV(string htmlContent)
        {
            HtmlToPdf Renderer = new HtmlToPdf();

            // Renderer.PrintOptions.SetCustomPaperSizeInInches(8.5, 11);
            Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
            Renderer.PrintOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;
            Renderer.PrintOptions.Title = "Download PDF CV";

            // Renderer.PrintOptions.RenderDelay = 50; //ms
            // Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;
            // Renderer.PrintOptions.DPI = 300;
            // Renderer.PrintOptions.JpegQuality = 80;
            // Renderer.PrintOptions.GrayScale = false;
            // Renderer.PrintOptions.InputEncoding = Encoding.UTF8;
            // Renderer.PrintOptions.Zoom = 100;
            // Renderer.PrintOptions.ViewPortWidth = 1280;
            Renderer.PrintOptions.CreatePdfFormsFromHtml = true;
            Renderer.PrintOptions.CustomCssUrl = ".\\wwwroot\\css\\ResumePage\\main.css";
            Renderer.PrintOptions.MarginTop = 0;
            Renderer.PrintOptions.MarginLeft = 0;
            Renderer.PrintOptions.MarginRight = 0;
            Renderer.PrintOptions.MarginBottom = 0;
            Renderer.PrintOptions.FirstPageNumber = 1;

            var pdf = Renderer.RenderHtmlAsPdf(htmlContent);

            string uploadsPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/CVs");


            if (!Directory.Exists(uploadsPath))
            {
                Directory.CreateDirectory(uploadsPath);
            }

            string pdfFileName = Guid.NewGuid().ToString() + "_cv.pdf";
            string pdfFilePath = Path.Combine(uploadsPath, pdfFileName);

            System.IO.File.WriteAllBytes(pdfFilePath, pdf.BinaryData);


            var contentLength = pdf.BinaryData.Length;

            Response.Headers["Content-Length"] = contentLength.ToString();
            Response.Headers.Add("Content-Disposition", "inline; filename=cv.pdf");
            return File(pdf.BinaryData, "application/pdf");
        }
    }
}
