using Filme_Locadora.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Filme_Locadora.Models;
using System;
using System.Collections.Generic;



namespace Filme_Locadora.Controllers
{
    public class FilmesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Incluir()
        {
            //case sensitive. pegamos da classe categorias o tem Id e Descricao

            //Vamos encaminhar p view a lista de categorias pra que quando categoria for selecionada, o id faça parte do produto.
            ViewBag.ListaCategorias = new SelectList(DbFilmes.ListarCategorias(), "Id", "Descricao");
            return View();
        }
        //[HttpPost]
        //// POSTED DA IMAGEM 
        //public ActionResult Incluir(Tbfilmes filme, HttpPostedFileBase image)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Incluir();
        //    }
        //    // IMAGEM 
        //    if (image != null)
        //    {
        //        filme.MimeType = image.ContentType;
        //        filme.Foto = new byte[image.ContentLength];

        //        //Copiando os bytes da imagem recebida como parâmetro, na propriedade foto.
        //        //Parâmetros: 1° Quem vai receber os bytes? | 2° A partir de posição que a gente vai começar a tratar esses bytes? | 3° Tratar até o final 
        //        image.InputStream.Read(filme.Foto, 0, image.ContentLength);
        //    }

        //    DbFilmes.Incluir(filme);
        //    return RedirectToAction("Listar");
        //}

        ////IMAGEM 
        //public FileResult BuscarProduto(int id)
        //{
        //    try
        //    {
        //        var produto = DbFilmes.Buscar(id);
        //        if (produto != null)
        //        {
        //            if (produto.Foto != null)
        //            {
        //                return File(produto.Foto, produto.MimeType);
        //            }
        //        }
        //        return File("~/Images/ND.png", "image/jpeg");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        public ActionResult Listar()
        {
            return View(DbFilmes.Listar());
        }
    }

}