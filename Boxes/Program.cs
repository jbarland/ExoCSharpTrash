using Boxes;

Box box1 = new(10f, 12f, 4f);
// OU
Box box2 = new Box(5f, 5f, 5f, Materials.Plastic);
// OU
var box3 = new Box();

Console.WriteLine(box1.Material);
Console.WriteLine(box2.Material);
Console.WriteLine(box3.Volume);

Label label1 = new Label()
{
    Text = "Je suis une étiquette",
    Color = Colors.Bleu,
    Size = Sizes.M,
};

Console.WriteLine($"texte : {label1.Text}\n" +
    $"couleur : {label1.Color}\n" +
    $"format : {label1.Size}");

Box boxTestLabel = new Box(30f, 40f, 50f);

boxTestLabel.Labelling("Dominique", true);

Label labelTest = new Label()
{
    Text = boxTestLabel.Recipient,
    Color = Colors.Blanc,
    Size = Sizes.L,
};

Label labelTest2 = new Label()
{
    Text = "TRES FRAGILE",
    Color = Colors.Rouge,
    Size = Sizes.S,
};

boxTestLabel.Labelling(labelTest, labelTest2);

Console.WriteLine(boxTestLabel.LabelRec.Text);
Console.WriteLine(boxTestLabel.LabelFragile.Text);

Console.WriteLine(Box.Count);

Box box5 = new Box(12f, 13f, 14f, Materials.Plastic);
Box box6 = new Box(12f, 13f, 14f, Materials.Plastic);

Console.WriteLine(Box.Compare(box5, box6));