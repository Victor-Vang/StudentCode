using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Pet
    {
        public Pet()
        {

        }

        public Pet (string petName)
        {
            this.petName = petName;
        }

        public string petName = "Default Dog";

        public string PetType { get; set; }
        public int PetAge { get; set; }

        public string Color { get; private set; } = "brown";

        public void SetColor(string newColor)
        {
            Color = newColor;
        }

        private string eyeColor = "";
        public string EyeColor
        {
            get
            {
                return eyeColor;
            }
            set
            {
                if (value == "Black" || value == "Brown")
                {
                    eyeColor = value;
                }
            }
        }
        public string DisplayInfo()
        {
            return $"{petName} - {PetType} - {PetAge} - {Color} - {EyeColor}";
        }
    }
}
