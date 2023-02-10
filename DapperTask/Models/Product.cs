using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTask.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Country { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
}
