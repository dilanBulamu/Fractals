using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PeerGrade5
{
    public partial class PeerGrade : Form
    {
        public PeerGrade()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.escape = new System.Windows.Forms.Button();
            this.sizeText = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.ComboBox();
            this.ratioTextValue = new System.Windows.Forms.Label();
            this.ratioText = new System.Windows.Forms.Label();
            this.ratio = new System.Windows.Forms.TrackBar();
            this.secondAngleTextValue = new System.Windows.Forms.Label();
            this.firstAngleTextValue = new System.Windows.Forms.Label();
            this.secondAngleText = new System.Windows.Forms.Label();
            this.secondAngle = new System.Windows.Forms.TrackBar();
            this.firstAngleText = new System.Windows.Forms.Label();
            this.firstAngle = new System.Windows.Forms.TrackBar();
            this.secondColor = new System.Windows.Forms.Button();
            this.firstColor = new System.Windows.Forms.Button();
            this.zoomText2 = new System.Windows.Forms.Label();
            this.colorsText = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zoom = new System.Windows.Forms.TrackBar();
            this.lengthText = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TrackBar();
            this.lenghtText2 = new System.Windows.Forms.Label();
            this.deep = new System.Windows.Forms.ComboBox();
            this.deepText = new System.Windows.Forms.Label();
            this.kindsOfFractalsText = new System.Windows.Forms.Label();
            this.kindsOfFractals = new System.Windows.Forms.ComboBox();
            this.options = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.chooseFirstColor = new System.Windows.Forms.ColorDialog();
            this.chooseSecondColor = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.escape);
            this.panel1.Controls.Add(this.sizeText);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(this.ratioTextValue);
            this.panel1.Controls.Add(this.ratioText);
            this.panel1.Controls.Add(this.ratio);
            this.panel1.Controls.Add(this.secondAngleTextValue);
            this.panel1.Controls.Add(this.firstAngleTextValue);
            this.panel1.Controls.Add(this.secondAngleText);
            this.panel1.Controls.Add(this.secondAngle);
            this.panel1.Controls.Add(this.firstAngleText);
            this.panel1.Controls.Add(this.firstAngle);
            this.panel1.Controls.Add(this.secondColor);
            this.panel1.Controls.Add(this.firstColor);
            this.panel1.Controls.Add(this.zoomText2);
            this.panel1.Controls.Add(this.colorsText);
            this.panel1.Controls.Add(this.apply);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.zoom);
            this.panel1.Controls.Add(this.lengthText);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.lenghtText2);
            this.panel1.Controls.Add(this.deep);
            this.panel1.Controls.Add(this.deepText);
            this.panel1.Controls.Add(this.kindsOfFractalsText);
            this.panel1.Controls.Add(this.kindsOfFractals);
            this.panel1.Controls.Add(this.options);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1250);
            this.panel1.TabIndex = 0;
            this.panel1.LocationChanged += new System.EventHandler(this.zoom_Scroll);
            // 
            // escape
            // 
            this.escape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.escape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.escape.Location = new System.Drawing.Point(15, 1180);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(370, 50);
            this.escape.TabIndex = 21;
            this.escape.Text = "Выход";
            this.escape.UseVisualStyleBackColor = false;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sizeText.Location = new System.Drawing.Point(15, 955);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(114, 32);
            this.sizeText.TabIndex = 20;
            this.sizeText.Text = "Масштаб";
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "1650;1250",
            "Полный",
            "Свернуть"});
            this.size.Location = new System.Drawing.Point(15, 990);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(320, 40);
            this.size.TabIndex = 19;
            this.size.SelectedValueChanged += new System.EventHandler(this.size_SelectedValueChanged);
            // 
            // ratioTextValue
            // 
            this.ratioTextValue.AutoSize = true;
            this.ratioTextValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ratioTextValue.Location = new System.Drawing.Point(313, 835);
            this.ratioTextValue.Name = "ratioTextValue";
            this.ratioTextValue.Size = new System.Drawing.Size(45, 32);
            this.ratioTextValue.TabIndex = 18;
            this.ratioTextValue.Text = "1,3";
            this.ratioTextValue.Visible = false;
            // 
            // ratioText
            // 
            this.ratioText.AutoSize = true;
            this.ratioText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ratioText.Location = new System.Drawing.Point(25, 835);
            this.ratioText.Name = "ratioText";
            this.ratioText.Size = new System.Drawing.Size(288, 32);
            this.ratioText.TabIndex = 17;
            this.ratioText.Text = "Соотношение отрезков: ";
            this.ratioText.Visible = false;
            // 
            // ratio
            // 
            this.ratio.Location = new System.Drawing.Point(15, 870);
            this.ratio.Maximum = 170;
            this.ratio.Minimum = 130;
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(340, 90);
            this.ratio.TabIndex = 16;
            this.ratio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ratio.Value = 130;
            this.ratio.Visible = false;
            this.ratio.Scroll += new System.EventHandler(this.ratio_Scroll);
            // 
            // secondAngleTextValue
            // 
            this.secondAngleTextValue.AutoSize = true;
            this.secondAngleTextValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.secondAngleTextValue.Location = new System.Drawing.Point(296, 713);
            this.secondAngleTextValue.Name = "secondAngleTextValue";
            this.secondAngleTextValue.Size = new System.Drawing.Size(40, 32);
            this.secondAngleTextValue.TabIndex = 15;
            this.secondAngleTextValue.Text = "10";
            this.secondAngleTextValue.Visible = false;
            // 
            // firstAngleTextValue
            // 
            this.firstAngleTextValue.AutoSize = true;
            this.firstAngleTextValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.firstAngleTextValue.Location = new System.Drawing.Point(296, 595);
            this.firstAngleTextValue.Name = "firstAngleTextValue";
            this.firstAngleTextValue.Size = new System.Drawing.Size(40, 32);
            this.firstAngleTextValue.TabIndex = 14;
            this.firstAngleTextValue.Text = "10";
            this.firstAngleTextValue.Visible = false;
            // 
            // secondAngleText
            // 
            this.secondAngleText.AutoSize = true;
            this.secondAngleText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.secondAngleText.Location = new System.Drawing.Point(25, 713);
            this.secondAngleText.Name = "secondAngleText";
            this.secondAngleText.Size = new System.Drawing.Size(258, 32);
            this.secondAngleText.TabIndex = 13;
            this.secondAngleText.Text = " Наклон левой ветки: ";
            this.secondAngleText.Visible = false;
            // 
            // secondAngle
            // 
            this.secondAngle.Location = new System.Drawing.Point(15, 750);
            this.secondAngle.Maximum = 50;
            this.secondAngle.Minimum = 10;
            this.secondAngle.Name = "secondAngle";
            this.secondAngle.Size = new System.Drawing.Size(340, 90);
            this.secondAngle.TabIndex = 12;
            this.secondAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.secondAngle.Value = 42;
            this.secondAngle.Visible = false;
            this.secondAngle.Scroll += new System.EventHandler(this.secondAngle_Scroll);
            // 
            // firstAngleText
            // 
            this.firstAngleText.AutoSize = true;
            this.firstAngleText.BackColor = System.Drawing.SystemColors.MenuText;
            this.firstAngleText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.firstAngleText.Location = new System.Drawing.Point(25, 595);
            this.firstAngleText.Name = "firstAngleText";
            this.firstAngleText.Size = new System.Drawing.Size(265, 32);
            this.firstAngleText.TabIndex = 11;
            this.firstAngleText.Text = "Наклон правой ветки: ";
            this.firstAngleText.Visible = false;
            // 
            // firstAngle
            // 
            this.firstAngle.BackColor = System.Drawing.Color.Black;
            this.firstAngle.Location = new System.Drawing.Point(15, 630);
            this.firstAngle.Maximum = 50;
            this.firstAngle.Minimum = 10;
            this.firstAngle.Name = "firstAngle";
            this.firstAngle.Size = new System.Drawing.Size(340, 90);
            this.firstAngle.TabIndex = 10;
            this.firstAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.firstAngle.Value = 16;
            this.firstAngle.Visible = false;
            this.firstAngle.Scroll += new System.EventHandler(this.firstAngle_Scroll);
            // 
            // secondColor
            // 
            this.secondColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.secondColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.secondColor.Location = new System.Drawing.Point(240, 480);
            this.secondColor.Name = "secondColor";
            this.secondColor.Size = new System.Drawing.Size(100, 100);
            this.secondColor.TabIndex = 9;
            this.secondColor.UseVisualStyleBackColor = false;
            this.secondColor.Click += new System.EventHandler(this.secondColor_Click);
            // 
            // firstColor
            // 
            this.firstColor.BackColor = System.Drawing.Color.Lime;
            this.firstColor.ForeColor = System.Drawing.Color.Lime;
            this.firstColor.Location = new System.Drawing.Point(60, 480);
            this.firstColor.Name = "firstColor";
            this.firstColor.Size = new System.Drawing.Size(100, 100);
            this.firstColor.TabIndex = 8;
            this.firstColor.UseVisualStyleBackColor = false;
            this.firstColor.Click += new System.EventHandler(this.firstColor_Click);
            // 
            // zoomText2
            // 
            this.zoomText2.AutoSize = true;
            this.zoomText2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.zoomText2.Location = new System.Drawing.Point(25, 348);
            this.zoomText2.Name = "zoomText2";
            this.zoomText2.Size = new System.Drawing.Size(172, 32);
            this.zoomText2.TabIndex = 7;
            this.zoomText2.Text = "Приближение";
            // 
            // colorsText
            // 
            this.colorsText.AutoSize = true;
            this.colorsText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.colorsText.Location = new System.Drawing.Point(60, 438);
            this.colorsText.Name = "colorsText";
            this.colorsText.Size = new System.Drawing.Size(267, 32);
            this.colorsText.TabIndex = 0;
            this.colorsText.Text = "1 Цвет               2 Цвет";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.LimeGreen;
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply.Location = new System.Drawing.Point(15, 1050);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(370, 50);
            this.apply.TabIndex = 0;
            this.apply.Text = "Применить";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MintCream;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(15, 1115);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(370, 50);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить фрактал";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(15, 380);
            this.zoom.Maximum = 6;
            this.zoom.Minimum = 1;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(340, 90);
            this.zoom.TabIndex = 1;
            this.zoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoom.Value = 1;
            this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
            // 
            // lengthText
            // 
            this.lengthText.AutoSize = true;
            this.lengthText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lengthText.Location = new System.Drawing.Point(201, 255);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(40, 32);
            this.lengthText.TabIndex = 1;
            this.lengthText.Text = "50";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(15, 290);
            this.length.Maximum = 1000;
            this.length.Minimum = 50;
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(340, 90);
            this.length.TabIndex = 1;
            this.length.TickStyle = System.Windows.Forms.TickStyle.None;
            this.length.Value = 50;
            this.length.Scroll += new System.EventHandler(this.Length_Scroll);
            // 
            // lenghtText2
            // 
            this.lenghtText2.AutoSize = true;
            this.lenghtText2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lenghtText2.Location = new System.Drawing.Point(15, 255);
            this.lenghtText2.Name = "lenghtText2";
            this.lenghtText2.Size = new System.Drawing.Size(196, 32);
            this.lenghtText2.TabIndex = 1;
            this.lenghtText2.Text = " Длина отрезка: ";
            // 
            // deep
            // 
            this.deep.DisplayMember = "3";
            this.deep.FormattingEnabled = true;
            this.deep.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.deep.Location = new System.Drawing.Point(15, 200);
            this.deep.Name = "deep";
            this.deep.Size = new System.Drawing.Size(320, 40);
            this.deep.TabIndex = 4;
            // 
            // deepText
            // 
            this.deepText.AutoSize = true;
            this.deepText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deepText.Location = new System.Drawing.Point(15, 165);
            this.deepText.Name = "deepText";
            this.deepText.Size = new System.Drawing.Size(104, 32);
            this.deepText.TabIndex = 3;
            this.deepText.Text = "Глубина";
            // 
            // kindsOfFractalsText
            // 
            this.kindsOfFractalsText.AutoSize = true;
            this.kindsOfFractalsText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.kindsOfFractalsText.Location = new System.Drawing.Point(12, 85);
            this.kindsOfFractalsText.Name = "kindsOfFractalsText";
            this.kindsOfFractalsText.Size = new System.Drawing.Size(163, 32);
            this.kindsOfFractalsText.TabIndex = 1;
            this.kindsOfFractalsText.Text = "Вид фрактала";
            // 
            // kindsOfFractals
            // 
            this.kindsOfFractals.FormattingEnabled = true;
            this.kindsOfFractals.Items.AddRange(new object[] {
            "1. Дерево",
            "2. Кривая Коха",
            "3. Ковер Серпинского",
            "4. Треугольник Серпинского",
            "5. Множество Кантора",
            "6. Множество Мандельброта"});
            this.kindsOfFractals.Location = new System.Drawing.Point(15, 120);
            this.kindsOfFractals.Name = "kindsOfFractals";
            this.kindsOfFractals.Size = new System.Drawing.Size(320, 40);
            this.kindsOfFractals.TabIndex = 2;
            this.kindsOfFractals.SelectedIndexChanged += new System.EventHandler(this.kindsOfFractals_SelectedIndexChanged);
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.options.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.options.Location = new System.Drawing.Point(92, 15);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(205, 50);
            this.options.TabIndex = 1;
            this.options.Text = "Настройки";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.picture);
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 1250);
            this.panel2.TabIndex = 1;
            this.panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel2_Scroll);
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1000, 1000);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // chooseFirstColor
            // 
            this.chooseFirstColor.Color = System.Drawing.Color.Lime;
            // 
            // chooseSecondColor
            // 
            this.chooseSecondColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // PeerGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1650, 1250);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeerGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PeerGrade_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeerGrade_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PeerGrade_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PeerGrade_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Length_Scroll(object sender, EventArgs e)
        {
            lengthText.Text = length.Value.ToString();
        }
        GetColor colors;
        Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        private void Fractals(object sender, EventArgs e)
        {
            int width = picture.Width;
            int height = picture.Height;
            Bitmap bmp = new Bitmap(width, height);
            if (deep.SelectedItem != null)
            {
                colors = new GetColor(chooseFirstColor.Color, chooseSecondColor.Color, int.Parse(deep.Text));
                if (kindsOfFractals.Text == "1. Дерево")
                {
                    Tree ob = new Tree(length.Value, int.Parse(deep.Text), firstAngle.Value, secondAngle.Value, ratio.Value / 100.0, picture, colors);
                    ob.Draw(width / 2, 0, ob.Length, 0, 0, ob.Deep, bmp);
                }
                else if (kindsOfFractals.Text == "2. Кривая Коха")
                {
                    Koch ob = new Koch(Width - 500, int.Parse(deep.Text), picture, colors);
                    ob.DrawKoch((width - ob.Length) / 2, height - 50, width - (width - ob.Length) / 2, height - 50, ob.Deep, bmp);
                }
                else if (kindsOfFractals.Text == "3. Ковер Серпинского")
                {
                    colors.Deep += 1;
                    Carpet ob = new Carpet(length.Value, int.Parse(deep.Text), picture, colors);
                    ob.DrawCarpet(0, 0, ob.Deep, (int)(picture.Height / 3.0), bmp);
                }
                else if (kindsOfFractals.Text == "4. Треугольник Серпинского")
                {
                    Triangle ob = new Triangle(length.Value, int.Parse(deep.Text), picture, colors);
                    ob.DrawTriangle(new Point((width - ob.Length) / 2, height - 50), new Point(width - (width - ob.Length) / 2, height - 50), new Point(width / 2, height - 50 - (int)(ob.Length * Math.Sqrt(3) / 2)), ob.Deep, bmp);
                }
                else if (kindsOfFractals.Text == "5. Множество Кантора")
                {
                    Cantor ob = new Cantor(picture.Width - 100, int.Parse(deep.Text), length.Value, picture, colors);
                    ob.DrawCantor(50, 50, ob.Deep, ob.Length, bmp);
                }
            }
            if (kindsOfFractals.Text == "6. Множество Мандельброта")
            {
                Bonus ob = new Bonus(picture);
                ob.DrawMandelbrot(bmp);
            }
            zoom.Value = 1;
            org = new PictureBox();
            org.Image = picture.Image;
        }
        private void apply_Click(object sender, EventArgs e)
        {
            picture.Image = null;
            org.Image = null;
            Fractals(sender, e);
        }
        Image Zoom(Image image, Size size)
        {
            Bitmap bmp = new Bitmap(image, image.Width * size.Width, image.Height * size.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }
        private void ChooseFirstColor(object sender, EventArgs e)
        {
            chooseFirstColor.ShowDialog();
            if (chooseFirstColor.Color != Color.Empty)
            {
                firstColor.BackColor = chooseFirstColor.Color;
            }
        }
        private void ChooseSecondColor(object sender, EventArgs e)
        {
            chooseSecondColor.ShowDialog();
            if (chooseSecondColor.Color != Color.Empty)
            {
                secondColor.BackColor = chooseSecondColor.Color;
            }
        }


        private void firstColor_Click(object sender, EventArgs e)
        {
            firstColor.Click += ChooseFirstColor;
        }

        private void secondColor_Click(object sender, EventArgs e)
        {
            secondColor.Click += ChooseSecondColor;
        }
        PictureBox org;
        private void PeerGrade_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1650, 1250);
            zoom.Minimum = 1;
            zoom.Maximum = 6;
            zoom.SmallChange = 1;
            zoom.LargeChange = 1;
            zoom.UseWaitCursor = false;
            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = picture.Image;
        }
        private void zoom_Scroll(object sender, EventArgs e)
        {
            if (zoom.Value != 0)
            {
                picture.Image = null;
                if (org?.Image != null)
                {
                    picture.Image = Zoom(org.Image, new Size(zoom.Value, zoom.Value));
                }
            }
        }
        // Настройки в зависимости от выбранного фрактала.
        private void kindsOfFractals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kindsOfFractals.SelectedItem == "1. Дерево")
            {
                firstAngle.Visible = true;
                firstAngleText.Visible = true;
                firstAngleTextValue.Visible = true;
                secondAngle.Visible = true;
                secondAngleText.Visible = true;
                secondAngleTextValue.Visible = true;
                ratioText.Visible = true;
                ratioTextValue.Visible = true;
                ratio.Visible = true;
                length.Maximum = 400;
            }
            else
            {
                firstAngle.Visible = false;
                firstAngleText.Visible = false;
                firstAngleTextValue.Visible = false;
                secondAngle.Visible = false;
                secondAngleText.Visible = false;
                secondAngleTextValue.Visible = false;
                ratioText.Visible = false;
                ratioTextValue.Visible = false;
                ratio.Visible = false;
            }
            if (kindsOfFractals.SelectedItem == "3. Ковер Серпинского" || kindsOfFractals.SelectedItem == "6. Множество Мандельброта" || kindsOfFractals.SelectedItem == "2. Кривая Коха")
            {
                length.Visible = false;
                lenghtText2.Visible = false;
                lengthText.Visible = false;
                if (kindsOfFractals.SelectedItem == "6. Множество Мандельброта")
                {
                    deep.Visible = false;
                    deepText.Visible = false;
                    colorsText.Visible = false;
                    firstColor.Visible = false;
                    secondColor.Visible = false;
                }
                else
                {
                    deep.Visible = true;
                    deepText.Visible = true;
                    colorsText.Visible = true;
                    firstColor.Visible = true;
                    secondColor.Visible = true;
                }
            }
            else
            {
                length.Visible = true;
                lenghtText2.Visible = true;
                lengthText.Visible = true;
                deep.Visible = true;
                deepText.Visible = true;
                colorsText.Visible = true;
                firstColor.Visible = true;
                secondColor.Visible = true;
            }
            if (kindsOfFractals.SelectedItem == "4. Треугольник Серпинского")
            {
                length.Maximum = Math.Min((int)((Height * 2 * Math.Sqrt(3)) / 3) - 100, Width - 500);
            }
            if (kindsOfFractals.Text == "5. Множество Кантора")
            {
                length.Maximum = Height / 7;
            }
            lengthText.Text = length.Value.ToString();
        }

        private void firstAngle_Scroll(object sender, EventArgs e)
        {
            firstAngleTextValue.Text = firstAngle.Value.ToString();
        }

        private void secondAngle_Scroll(object sender, EventArgs e)
        {
            secondAngleTextValue.Text = secondAngle.Value.ToString();
        }

        private void ratio_Scroll(object sender, EventArgs e)
        {
            ratioTextValue.Text = (ratio.Value / 100.0).ToString();
        }
        // Настройки в зависимости от выбранного разрешения.
        private void size_SelectedValueChanged(object sender, EventArgs e)
        {
            int currentHeight = Height;
            if (size.SelectedItem == "Полный")
            {
                this.WindowState = FormWindowState.Maximized;
                picture.Width = resolution.Height;
                picture.Height = resolution.Height;
                picture.Location = new Point(Width / 2 + 200, 0);
            }
            else if (size.SelectedItem == "1650;1250")
            {
                this.WindowState = FormWindowState.Normal;
                Size = new System.Drawing.Size(1650, 1250);
                picture.Width = 1250;
                picture.Height = 1250;
                picture.Location = new Point(0, 0);
                Location = new Point(resolution.Width / 2 - 825, resolution.Height / 2 - 665);
            }
            else if (size.SelectedItem == "Свернуть")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            if (size.SelectedItem != "Свернуть")
            {
                if (kindsOfFractals.SelectedItem == "4. Треугольник Серпинского")
                {
                    length.Maximum = Math.Min((int)((Height * 2 * Math.Sqrt(3)) / 3) - 100, Width - 500);
                }
                if (kindsOfFractals.Text == "5. Множество Кантора")
                {
                    length.Maximum = Height / 7;
                }
                length.Value = Math.Max(Math.Min(length.Value * Height / currentHeight, length.Maximum), length.Minimum);
                lengthText.Text = length.Value.ToString();
                apply_Click(sender, e);
            }
        }

        private void escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool move = false;
        private int downMouseX, downMouseY;

        private void PeerGrade_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                var cursor = new Point();
                cursor.X = Location.X + (e.X - downMouseX);
                cursor.Y = Location.Y + (e.Y - downMouseY);
                Location = cursor;
            }
        }

        private void PeerGrade_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move = false;
            }
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            picture.Width = Math.Max(picture.Width, panel2.Width);
            picture.Height = Math.Max(picture.Height, panel2.Height);
            picture.Location = new Point(0, 0);
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Refresh();
        }
        // Сохранение изображения.
        private void save_Click(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                if (picture.Image != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Сохранить картинку как...";
                    sfd.OverwritePrompt = true;
                    sfd.CheckPathExists = true;
                    sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All Files(*.*)|*.*";
                    sfd.ShowHelp = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            picture.Image.Save(sfd.FileName);

                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PeerGrade_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move = true;
                downMouseX = e.X;
                downMouseY = e.Y;
            }
        }
    }
}
