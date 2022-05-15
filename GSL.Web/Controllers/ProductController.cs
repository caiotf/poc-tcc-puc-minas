using GSL.Web.Models;
using GSL.Web.Services.IServices;
using GSL.Web.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GSL.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex()
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            var products = await _productService.FindAllProducts(accToken);
            return View(products);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProduct(model, accToken);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(int id)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            var model = await _productService.FindProductById(id, accToken);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductModel model)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProduct(model, accToken);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductDelete(int id)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            var model = await _productService.FindProductById(id, accToken);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ProductDelete(ProductModel model)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            var isExpiredToken = AccToken.IsExpiredAccToken(accToken);

            if (!HttpContext.User.Identity.IsAuthenticated || isExpiredToken)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            var response = await _productService.DeleteProductById(model.Id, accToken);
            if (response) return RedirectToAction(
                    nameof(ProductIndex));
            return View(model);
        }
    }
}