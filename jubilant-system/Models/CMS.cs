using System;
using System.Collections.Generic;

namespace jubilant_system.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Component
    {
        public string id { get; set; }
        public string image { get; set; }
        public string header { get; set; }
        public string body { get; set; }
        public string button { get; set; }
        public string questions { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mapImage { get; set; }
        public string address { get; set; }
        public string accept { get; set; }
        public string denied { get; set; }
    }

    public class Page
    {
        public string order { get; set; }
        public string title { get; set; }
        public string active { get; set; }
        public List<Component> components { get; set; }
        public string languageType { get; set; }
    }

    public class CMS
    {
        public string primaryColor { get; set; }
        public string secondaryColor { get; set; }
        public string tertiaryColor { get; set; }
        public string quaternary { get; set; }
        public string primaryFont { get; set; }
        public string secondaryFont { get; set; }
        public string languageType { get; set; }
        public List<Page> page { get; set; }
    }


}
