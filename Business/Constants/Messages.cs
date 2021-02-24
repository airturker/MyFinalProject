using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static sabittir new lenmez
    {
        public static string ProductAdded = "Ürün eklendi";//public ler PascalCase yazılır
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="bir kategoride en fazla 15 ürün olabilir";
        public static string ProductNameAlreadyExists="bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
