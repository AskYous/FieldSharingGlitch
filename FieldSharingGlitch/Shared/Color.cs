using System.Collections.Generic;

namespace FieldSharingGlitch.Shared
{
    public class Color
    {
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool SatisfiesQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return true;
            query = query.ToLower();
            if (Name.ToLower().Contains(query)) return true;
            // if (Description.ToLower().Contains(query)) return true;
            return false;
        }
        public static List<Color> SampleData = new List<Color>
        {
            new Color {
                Name = "Red",
                Description = "Red is the color at the end of the visible spectrum of light, next to orange and opposite violet. [Wikipedia]",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Strawberries.jpg/1920px-Strawberries.jpg"
            },
            new Color {
                Name = "Yellow",
                Description = "Yellow is the color between orange and green on the spectrum of visible light. [Wikipedia]",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Ochre_quarry%2C_Roussillon%2C_France_%28465185258%29.jpg/1024px-Ochre_quarry%2C_Roussillon%2C_France_%28465185258%29.jpg"
            },
            new Color {
                Name = "Blue",
                Description = "Blue is one of the three primary colours of pigments in painting and traditional colour theory, as well as in the RGB colour model. It lies between violet and green on the spectrum of visible light. [Wikipedia]",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d8/Copper_sulfate.jpg",
            },
        };
    }
}
