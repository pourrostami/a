namespace a.Client.Services.ProductService
{
    public interface IProductService
    {
        public ServiceResponse<Product> ServiceResponseProduct { get; set; }
        public List<Product> Products { get; set; }

        Task GetProductByIdAsync(int id);
        Task GetProductsAsync();
    }
}
