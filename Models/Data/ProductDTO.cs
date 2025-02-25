﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shop.Models.Data
{
    [Table("tblProducts")]
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string ImageName { get; set; }

        //Назначаем внешний ключ
        [ForeignKey("CategoryId")]//Назначаем явно внешний ключ
        public virtual CategoryDTO Category { get; set; }//Указываем где он
    }
}