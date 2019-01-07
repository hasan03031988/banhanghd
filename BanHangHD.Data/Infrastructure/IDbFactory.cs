using System;

namespace BanHangHD.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BanHangHDDbContext Init();
    }
}