using Microsoft.AspNetCore.Mvc;
using ApiUsuario.Data;
using ApiUsuario.Models;
using System.Linq;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace ApiUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            user.Password = HashPassword(user.Password); // Criptografar senha
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        [HttpGet("{username}")]
        public IActionResult GetUser(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            return user != null ? Ok(user) : NotFound();
        }

        private string HashPassword(string password)
        {
            // Criptografia da senha usando PBKDF2
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Derive a chave
            var hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 32));

            return hash + ":" + Convert.ToBase64String(salt); // Armazena o hash e o salt
        }
    }
}
