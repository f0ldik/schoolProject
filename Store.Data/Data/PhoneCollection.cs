using Store.Application.Enums;
using Store.Application.Models;
using Store.Application.Models.Phones;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Store.Data.Data
{
    public static class SeedPhoneCollection
    {
        public static List<Store.Application.Models.Phones.Phone> GetAll()
        {
            var iPhone14Plus = new Iphone
            {
                Model = "iPhone 14 Plus",
                Procesor = "Apple A15 Bionic",
                DisplaySize = 6.7,
                DisplayFullSize = 2778.1284,
                DisplayGC = 60,
                MemorySize = 128,
                CameraMP = 12,
                Image = "/Images/14pls.png",
                Height = 11,
                Width = 5,
                Color = PhoneColor.Black,
                Price = 36999,
                SpeedCharging = true,
                HasChargingBlock = false,
                Id = 1,
            };

            var Iphone15promax = new Iphone
            {
                Model = "Iphone 15 Pro Max",
                Procesor = "Apple A17 Pro",
                DisplaySize = 6.7,
                DisplayFullSize = 2796.1290,
                DisplayGC = 120,
                MemorySize = 512,
                CameraMP = 12,
                Image = "/Images/15prm.png",
                Height = 12,
                Width = 6,
                Color = PhoneColor.White,
                Price = 64999,
                SpeedCharging = true,
                HasChargingBlock = false,
                Id = 2,
            };

            var GOOGLEPixelFold = new Poco
            {
                Model = "GOOGLE Pixel Fold",
                MemorySize = 512,
                DisplaySize = 5.8,
                DisplayFullSize = 2092.1080,
                DisplayGC = 120,
                CameraMP = 48,
                Procesor = "Google Tensor G2",
                Image = "/Images/GOOGLEPixelFold.png",
                Height = 12,
                Width = 7,
                Price = 55999,
                Color = PhoneColor.Blue,
                SimCardsCount = 3,
                Id = 3,
            };

            var GOOGLEPixel8Pro = new Poco
            {
                Model = "GOOGLE Pixel 8 Pro",
                MemorySize = 512,
                DisplaySize = 6.7,
                DisplayFullSize = 2992.1344,
                DisplayGC = 120,
                CameraMP = 146,
                Procesor = "Google Tensor G3",
                Image = "/Images/GOOGLEPixel8Pro.png",
                Height = 15,
                Width = 7,
                Price = 30999,
                Color = PhoneColor.Red,
                SimCardsCount = 2,
                Id = 4,
            };

            var SamsungGalaxyFold5 = new Samsung
            {
                Model = "Samsung Galaxy Fold 5",
                MemorySize = 1024,
                DisplaySize = 7.6,
                DisplayFullSize = 2176.1812,
                DisplayGC = 120,
                CameraMP = 72,
                Procesor = "Qualcomm Snapdragon 8 Gen 2 for Galaxy",
                Image = "/Images/SamsungGalaxyFold5.png",
                Height = 14,
                Width = 6,
                Price = 73899,
                Color = PhoneColor.Black,
                ShockProof = false,
                Waterproof = true,
                Id = 5,
            };

            var SamsungGalaxyS24Ultra  = new Samsung
            {
                Model = "Samsung Galaxy S24 Ultra",
                MemorySize = 1024,
                DisplaySize = 6.8,
                DisplayFullSize = 3120.1440,
                DisplayGC = 120,
                CameraMP = 272,
                Procesor = "Qualcomm Snapdragon 8 Gen 3 for Galaxy",
                Image = "/Images/SamsungGalaxyS24Ultra.png",
                Height = 15,
                Width = 7,
                Price = 64799,
                Color = PhoneColor.Yellow,
                ShockProof = true,
                Waterproof = true,
                Id = 6,
            };
            return new List<Store.Application.Models.Phones.Phone> { GOOGLEPixel8Pro, SamsungGalaxyS24Ultra , SamsungGalaxyFold5, GOOGLEPixel8Pro, GOOGLEPixelFold, iPhone14Plus, Iphone15promax };
        }
    }
}