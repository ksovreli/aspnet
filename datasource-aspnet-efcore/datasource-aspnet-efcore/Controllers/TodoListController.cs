using datasource_aspnet_efcore.Data;
using datasource_aspnet_efcore.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace datasource_aspnet_efcore.Controllers
{
    public class TodoListController : Controller
    {
        private readonly TodoListContext _context;
        private readonly TodoListContext _todoListContext;

        public TodoListController(TodoListContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Models.Entities.TodoListItem> lists = await _context.todoListItems.ToListAsync();
            return View(lists);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TodoListItem todoListItem)
        {
            _todoListContext.Add(todoListItem);
            await _todoListContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id) {
            return View();  
        }
    }
}
