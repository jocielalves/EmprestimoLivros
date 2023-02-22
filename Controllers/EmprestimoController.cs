using System.Collections.Generic;
using EmprestimoLivros.Data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private EmprestimoContext _dbContext;
        public EmprestimoController(EmprestimoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _dbContext.Emprestimos;
            return View(emprestimos);
        }
    }
}
