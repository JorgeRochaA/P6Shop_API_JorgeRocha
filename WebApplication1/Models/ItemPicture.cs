using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ItemPicture
    {
        public int IditemPicture { get; set; }
        public string ItemPictureUrl { get; set; } = null!;
        public int Idinventory { get; set; }

        public virtual Inventory IdinventoryNavigation { get; set; } = null!;
    }
}
