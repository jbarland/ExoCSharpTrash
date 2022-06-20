using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public enum Materials
    {
        Cardboard, Plastic, Wood, Metal
    }
    public class Box
    {
        public float Height { get; }// = 30.0f;
        public float Length { get; }// = 30.0f;
        public float Width { get; }// = 30.0f;
        // Note : plutôt set toutes les valeurs dans le constructeur s'il y en a un (souvent)

        private Label _labelRec;
        private Label _labelFragile;
        public Materials Material { get; private set; } = Materials.Cardboard;
        public string? Recipient { get; private set; }
        public bool Fragile { get; private set; }

        public static int Count
        {
            get; private set;
        }

        public Label LabelRec
        {
            get { return _labelRec; }
            private set { _labelRec = value; }
        }

        public Label LabelFragile
        {
            get { return _labelFragile; }
            private set { _labelFragile = value; }
        }

        public float Volume
        {
            get { return Height * Length * Width; }
        }



        public Box()
        {
            Height = 30f;
            Length = 30f;
            Width = 30f;
            Count++;
        }

        public Box(float height, float length, float width) : this()
        {
            Height = height;
            Length = length;
            Width = width;
        }

        public Box(float height, float length, float width, Materials material) : this(height, length, width)
        {
            Material = material;
        }

        public void Labelling(string recipient)
        {
            Recipient = recipient;
            _labelRec = new Label();
            _labelRec.Text = recipient;
            _labelRec.Color = Colors.Blanc;
            _labelRec.Size = Sizes.L;
        }

        public void Labelling(string recipient, bool isFragile)
        {
            Labelling(recipient);
            Fragile = isFragile;

            if (isFragile == true)
            {
                _labelFragile = new Label();
                _labelFragile.Text = "FRAGILE";
                _labelFragile.Color = Colors.Rouge;
                _labelFragile.Size = Sizes.S;

            }
        }

        public void Labelling(Label labelRec, Label labelFragile)
        {
            _labelRec = labelRec;
            _labelFragile = labelFragile;
        }

        public static bool Compare(Box box1, Box box2)
        {
            return (box1.Length == box2.Length
                && box1.Height == box2.Height
                && box1.Width == box2.Width
                && box1.Material == box2.Material);
        }
    }
}
