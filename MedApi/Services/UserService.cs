using MedApi.Data;
using MedApi.Data.Entities;
using MedApi.Infrastructures.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Services
{
    public interface IUserService
    {
        Task<User> Login(string email, string password);
        Task<User> Register(User user);
        Task<User> CheckToken(string token);
    }

    public class UserService : IUserService
    {
        private readonly AppDbContext _context; //ilk islem bunlardir

        public UserService(AppDbContext context)//ve bunlari yaziriq
        {
            _context = context;
        }
        public async Task<User> CheckToken(string token)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Token == token);
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user != null && CryptoHelper.Crypto.VerifyHashedPassword(user.Password, password))
            {
                return user;
            }
            throw new HttpException(404, "E-poçt və ya şifrə yalnışdır");
        }

        public async Task<User> Register(User user)
        {
            var checkEmail = await _context.Users.AnyAsync(e => e.Email == user.Email);

            if (checkEmail)
            {
                throw new HttpException(409, "Bu email artıq mövcuddur");
            }
            user.Password = CryptoHelper.Crypto.HashPassword(user.Password);
            user.Token = CryptoHelper.Crypto.HashPassword(DateTime.Now.ToString());
            user.CreatAt = DateTime.Now;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
