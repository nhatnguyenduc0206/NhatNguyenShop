namespace NhatNguyen.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NhatNguyenShopDbContext dbContext;

        public NhatNguyenShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NhatNguyenShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}