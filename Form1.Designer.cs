
namespace OpenCV
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openImage = new System.Windows.Forms.Button();
            this.pathImage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.isFilter = new System.Windows.Forms.CheckBox();
            this.isBinary = new System.Windows.Forms.CheckBox();
            this.gradationGrey = new System.Windows.Forms.CheckBox();
            this.applySetting = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBlurH = new System.Windows.Forms.TrackBar();
            this.trackBlurV = new System.Windows.Forms.TrackBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.trackGausian = new System.Windows.Forms.TrackBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.trackMedian = new System.Windows.Forms.TrackBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.orderY = new System.Windows.Forms.NumericUpDown();
            this.orderX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackSizeSobel = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spaceSigma = new System.Windows.Forms.NumericUpDown();
            this.colorSigma = new System.Windows.Forms.NumericUpDown();
            this.kernelSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackRotate = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.heightImage = new System.Windows.Forms.NumericUpDown();
            this.widthImage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRotate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.numKsize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.groupSettings.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlurH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlurV)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGausian)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMedian)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeSobel)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotate)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKsize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openImage);
            this.groupBox1.Controls.Add(this.pathImage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расположение";
            // 
            // openImage
            // 
            this.openImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openImage.Location = new System.Drawing.Point(583, 13);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(75, 22);
            this.openImage.TabIndex = 1;
            this.openImage.Text = "Открыть";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // pathImage
            // 
            this.pathImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pathImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathImage.Location = new System.Drawing.Point(6, 18);
            this.pathImage.Name = "pathImage";
            this.pathImage.ReadOnly = true;
            this.pathImage.Size = new System.Drawing.Size(571, 13);
            this.pathImage.TabIndex = 0;
            this.pathImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pathImage.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sourceImage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 656);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изображение";
            // 
            // sourceImage
            // 
            this.sourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImage.Location = new System.Drawing.Point(3, 16);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(658, 637);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 0;
            this.sourceImage.TabStop = false;
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.numKsize);
            this.groupSettings.Controls.Add(this.isFilter);
            this.groupSettings.Controls.Add(this.isBinary);
            this.groupSettings.Controls.Add(this.gradationGrey);
            this.groupSettings.Controls.Add(this.applySetting);
            this.groupSettings.Controls.Add(this.groupBox7);
            this.groupSettings.Controls.Add(this.groupBox8);
            this.groupSettings.Controls.Add(this.groupBox9);
            this.groupSettings.Controls.Add(this.groupBox10);
            this.groupSettings.Controls.Add(this.groupBox6);
            this.groupSettings.Controls.Add(this.groupBox5);
            this.groupSettings.Controls.Add(this.groupBox4);
            this.groupSettings.Controls.Add(this.label1);
            this.groupSettings.Controls.Add(this.selectRotate);
            this.groupSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupSettings.Enabled = false;
            this.groupSettings.Location = new System.Drawing.Point(664, 0);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(462, 696);
            this.groupSettings.TabIndex = 3;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Настройки";
            // 
            // isFilter
            // 
            this.isFilter.AutoSize = true;
            this.isFilter.Location = new System.Drawing.Point(312, 77);
            this.isFilter.Name = "isFilter";
            this.isFilter.Size = new System.Drawing.Size(90, 17);
            this.isFilter.TabIndex = 13;
            this.isFilter.Text = "Фильтрация";
            this.isFilter.UseVisualStyleBackColor = true;
            // 
            // isBinary
            // 
            this.isBinary.AutoSize = true;
            this.isBinary.Location = new System.Drawing.Point(191, 77);
            this.isBinary.Name = "isBinary";
            this.isBinary.Size = new System.Drawing.Size(93, 17);
            this.isBinary.TabIndex = 12;
            this.isBinary.Text = "Бинаризация";
            this.isBinary.UseVisualStyleBackColor = true;
            // 
            // gradationGrey
            // 
            this.gradationGrey.AutoSize = true;
            this.gradationGrey.Location = new System.Drawing.Point(191, 23);
            this.gradationGrey.Name = "gradationGrey";
            this.gradationGrey.Size = new System.Drawing.Size(112, 17);
            this.gradationGrey.TabIndex = 11;
            this.gradationGrey.Text = "Градация серого";
            this.gradationGrey.UseVisualStyleBackColor = true;
            // 
            // applySetting
            // 
            this.applySetting.Location = new System.Drawing.Point(143, 604);
            this.applySetting.Name = "applySetting";
            this.applySetting.Size = new System.Drawing.Size(180, 23);
            this.applySetting.TabIndex = 10;
            this.applySetting.Text = "Применить настройки";
            this.applySetting.UseVisualStyleBackColor = true;
            this.applySetting.Click += new System.EventHandler(this.ApplySetting_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.trackBlurH);
            this.groupBox7.Controls.Add(this.trackBlurV);
            this.groupBox7.Location = new System.Drawing.Point(9, 108);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(447, 123);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Размытие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "По горизонтали";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "По вертикали";
            // 
            // trackBlurH
            // 
            this.trackBlurH.Location = new System.Drawing.Point(152, 70);
            this.trackBlurH.Maximum = 20;
            this.trackBlurH.Minimum = 1;
            this.trackBlurH.Name = "trackBlurH";
            this.trackBlurH.Size = new System.Drawing.Size(274, 45);
            this.trackBlurH.TabIndex = 1;
            this.trackBlurH.Value = 1;
            // 
            // trackBlurV
            // 
            this.trackBlurV.Location = new System.Drawing.Point(152, 19);
            this.trackBlurV.Maximum = 20;
            this.trackBlurV.Minimum = 1;
            this.trackBlurV.Name = "trackBlurV";
            this.trackBlurV.Size = new System.Drawing.Size(274, 45);
            this.trackBlurV.TabIndex = 0;
            this.trackBlurV.Value = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.trackGausian);
            this.groupBox8.Location = new System.Drawing.Point(9, 237);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(447, 57);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Размытие по гаусу";
            // 
            // trackGausian
            // 
            this.trackGausian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackGausian.Location = new System.Drawing.Point(3, 16);
            this.trackGausian.Maximum = 31;
            this.trackGausian.Minimum = 1;
            this.trackGausian.Name = "trackGausian";
            this.trackGausian.Size = new System.Drawing.Size(441, 38);
            this.trackGausian.TabIndex = 0;
            this.trackGausian.TickFrequency = 2;
            this.trackGausian.Value = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.trackMedian);
            this.groupBox9.Location = new System.Drawing.Point(9, 300);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(447, 57);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Медианная фильтрация";
            // 
            // trackMedian
            // 
            this.trackMedian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackMedian.Location = new System.Drawing.Point(3, 16);
            this.trackMedian.Maximum = 31;
            this.trackMedian.Minimum = 1;
            this.trackMedian.Name = "trackMedian";
            this.trackMedian.Size = new System.Drawing.Size(441, 38);
            this.trackMedian.TabIndex = 0;
            this.trackMedian.TickFrequency = 2;
            this.trackMedian.Value = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.orderY);
            this.groupBox10.Controls.Add(this.orderX);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.trackSizeSobel);
            this.groupBox10.Location = new System.Drawing.Point(9, 363);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(235, 155);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Фильтрация собеля";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Размер:";
            // 
            // orderY
            // 
            this.orderY.Location = new System.Drawing.Point(146, 61);
            this.orderY.Name = "orderY";
            this.orderY.Size = new System.Drawing.Size(64, 20);
            this.orderY.TabIndex = 3;
            // 
            // orderX
            // 
            this.orderX.Location = new System.Drawing.Point(146, 28);
            this.orderX.Name = "orderX";
            this.orderX.Size = new System.Drawing.Size(64, 20);
            this.orderX.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Порядок производной y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Порядок производной x:";
            // 
            // trackSizeSobel
            // 
            this.trackSizeSobel.Location = new System.Drawing.Point(64, 104);
            this.trackSizeSobel.Maximum = 31;
            this.trackSizeSobel.Minimum = 1;
            this.trackSizeSobel.Name = "trackSizeSobel";
            this.trackSizeSobel.Size = new System.Drawing.Size(167, 45);
            this.trackSizeSobel.SmallChange = 2;
            this.trackSizeSobel.TabIndex = 0;
            this.trackSizeSobel.TickFrequency = 2;
            this.trackSizeSobel.Value = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.spaceSigma);
            this.groupBox6.Controls.Add(this.colorSigma);
            this.groupBox6.Controls.Add(this.kernelSize);
            this.groupBox6.Location = new System.Drawing.Point(250, 363);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 155);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Двухсторонняя фильтрация";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Расстояние сигмы:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Цвет сигмы:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Размер:";
            // 
            // spaceSigma
            // 
            this.spaceSigma.Location = new System.Drawing.Point(124, 104);
            this.spaceSigma.Name = "spaceSigma";
            this.spaceSigma.Size = new System.Drawing.Size(61, 20);
            this.spaceSigma.TabIndex = 0;
            // 
            // colorSigma
            // 
            this.colorSigma.Location = new System.Drawing.Point(124, 78);
            this.colorSigma.Name = "colorSigma";
            this.colorSigma.Size = new System.Drawing.Size(61, 20);
            this.colorSigma.TabIndex = 0;
            // 
            // kernelSize
            // 
            this.kernelSize.Location = new System.Drawing.Point(124, 52);
            this.kernelSize.Name = "kernelSize";
            this.kernelSize.Size = new System.Drawing.Size(61, 20);
            this.kernelSize.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackRotate);
            this.groupBox5.Location = new System.Drawing.Point(9, 524);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 59);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поворот";
            // 
            // trackRotate
            // 
            this.trackRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackRotate.Location = new System.Drawing.Point(3, 16);
            this.trackRotate.Maximum = 180;
            this.trackRotate.Minimum = -180;
            this.trackRotate.Name = "trackRotate";
            this.trackRotate.Size = new System.Drawing.Size(444, 40);
            this.trackRotate.TabIndex = 0;
            this.trackRotate.TickFrequency = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.heightImage);
            this.groupBox4.Controls.Add(this.widthImage);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 83);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размер изображения";
            // 
            // heightImage
            // 
            this.heightImage.Location = new System.Drawing.Point(80, 55);
            this.heightImage.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.heightImage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightImage.Name = "heightImage";
            this.heightImage.Size = new System.Drawing.Size(74, 20);
            this.heightImage.TabIndex = 3;
            this.heightImage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // widthImage
            // 
            this.widthImage.Location = new System.Drawing.Point(80, 30);
            this.widthImage.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.widthImage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthImage.Name = "widthImage";
            this.widthImage.Size = new System.Drawing.Size(74, 20);
            this.widthImage.TabIndex = 2;
            this.widthImage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ширина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отразить по:";
            // 
            // selectRotate
            // 
            this.selectRotate.FormattingEnabled = true;
            this.selectRotate.Items.AddRange(new object[] {
            "Нет",
            "Горизонтали",
            "Вертикали"});
            this.selectRotate.Location = new System.Drawing.Point(267, 46);
            this.selectRotate.Name = "selectRotate";
            this.selectRotate.Size = new System.Drawing.Size(135, 21);
            this.selectRotate.TabIndex = 2;
            this.selectRotate.Text = "Нет";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 696);
            this.panel1.TabIndex = 4;
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Image files| *.png; *.jpg; *.jpeg";
            // 
            // numKsize
            // 
            this.numKsize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKsize.Location = new System.Drawing.Point(408, 76);
            this.numKsize.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numKsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKsize.Name = "numKsize";
            this.numKsize.Size = new System.Drawing.Size(41, 20);
            this.numKsize.TabIndex = 14;
            this.numKsize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupSettings);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с изображением";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlurH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlurV)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGausian)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMedian)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeSobel)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.TextBox pathImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TrackBar trackGausian;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TrackBar trackMedian;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown orderY;
        private System.Windows.Forms.NumericUpDown orderX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackSizeSobel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackRotate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown heightImage;
        private System.Windows.Forms.NumericUpDown widthImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectRotate;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spaceSigma;
        private System.Windows.Forms.NumericUpDown colorSigma;
        private System.Windows.Forms.NumericUpDown kernelSize;
        private System.Windows.Forms.Button applySetting;
        private System.Windows.Forms.CheckBox gradationGrey;
        private System.Windows.Forms.CheckBox isFilter;
        private System.Windows.Forms.CheckBox isBinary;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBlurH;
        private System.Windows.Forms.TrackBar trackBlurV;
        private System.Windows.Forms.NumericUpDown numKsize;
    }
}

