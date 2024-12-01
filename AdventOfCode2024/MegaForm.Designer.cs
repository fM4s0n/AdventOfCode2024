namespace AdventOfCode2024;

partial class MegaForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnDay1Part1 = new Button();
        txtDay1Pt1 = new TextBox();
        btnDay1Pt2 = new Button();
        txtDay1Pt2 = new TextBox();
        SuspendLayout();
        // 
        // btnDay1Part1
        // 
        btnDay1Part1.Location = new Point(54, 35);
        btnDay1Part1.Name = "btnDay1Part1";
        btnDay1Part1.Size = new Size(92, 23);
        btnDay1Part1.TabIndex = 0;
        btnDay1Part1.Text = "Day 1 Part 1";
        btnDay1Part1.UseVisualStyleBackColor = true;
        btnDay1Part1.Click += btnDay1_Click;
        // 
        // txtDay1Pt1
        // 
        txtDay1Pt1.Location = new Point(170, 35);
        txtDay1Pt1.Name = "txtDay1Pt1";
        txtDay1Pt1.Size = new Size(100, 23);
        txtDay1Pt1.TabIndex = 1;
        // 
        // btnDay1Pt2
        // 
        btnDay1Pt2.Location = new Point(54, 75);
        btnDay1Pt2.Name = "btnDay1Pt2";
        btnDay1Pt2.Size = new Size(92, 23);
        btnDay1Pt2.TabIndex = 2;
        btnDay1Pt2.Text = "Day 1 Part 2";
        btnDay1Pt2.UseVisualStyleBackColor = true;
        btnDay1Pt2.Click += btnDay1Pt2_Click;
        // 
        // txtDay1Pt2
        // 
        txtDay1Pt2.Location = new Point(170, 75);
        txtDay1Pt2.Name = "txtDay1Pt2";
        txtDay1Pt2.Size = new Size(100, 23);
        txtDay1Pt2.TabIndex = 3;
        // 
        // MegaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(txtDay1Pt2);
        Controls.Add(btnDay1Pt2);
        Controls.Add(txtDay1Pt1);
        Controls.Add(btnDay1Part1);
        Name = "MegaForm";
        Text = "MegaForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDay1Part1;
    private TextBox txtDay1Pt1;
    private Button btnDay1Pt2;
    private TextBox txtDay1Pt2;
}