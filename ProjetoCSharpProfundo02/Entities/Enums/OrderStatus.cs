using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharpProfundo02.Entities.Enums
{
    public enum OrderStatus : int 
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
