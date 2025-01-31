using Store.Application.Enums;

namespace Store.Application.Models.Phones
{
    public class Phone
    {
        public  string Model { get; set; }
        public string Procesor { get; set; } 
        public uint Height { get; set; }
        public uint Width { get; set; }
        public PhoneColor Color { get; set; }
        public double Price { get; set; }
        public double DisplaySize { get; set; } = 4.4; 
        public double DisplayFullSize { get; set; } = 1280.920;
        public double DisplayGC { get; set; } = 60;
        public double MemorySize { get; set; } = 64;
        public double CameraMP { get; set; } = 6;
        public string Image {  get; set; }

        public uint Id { get; set; }
        
    }
}