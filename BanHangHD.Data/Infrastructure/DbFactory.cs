namespace BanHangHD.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BanHangHDDbContext dbContext;

        public BanHangHDDbContext Init()
        {
            return dbContext ?? (dbContext = new BanHangHDDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}