using AdventOfCode2024.DaySolutions;

namespace AdventOfCode2024;

public partial class MegaForm : Form
{
    public MegaForm()
    {
        InitializeComponent();
    }

    private void btnDay1_Click(object sender, EventArgs e) => txtDay1Pt1.Text = Day1.Part1().ToString();    

    private void btnDay1Pt2_Click(object sender, EventArgs e) => txtDay1Pt2.Text = Day1.Part2().ToString();    
}
