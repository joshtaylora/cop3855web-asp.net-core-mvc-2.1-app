﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using cop3855web.Models;
using cop3855web.Models.ViewModels;
namespace SportsStore.Controllers 
{ 
    public class CartController : Controller 
    { 
        private IProductRepo repository; 
        private Cart cart; 
        public CartController(IProductRepo repo, Cart cartService) 
        { 
            repository = repo; 
            cart = cartService; 
        } 
        public ViewResult Index(string returnUrl) 
        { 
            return View(new CartIndexViewModel 
            { 
                Cart = cart, 
                ReturnUrl = returnUrl 
            }); 
        } 
        public RedirectToActionResult AddToCart(int productId, string returnUrl) 
        { 
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId); 
            if (product != null) 
            { 
                cart.AddItem(product, 1); 
            } 
            return RedirectToAction("Index", new { returnUrl }); 
        }
        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl) 
        { 
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId); 
            if (product != null) 
            { 
                cart.RemoveLine(product); 
            } 
            return RedirectToAction("Index", new { returnUrl }); 
        }
    }
}