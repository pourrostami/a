namespace a.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; }= new List<Product>();
        public ServiceResponse<Product> ServiceResponseProduct { get; set; }

        public async Task GetProductByIdAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{id}");
            if (result != null && result.Data != null)
                ServiceResponseProduct = result;
        }

        public async Task GetProductsAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products");
            if(result!=null && result.Data !=null)
                Products = result.Data;
        }
    }
}
