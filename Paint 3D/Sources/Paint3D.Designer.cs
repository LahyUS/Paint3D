
namespace Paint3D
{
    partial class Paint3D
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.colorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.GroupBox();
            this.lbXRotate = new System.Windows.Forms.Label();
            this.lbXScale = new System.Windows.Forms.Label();
            this.lbZScale = new System.Windows.Forms.Label();
            this.lbZRotate = new System.Windows.Forms.Label();
            this.lbZTrans = new System.Windows.Forms.Label();
            this.lbYScale = new System.Windows.Forms.Label();
            this.lbYRotate = new System.Windows.Forms.Label();
            this.lbYTrans = new System.Windows.Forms.Label();
            this.lbXTrans = new System.Windows.Forms.Label();
            this.tbScaleZ = new System.Windows.Forms.TextBox();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.tbRotateZ = new System.Windows.Forms.TextBox();
            this.tbTranslateZ = new System.Windows.Forms.TextBox();
            this.tbRotateY = new System.Windows.Forms.TextBox();
            this.tbTranslateY = new System.Windows.Forms.TextBox();
            this.tbRotateX = new System.Windows.Forms.TextBox();
            this.tbTranslateX = new System.Windows.Forms.TextBox();
            this.lbScale = new System.Windows.Forms.Label();
            this.lbRotate = new System.Windows.Forms.Label();
            this.lbTrans = new System.Windows.Forms.Label();
            this.gbObjects = new System.Windows.Forms.GroupBox();
            this.btnCreatePyramid = new System.Windows.Forms.Button();
            this.btnCreateTriangularPrism = new System.Windows.Forms.Button();
            this.btnCreateCube = new System.Windows.Forms.Button();
            this.object_list = new System.Windows.Forms.Label();
            this.btnLoadTexture = new System.Windows.Forms.Button();
            this.gbDecoration = new System.Windows.Forms.GroupBox();
            this.texturePickerDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.Transformation.SuspendLayout();
            this.gbObjects.SuspendLayout();
            this.gbDecoration.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(315, -1);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1024, 960);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl1_Resized);
            this.openGLControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.openGLControl1_KeyPress);
            // 
            // objectListBox
            // 
            this.objectListBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.objectListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.Location = new System.Drawing.Point(16, 26);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(284, 186);
            this.objectListBox.TabIndex = 4;
            this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.objectListBox_SelectedIndexChanged);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorPicker.Location = new System.Drawing.Point(9, 30);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(120, 23);
            this.btnColorPicker.TabIndex = 6;
            this.btnColorPicker.Text = "Color";
            this.btnColorPicker.UseVisualStyleBackColor = false;
            this.btnColorPicker.Click += new System.EventHandler(this.colorPickerDialog_Click);
            // 
            // Transformation
            // 
            this.Transformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Transformation.Controls.Add(this.lbXRotate);
            this.Transformation.Controls.Add(this.lbXScale);
            this.Transformation.Controls.Add(this.lbZScale);
            this.Transformation.Controls.Add(this.lbZRotate);
            this.Transformation.Controls.Add(this.lbZTrans);
            this.Transformation.Controls.Add(this.lbYScale);
            this.Transformation.Controls.Add(this.lbYRotate);
            this.Transformation.Controls.Add(this.lbYTrans);
            this.Transformation.Controls.Add(this.lbXTrans);
            this.Transformation.Controls.Add(this.tbScaleZ);
            this.Transformation.Controls.Add(this.tbScaleY);
            this.Transformation.Controls.Add(this.tbScaleX);
            this.Transformation.Controls.Add(this.tbRotateZ);
            this.Transformation.Controls.Add(this.tbTranslateZ);
            this.Transformation.Controls.Add(this.tbRotateY);
            this.Transformation.Controls.Add(this.tbTranslateY);
            this.Transformation.Controls.Add(this.tbRotateX);
            this.Transformation.Controls.Add(this.tbTranslateX);
            this.Transformation.Controls.Add(this.lbScale);
            this.Transformation.Controls.Add(this.lbRotate);
            this.Transformation.Controls.Add(this.lbTrans);
            this.Transformation.Location = new System.Drawing.Point(16, 398);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(293, 110);
            this.Transformation.TabIndex = 7;
            this.Transformation.TabStop = false;
            this.Transformation.Text = "Transformation";
            // 
            // lbXRotate
            // 
            this.lbXRotate.AutoSize = true;
            this.lbXRotate.Location = new System.Drawing.Point(57, 51);
            this.lbXRotate.Name = "lbXRotate";
            this.lbXRotate.Size = new System.Drawing.Size(14, 13);
            this.lbXRotate.TabIndex = 2;
            this.lbXRotate.Text = "X";
            // 
            // lbXScale
            // 
            this.lbXScale.AutoSize = true;
            this.lbXScale.Location = new System.Drawing.Point(57, 78);
            this.lbXScale.Name = "lbXScale";
            this.lbXScale.Size = new System.Drawing.Size(14, 13);
            this.lbXScale.TabIndex = 2;
            this.lbXScale.Text = "X";
            // 
            // lbZScale
            // 
            this.lbZScale.AutoSize = true;
            this.lbZScale.Location = new System.Drawing.Point(217, 78);
            this.lbZScale.Name = "lbZScale";
            this.lbZScale.Size = new System.Drawing.Size(14, 13);
            this.lbZScale.TabIndex = 2;
            this.lbZScale.Text = "Z";
            // 
            // lbZRotate
            // 
            this.lbZRotate.AutoSize = true;
            this.lbZRotate.Location = new System.Drawing.Point(217, 50);
            this.lbZRotate.Name = "lbZRotate";
            this.lbZRotate.Size = new System.Drawing.Size(14, 13);
            this.lbZRotate.TabIndex = 2;
            this.lbZRotate.Text = "Z";
            // 
            // lbZTrans
            // 
            this.lbZTrans.AutoSize = true;
            this.lbZTrans.Location = new System.Drawing.Point(217, 21);
            this.lbZTrans.Name = "lbZTrans";
            this.lbZTrans.Size = new System.Drawing.Size(14, 13);
            this.lbZTrans.TabIndex = 2;
            this.lbZTrans.Text = "Z";
            // 
            // lbYScale
            // 
            this.lbYScale.AutoSize = true;
            this.lbYScale.Location = new System.Drawing.Point(138, 78);
            this.lbYScale.Name = "lbYScale";
            this.lbYScale.Size = new System.Drawing.Size(14, 13);
            this.lbYScale.TabIndex = 2;
            this.lbYScale.Text = "Y";
            // 
            // lbYRotate
            // 
            this.lbYRotate.AutoSize = true;
            this.lbYRotate.Location = new System.Drawing.Point(138, 50);
            this.lbYRotate.Name = "lbYRotate";
            this.lbYRotate.Size = new System.Drawing.Size(14, 13);
            this.lbYRotate.TabIndex = 2;
            this.lbYRotate.Text = "Y";
            // 
            // lbYTrans
            // 
            this.lbYTrans.AutoSize = true;
            this.lbYTrans.Location = new System.Drawing.Point(138, 21);
            this.lbYTrans.Name = "lbYTrans";
            this.lbYTrans.Size = new System.Drawing.Size(14, 13);
            this.lbYTrans.TabIndex = 2;
            this.lbYTrans.Text = "Y";
            // 
            // lbXTrans
            // 
            this.lbXTrans.AutoSize = true;
            this.lbXTrans.Location = new System.Drawing.Point(57, 21);
            this.lbXTrans.Name = "lbXTrans";
            this.lbXTrans.Size = new System.Drawing.Size(14, 13);
            this.lbXTrans.TabIndex = 2;
            this.lbXTrans.Text = "X";
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.Location = new System.Drawing.Point(231, 75);
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(53, 20);
            this.tbScaleZ.TabIndex = 1;
            this.tbScaleZ.TextChanged += new System.EventHandler(this.tbScaleZ_TextChanged);
            // 
            // tbScaleY
            // 
            this.tbScaleY.Location = new System.Drawing.Point(158, 75);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(53, 20);
            this.tbScaleY.TabIndex = 1;
            this.tbScaleY.TextChanged += new System.EventHandler(this.tbScaleY_TextChanged);
            // 
            // tbScaleX
            // 
            this.tbScaleX.Location = new System.Drawing.Point(79, 75);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(53, 20);
            this.tbScaleX.TabIndex = 1;
            this.tbScaleX.TextChanged += new System.EventHandler(this.tbScaleX_TextChanged);
            // 
            // tbRotateZ
            // 
            this.tbRotateZ.Location = new System.Drawing.Point(231, 47);
            this.tbRotateZ.Name = "tbRotateZ";
            this.tbRotateZ.Size = new System.Drawing.Size(53, 20);
            this.tbRotateZ.TabIndex = 1;
            this.tbRotateZ.TextChanged += new System.EventHandler(this.tbRotateZ_TextChanged);
            // 
            // tbTranslateZ
            // 
            this.tbTranslateZ.Location = new System.Drawing.Point(231, 18);
            this.tbTranslateZ.Name = "tbTranslateZ";
            this.tbTranslateZ.Size = new System.Drawing.Size(53, 20);
            this.tbTranslateZ.TabIndex = 1;
            this.tbTranslateZ.TextChanged += new System.EventHandler(this.tbTranslateZ_TextChanged);
            // 
            // tbRotateY
            // 
            this.tbRotateY.Location = new System.Drawing.Point(158, 47);
            this.tbRotateY.Name = "tbRotateY";
            this.tbRotateY.Size = new System.Drawing.Size(53, 20);
            this.tbRotateY.TabIndex = 1;
            this.tbRotateY.TextChanged += new System.EventHandler(this.tbRotateY_TextChanged);
            // 
            // tbTranslateY
            // 
            this.tbTranslateY.Location = new System.Drawing.Point(158, 18);
            this.tbTranslateY.Name = "tbTranslateY";
            this.tbTranslateY.Size = new System.Drawing.Size(53, 20);
            this.tbTranslateY.TabIndex = 1;
            this.tbTranslateY.TextChanged += new System.EventHandler(this.tbTranslateY_TextChanged);
            // 
            // tbRotateX
            // 
            this.tbRotateX.Location = new System.Drawing.Point(79, 47);
            this.tbRotateX.Name = "tbRotateX";
            this.tbRotateX.Size = new System.Drawing.Size(53, 20);
            this.tbRotateX.TabIndex = 1;
            this.tbRotateX.TextChanged += new System.EventHandler(this.tbRotateX_TextChanged);
            // 
            // tbTranslateX
            // 
            this.tbTranslateX.BackColor = System.Drawing.Color.Beige;
            this.tbTranslateX.Location = new System.Drawing.Point(77, 18);
            this.tbTranslateX.Name = "tbTranslateX";
            this.tbTranslateX.Size = new System.Drawing.Size(53, 20);
            this.tbTranslateX.TabIndex = 1;
            this.tbTranslateX.TextChanged += new System.EventHandler(this.tbTranslateX_TextChanged);
            // 
            // lbScale
            // 
            this.lbScale.AutoSize = true;
            this.lbScale.Location = new System.Drawing.Point(7, 77);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(34, 13);
            this.lbScale.TabIndex = 0;
            this.lbScale.Text = "Scale";
            // 
            // lbRotate
            // 
            this.lbRotate.AutoSize = true;
            this.lbRotate.Location = new System.Drawing.Point(7, 49);
            this.lbRotate.Name = "lbRotate";
            this.lbRotate.Size = new System.Drawing.Size(39, 13);
            this.lbRotate.TabIndex = 0;
            this.lbRotate.Text = "Rotate";
            // 
            // lbTrans
            // 
            this.lbTrans.AutoSize = true;
            this.lbTrans.Location = new System.Drawing.Point(7, 20);
            this.lbTrans.Name = "lbTrans";
            this.lbTrans.Size = new System.Drawing.Size(51, 13);
            this.lbTrans.TabIndex = 0;
            this.lbTrans.Text = "Translate";
            // 
            // gbObjects
            // 
            this.gbObjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbObjects.Controls.Add(this.btnCreatePyramid);
            this.gbObjects.Controls.Add(this.btnCreateTriangularPrism);
            this.gbObjects.Controls.Add(this.btnCreateCube);
            this.gbObjects.Location = new System.Drawing.Point(16, 227);
            this.gbObjects.Name = "gbObjects";
            this.gbObjects.Size = new System.Drawing.Size(152, 154);
            this.gbObjects.TabIndex = 8;
            this.gbObjects.TabStop = false;
            this.gbObjects.Text = "Object";
            // 
            // btnCreatePyramid
            // 
            this.btnCreatePyramid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreatePyramid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePyramid.Location = new System.Drawing.Point(6, 74);
            this.btnCreatePyramid.Name = "btnCreatePyramid";
            this.btnCreatePyramid.Size = new System.Drawing.Size(140, 23);
            this.btnCreatePyramid.TabIndex = 6;
            this.btnCreatePyramid.Text = "Pyramid";
            this.btnCreatePyramid.UseVisualStyleBackColor = false;
            this.btnCreatePyramid.Click += new System.EventHandler(this.btnCreatePyramid_Click);
            // 
            // btnCreateTriangularPrism
            // 
            this.btnCreateTriangularPrism.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateTriangularPrism.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTriangularPrism.Location = new System.Drawing.Point(6, 119);
            this.btnCreateTriangularPrism.Name = "btnCreateTriangularPrism";
            this.btnCreateTriangularPrism.Size = new System.Drawing.Size(140, 23);
            this.btnCreateTriangularPrism.TabIndex = 5;
            this.btnCreateTriangularPrism.Text = "Triangular Prism";
            this.btnCreateTriangularPrism.UseVisualStyleBackColor = false;
            this.btnCreateTriangularPrism.Click += new System.EventHandler(this.btnCreateTriangularPrism_Click);
            // 
            // btnCreateCube
            // 
            this.btnCreateCube.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateCube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCube.Location = new System.Drawing.Point(6, 30);
            this.btnCreateCube.Name = "btnCreateCube";
            this.btnCreateCube.Size = new System.Drawing.Size(140, 23);
            this.btnCreateCube.TabIndex = 4;
            this.btnCreateCube.Text = "Cube";
            this.btnCreateCube.UseVisualStyleBackColor = false;
            this.btnCreateCube.Click += new System.EventHandler(this.btnCreateCube_Click);
            // 
            // object_list
            // 
            this.object_list.AutoSize = true;
            this.object_list.Location = new System.Drawing.Point(17, 10);
            this.object_list.Name = "object_list";
            this.object_list.Size = new System.Drawing.Size(57, 13);
            this.object_list.TabIndex = 9;
            this.object_list.Text = "Object List";
            // 
            // btnLoadTexture
            // 
            this.btnLoadTexture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoadTexture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTexture.ForeColor = System.Drawing.Color.White;
            this.btnLoadTexture.Location = new System.Drawing.Point(9, 74);
            this.btnLoadTexture.Name = "btnLoadTexture";
            this.btnLoadTexture.Size = new System.Drawing.Size(120, 23);
            this.btnLoadTexture.TabIndex = 10;
            this.btnLoadTexture.Text = "Load Texture";
            this.btnLoadTexture.UseVisualStyleBackColor = false;
            this.btnLoadTexture.Click += new System.EventHandler(this.btnLoadTexture_Click);
            // 
            // gbDecoration
            // 
            this.gbDecoration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDecoration.Controls.Add(this.btnColorPicker);
            this.gbDecoration.Controls.Add(this.btnLoadTexture);
            this.gbDecoration.Location = new System.Drawing.Point(174, 227);
            this.gbDecoration.Name = "gbDecoration";
            this.gbDecoration.Size = new System.Drawing.Size(135, 154);
            this.gbDecoration.TabIndex = 11;
            this.gbDecoration.TabStop = false;
            this.gbDecoration.Text = "Decoration";
            // 
            // texturePickerDialog
            // 
            this.texturePickerDialog.FileName = "Choose texture file";
            this.texturePickerDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Paint3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.gbDecoration);
            this.Controls.Add(this.object_list);
            this.Controls.Add(this.gbObjects);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.objectListBox);
            this.Controls.Add(this.openGLControl);
            this.Name = "Paint3D";
            this.Text = "Paint3D";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.Transformation.ResumeLayout(false);
            this.Transformation.PerformLayout();
            this.gbObjects.ResumeLayout(false);
            this.gbDecoration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ListBox objectListBox;
        private System.Windows.Forms.ColorDialog colorPickerDialog;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.GroupBox Transformation;
        private System.Windows.Forms.Label lbScale;
        private System.Windows.Forms.Label lbRotate;
        private System.Windows.Forms.Label lbTrans;
        private System.Windows.Forms.TextBox tbRotateX;
        private System.Windows.Forms.TextBox tbTranslateX;
        private System.Windows.Forms.Label lbXRotate;
        private System.Windows.Forms.Label lbXScale;
        private System.Windows.Forms.Label lbZScale;
        private System.Windows.Forms.Label lbZRotate;
        private System.Windows.Forms.Label lbZTrans;
        private System.Windows.Forms.Label lbYScale;
        private System.Windows.Forms.Label lbYRotate;
        private System.Windows.Forms.Label lbYTrans;
        private System.Windows.Forms.Label lbXTrans;
        private System.Windows.Forms.TextBox tbScaleZ;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.TextBox tbRotateZ;
        private System.Windows.Forms.TextBox tbTranslateZ;
        private System.Windows.Forms.TextBox tbRotateY;
        private System.Windows.Forms.TextBox tbTranslateY;
        private System.Windows.Forms.GroupBox gbObjects;
        private System.Windows.Forms.Button btnCreatePyramid;
        private System.Windows.Forms.Button btnCreateTriangularPrism;
        private System.Windows.Forms.Button btnCreateCube;
        private System.Windows.Forms.Label object_list;
        private System.Windows.Forms.Button btnLoadTexture;
        private System.Windows.Forms.GroupBox gbDecoration;
        private System.Windows.Forms.OpenFileDialog texturePickerDialog;
    }
}

