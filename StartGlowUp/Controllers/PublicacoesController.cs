using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartGlowUp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StartGlowUp.Controllers
{
    public class PublicacoesController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult Publicar() 
        {
            return View();

        }
        [HttpPost]
        public IActionResult Publicar(string desc,string cod,string doc_user,string tag, int like) {
            IFormFile arquivo = Request.Form.Files[0];
            string tipoArquivo = arquivo.ContentType;
            if (tipoArquivo.Contains("png") || tipoArquivo.Contains("jpeg")) {
                MemoryStream s = new MemoryStream();
                arquivo.CopyToAsync(s);
                byte[] img = s.ToArray();

                Publicacoes p = new Publicacoes(desc, cod, doc_user, tag, like, img);
                p.Publicar();
            }
            return RedirectToAction("Publicar");

        }
        public IActionResult AdicionarLike(string cod_pub) {
            Publicacoes.AdicionarLike(cod_pub);
            return View();
        }
        public IActionResult ListarPublicacoes() {
            return View(Publicacoes.ListaPublicacoes());
        }
        public IActionResult ListarPublicacoesTag(string tag) {
            return View(Publicacoes.ListaPublicacoesComTag(tag));
        }
        public IActionResult ListarPublicacoesPerfil(string doc_user) {
            Usuario u = JsonConvert.DeserializeObject<Usuario>
        (HttpContext.Session.GetString("user").ToString());
            doc_user = u.Doc;
            return View(Publicacoes.ListaPublicacoesDePerfil(doc_user));

        }
        public IActionResult RetirarLike(string cod_pub) {
            Publicacoes.RetirarLike(cod_pub);
            return View();

        }
    }
}
