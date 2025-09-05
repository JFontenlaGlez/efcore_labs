using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Shared
{
    public class Dtos
    {
    }

    public record OrderDto(int Id, string CustomerName, int Items, decimal Total);
}
