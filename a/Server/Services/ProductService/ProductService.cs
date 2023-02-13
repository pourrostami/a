namespace a.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context= context;
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
        {
            var result = await _context.Products.FindAsync(id);
            var response = new ServiceResponse<Product>();
            if (result == null) { 
            response.Success= false;
                response.Message = "نیست وش باشد خیال اندر جهان";
            }
            else
            {
                response.Data= result;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>() { 
            Data= result
            };
            return response;
        }
    }
}
