﻿using System;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
