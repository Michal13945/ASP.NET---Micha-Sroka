using Data.Entities;
using DinkToPdf;
using DinkToPdf.Contracts;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using iTextSharp.tool.xml;
using Labolatorium3_app.Middlewares;
using Labolatorium3_app.Models;
using Labolatorium3_app.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PdfSharp.Pdf.Content.Objects;
using RazorLight;
using System.Text;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace Labolatorium3_app.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController( IContactService contactService)
        {
            _contactService = contactService;
        }


        public async Task<IActionResult> Index()
        {
            var contacts = _contactService.FindAll();

            return View(contacts);
        }

        public IActionResult PagedIndex([FromQuery] int page = 1, [FromQuery] int size = 5)
        {
            return View(_contactService.FindPage(page, size));
        }

        [HttpGet]
        public ActionResult Create()
        {
            Contact model = new Contact();

            var organizations = _contactService
                .FindAllOrganizations() ?? new List<OrganizationEntity>();

            model.Organizations = organizations
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList() ;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _contactService.FindById(id);

            if (model is null)
                return NotFound();

            model.Organizations = _contactService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Contact model) 
        { 
            if (ModelState.IsValid)
            {
                _contactService.Update(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) 
        {
            return View(_contactService.FindById(id));
        }

        public IActionResult BusinessCard(int id)
        {
            return View(_contactService.FindById(id));
        }

        public async Task<IActionResult> GeneratePdf(int id)
        {
            var model = _contactService.FindById(id);
            byte[] pdfBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Document document = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, ms);
                    document.Open();
                    document.Add(new Paragraph($"Nazwa: {model.Name}"));
                    document.Add(new Paragraph($"Email: {model.Email}"));
                    document.Add(new Paragraph($"Nr telefonu: {model.Phone}"));
                    document.Close();
                    writer.Close();
                }

                pdfBytes = ms.ToArray();
            }

            return File(pdfBytes, "application/pdf", "kontakt.pdf");
        }

        public async Task<IActionResult> GenerateCsv()
        {
            var models = _contactService.FindAll();
            var csv = new StringBuilder();

            csv.AppendLine("Name,Phone,Email");

            foreach (var contact in models)
            {
                var newLine = string.Format("{0},{1},{2}", contact.Name, contact.Phone, contact.Email);
                csv.AppendLine(newLine);
            }

            var contentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
            {
                FileName = "kontakty.csv"
            };

            Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
            return File(Encoding.UTF8.GetBytes(csv.ToString()), "text/csv");
        }

        [HttpGet]
        public ActionResult CreateApi()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApi(Contact c)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(c);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

  
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
