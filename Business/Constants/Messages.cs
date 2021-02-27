using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç kayıt işlemi başarılı"; 
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";
        public static string CarDeleted = "Araç silme işlemi başarılı";

        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";

        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";

        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";

        public static string CustomerAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string CustomerUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string CustomerDeleted = "Kullanıcı silme işlemi başarılı";

        public static string RentalAdded = "Araç kiralama kayıt işlemi başarılı";
        public static string RentalUpdated = "Araç kiralama güncelleme işlemi başarılı";
        public static string RentalDeleted = "Araç kiralama silme işlemi başarılı";

        public static string CarImageLimitExceeded { get; internal set; }
        public static string CarImageDeleted { get; internal set; }
        public static string CarImageUpdated { get; internal set; }
    }
}
