using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün İsmi geçersiz";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün limitini aştınız";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded ="Categori limit aşıldı";
        internal static string AuthorizationDenied ="Yetkiniz yok";
        internal static string UserRegistered="giriş yapıldı";
        internal static string PasswordError="parola hatası";
        internal static string SuccessfulLogin="başarılı giriş";
        internal static string UserAlreadyExists="kullanıcı mevcut";
        internal static string AccessTokenCreated="giriş tokenı yaratıldı";

        public static User UserNotFound { get; internal set; }
    }
}
