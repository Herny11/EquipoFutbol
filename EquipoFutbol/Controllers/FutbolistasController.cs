using EquipoFutbol.Context;
using EquipoFutbol.Entities;
using EquipoFutbol.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Controllers
{
    public class FutbolistasController : Controller
    {
        private readonly ApplicationContext _Data;

        public FutbolistasController(ApplicationContext Data)
        {
            _Data = Data;
        }
        public IActionResult Index()
        {
            return View(_Data.View_Futbolistas.ToList());
        }
        public ActionResult Nuevo()
        {
            var pos = new FutbolModels();
            pos.ListPosicion = new List<SelectListItem>
            {
               
            };

            return PartialView("~/Views/Futbolistas/Nuevo.cshtml", pos);
        }
        [HttpPost] // metodo de la accion
        public IActionResult Nuevo(Futbolistas fut)
        {

            bool status = false;
            var resultado = new { status = status };


            try
            {

                Futbolistas j = new Futbolistas
                {
                    Nombres = fut.Nombres,
                    Apellidos = fut.Apellidos,
                    Edad = fut.Edad,
                    PosicionID = fut.PosicionID,
                    FechaRegristro = fut.FechaRegristro,

                };
                _Data.Futbolistas.Add(j);
                if (_Data.SaveChanges() > 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            resultado = new { status };

            return Json(resultado);
        }

        public IActionResult EditarView(int FutbolistasID)
        {
            try
            {
                if (FutbolistasID > 0)
                {
                    Futbolistas Model = _Data.Futbolistas.Find(FutbolistasID);
                    return PartialView("~/Views/Futbolistas/EditarView.cshtml", Model);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        [HttpPost]

        public JsonResult Editar(Futbolistas cosas)
        {
            bool status = false;
            var resultado = new { status = status };

            try
            {
                Futbolistas model = new Futbolistas();
                model = _Data.Futbolistas.Find(cosas.FutbolistasID);

                model.Nombres = cosas.Nombres;
                model.Apellidos = cosas.Apellidos;
                model.PosicionID = cosas.PosicionID;
                model.Edad = cosas.Edad;
                model.FechaRegristro = cosas.FechaRegristro;

                _Data.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                if (_Data.SaveChanges() > 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            resultado = new { status = status };
            return Json(resultado);
        }

        public JsonResult Eliminar(int FutbolistasID)
        {

            bool status = false;
            var resultado = new { status = status };

            var futbolista = _Data.Futbolistas.Find(FutbolistasID);
            try
            {
                if (futbolista != null)
                {
                    _Data.Futbolistas.Remove(futbolista);

                    if (_Data.SaveChanges() > 0)
                    {
                        status = true;
                    }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            resultado = new { status = status };
            return Json(resultado);
        }

        public JsonResult GetPosicion()
        {
            List<Listados> posicion = new List<Listados>();
            posicion = _Data.Posiciones.Select(p => new Listados()
            {
                Posicion = p.Posicion,
                PosicionID = p.PosicionID
            }).ToList();

            return Json(posicion);

        }
        
    }
}
