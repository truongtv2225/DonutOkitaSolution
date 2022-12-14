using Microsoft.AspNetCore.Mvc;
using Data.Context;
using Data.DomainClass;
using Data.ViewModels;
using Api.Services;
using Api.IServices;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CuaHangController : ControllerBase
    {
        private readonly ICuaHangService _iCuaHangService;
        public CuaHangController(DonutOkitaContext context)
        {
            _iCuaHangService = new CuaHangService(context);
        }

        // GET: api/cuahang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuaHang>>> Get()
        {
            return Ok(await _iCuaHangService.GetAll());
        }

        // GET: api/cuahang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuaHang>> Get(Guid id)
        {
            var result = await _iCuaHangService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/cuahang/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, CuaHang ch)
        {
            if (id != ch.Id)
            {
                return NotFound();
            }

            var result = await _iCuaHangService.Update(ch);

            return result != null ? NoContent() : StatusCode(StatusCodes.Status500InternalServerError, result);
        }

        // POST: api/cuahang
        [HttpPost]
        public async Task<ActionResult<CuaHang>> Post(CuaHang ch)
        {
            var result = await _iCuaHangService.Add(ch);

            return result != null ? CreatedAtAction("Get", new { id = ch.Id }, ch) : StatusCode(StatusCodes.Status500InternalServerError, result);
        }

        // DELETE: api/cuahang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cv = await _iCuaHangService.GetById(id);

            if (cv == null)
            {
                return NotFound();
            }

            var result = _iCuaHangService.Remove(cv);

            return result != null ? NoContent() : StatusCode(StatusCodes.Status500InternalServerError, result);
        }
    }
}
