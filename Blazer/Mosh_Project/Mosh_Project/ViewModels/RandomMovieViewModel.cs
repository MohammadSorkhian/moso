using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mosh_Project.Models;

namespace Mosh_Project.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}