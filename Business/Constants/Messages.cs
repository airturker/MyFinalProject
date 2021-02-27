using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied= "yetkiniz yok";
        public static string UserRegistered= "kullanıcı kayıt edildi";
        public static string UserNotFound= "kullanıcı bulunamadı";
        public static string PasswordError= "parola hatası";
        public static string SuccessfulLogin= "başarılı giriş";
        public static string UserAlreadyExists= "kullanıcı mevcut";
        public static string AccessTokenCreated= "token oluşturuldu";
    }
}
