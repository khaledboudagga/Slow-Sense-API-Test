using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Slow_Sense.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly ShapesTestContext _context;

        public ShapeController(ShapesTestContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Shape> GetAllShapes()
        {
            return _context.Shapes.ToList();
        }

    }
}
