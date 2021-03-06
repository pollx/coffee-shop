﻿using System;
using System.Web;

namespace CoffeeShop.WebUI
{
    public class CartIdentifier : ICartIdentifier
    {
        public const string CartSessionKey = "CartId";

        public string GetCardId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }

            return context.Session[CartSessionKey].ToString();
        }

        public void SetCartSessionKey(HttpContextBase context)
        {
            context.Session[CartSessionKey] = context.User.Identity.Name;
        }
    }
}