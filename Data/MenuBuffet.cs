namespace SayakaWebApp.Data
{
    public class MenuBuffet
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public string Image {  get; set; } = string.Empty;
    }
}
