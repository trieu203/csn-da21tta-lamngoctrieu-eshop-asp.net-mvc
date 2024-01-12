using doancsn.Data;
using Microsoft.AspNetCore.Mvc;

namespace doancsn.Models
{
	public class Navbar: ViewComponent
	{
		private readonly doancsnContext _context;

		public Navbar(doancsnContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
