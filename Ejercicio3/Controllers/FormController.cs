using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(Datos data, Vehiculo v)
        {

            data.Vehiculos.Add(v);
            return View(data);
        }
    }
}