using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // istâncias do tipo cliente
        Cliente cliente1 = new Cliente ( 01, "Hugo", "098.876.345.76", "hugohenry@", "baby" );
        Cliente cliente2 = new Cliente ( 02, "Miguel", "098.876.345.76", "hugohenry@", "live" );
        Cliente cliente3 = new Cliente ( 03, "Alex", "098.876.345.76", "hugohenry@", "gege" );
        Cliente cliente4 = new Cliente ( 04, "Higor", "098.876.345.76", "hugohenry@", "fred" );
        Cliente cliente5 = new Cliente ( 05, "José", "098.876.345.76", "hugohenry@", "lia" );

        // Lista de clientes e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // istâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor ( 01, "Hugo", "098.876.345.76", "hugohenry@","Atos" );
        Fornecedor fornecedor2 = new Fornecedor ( 02, "Miguel", "098.876.345.76", "hugohenry@","Fegus"  );
        Fornecedor fornecedor3 = new Fornecedor ( 03, "Alex", "098.876.345.76", "hugohenry@" ,"Lexa" );
        Fornecedor fornecedor4 = new Fornecedor  ( 04, "Higor", "098.876.345.76", "hugohenry@","KAkito"  );
        Fornecedor fornecedor5 = new Fornecedor  ( 05, "José", "098.876.345.76", "hugohenry@","Buli"  );

        // Lista de Fornecedores e atribuir os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
