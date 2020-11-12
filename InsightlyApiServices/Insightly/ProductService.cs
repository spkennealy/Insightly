using System;
using System.Collections.Generic;
using System.Linq;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class ProductService : CrudService<Product>
    {
        public ProductService(string apiKey) : base(apiKey, "Product")
        {
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                Utils.LogMessage($"Getting all products...");

                var products = GetAll().Result;
                var s = products != null && products.Count() > 1 ? "s" : string.Empty;
                if (products != null && products.Count() > 0) Utils.LogMessage($"Successfully retrieved {products.Count()} product{s}!");
                return products;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting all products: {ex.Message}");
                throw;
            }
        }

        public Product GetProduct(long? productId)
        {
            try
            {
                if (productId == null) return null;
                Utils.LogMessage($"Getting product #{productId}...");

                var product = Get((long)productId).Result;
                if (product != null) Utils.LogMessage($"Successfully found product, {product.PRODUCT_NAME}");
                return product;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Getting product #{productId}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<Product> SearchProductsByFieldValue(string fieldName, object fieldValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fieldName) || fieldValue == null) return null;
                Utils.LogMessage($"Searching for products with {fieldValue} in {fieldName}...");

                var products = Search(fieldName, fieldValue).Result;
                var s = products != null && products.Count() > 1 ? "s" : string.Empty;
                if (products != null && products.Count() > 0) Utils.LogMessage($"Successfully found {products.Count()} product{s}!");
                return products;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for products with {fieldValue} in {fieldName}: {ex.Message}");
                throw;
            }
        }

        public Product CreateProduct(Product product)
        {
            try
            {
                if (product == null) return null;
                Utils.LogMessage($"Creating product, {product?.PRODUCT_NAME}...");

                product = Create(product).Result;
                if (product != null) Utils.LogMessage($"Successfully created product, {product.PRODUCT_ID}!");
                return product;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Creating product, {product?.PRODUCT_NAME}: {ex.Message}");
                throw;
            }
        }

        public Product UpdateProduct(Product product)
        {
            try
            {
                if (product == null) return null;
                Utils.LogMessage($"Updating product #{product?.PRODUCT_ID}...");

                product = Update(product).Result;
                if (product != null) Utils.LogMessage($"Successfully updated product, {product.PRODUCT_NAME}!");
                return product;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Updating product #{product?.PRODUCT_ID}: {ex.Message}");
                throw;
            }
        }

        public bool DeleteProduct(long? productId)
        {
            try
            {
                if (productId == null) return false;
                Utils.LogMessage($"Deleting product #{productId}...");

                var deleted = Delete((long)productId).Result;
                if (deleted) Utils.LogMessage($"Successfully deleted product #{productId}!");
                return deleted;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Deleting product #{productId}: {ex.Message}");
                throw;
            }
        }
    }
}
