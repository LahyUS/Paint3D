
namespace Paint_3D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint3D));
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.object_list_box = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.color_dialog = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scale_Z = new System.Windows.Forms.TextBox();
            this.scale_Y = new System.Windows.Forms.TextBox();
            this.scale_X = new System.Windows.Forms.TextBox();
            this.rotate_Z = new System.Windows.Forms.TextBox();
            this.translate_Z = new System.Windows.Forms.TextBox();
            this.rotate_Y = new System.Windows.Forms.TextBox();
            this.translate_Y = new System.Windows.Forms.TextBox();
            this.rotate_X = new System.Windows.Forms.TextBox();
            this.translate_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.object_groupBox1 = new System.Windows.Forms.GroupBox();
            this.create_pyramid = new System.Windows.Forms.Button();
            this.create_triangular_prism = new System.Windows.Forms.Button();
            this.create_cube = new System.Windows.Forms.Button();
            this.object_list = new System.Windows.Forms.Label();
            this.buttom_loadTexture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.Transformation.SuspendLayout();
            this.object_groupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openGLControl1.BackgroundImage = global::Paint_3D.Properties.Resources.background;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(315, -1);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(1024, 960);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
            this.openGLControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.openGLControl1_KeyPress);
            // 
            // object_list_box
            // 
            this.object_list_box.BackColor = System.Drawing.Color.LightSteelBlue;
            this.object_list_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.object_list_box.FormattingEnabled = true;
            this.object_list_box.Location = new System.Drawing.Point(16, 26);
            this.object_list_box.Name = "object_list_box";
            this.object_list_box.Size = new System.Drawing.Size(284, 186);
            this.object_list_box.TabIndex = 4;
            this.object_list_box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // color_dialog
            // 
            this.color_dialog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.color_dialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_dialog.Image = global::Paint_3D.Properties.Resources.color_button;
            this.color_dialog.Location = new System.Drawing.Point(9, 30);
            this.color_dialog.Name = "color_dialog";
            this.color_dialog.Size = new System.Drawing.Size(120, 23);
            this.color_dialog.TabIndex = 6;
            this.color_dialog.Text = "Color";
            this.color_dialog.UseVisualStyleBackColor = false;
            this.color_dialog.Click += new System.EventHandler(this.color_dialog_Click);
            // 
            // Transformation
            // 
            this.Transformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Transformation.Controls.Add(this.label4);
            this.Transformation.Controls.Add(this.label5);
            this.Transformation.Controls.Add(this.label11);
            this.Transformation.Controls.Add(this.label10);
            this.Transformation.Controls.Add(this.label7);
            this.Transformation.Controls.Add(this.label9);
            this.Transformation.Controls.Add(this.label8);
            this.Transformation.Controls.Add(this.label6);
            this.Transformation.Controls.Add(this.label1);
            this.Transformation.Controls.Add(this.scale_Z);
            this.Transformation.Controls.Add(this.scale_Y);
            this.Transformation.Controls.Add(this.scale_X);
            this.Transformation.Controls.Add(this.rotate_Z);
            this.Transformation.Controls.Add(this.translate_Z);
            this.Transformation.Controls.Add(this.rotate_Y);
            this.Transformation.Controls.Add(this.translate_Y);
            this.Transformation.Controls.Add(this.rotate_X);
            this.Transformation.Controls.Add(this.translate_X);
            this.Transformation.Controls.Add(this.label3);
            this.Transformation.Controls.Add(this.label2);
            this.Transformation.Controls.Add(this.Position);
            this.Transformation.Location = new System.Drawing.Point(16, 398);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(293, 110);
            this.Transformation.TabIndex = 7;
            this.Transformation.TabStop = false;
            this.Transformation.Text = "Transformation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // scale_Z
            // 
            this.scale_Z.Location = new System.Drawing.Point(231, 75);
            this.scale_Z.Name = "scale_Z";
            this.scale_Z.Size = new System.Drawing.Size(53, 20);
            this.scale_Z.TabIndex = 1;
            this.scale_Z.TextChanged += new System.EventHandler(this.scale_Z_TextChanged);
            // 
            // scale_Y
            // 
            this.scale_Y.Location = new System.Drawing.Point(158, 75);
            this.scale_Y.Name = "scale_Y";
            this.scale_Y.Size = new System.Drawing.Size(53, 20);
            this.scale_Y.TabIndex = 1;
            this.scale_Y.TextChanged += new System.EventHandler(this.scale_Y_TextChanged);
            // 
            // scale_X
            // 
            this.scale_X.Location = new System.Drawing.Point(79, 75);
            this.scale_X.Name = "scale_X";
            this.scale_X.Size = new System.Drawing.Size(53, 20);
            this.scale_X.TabIndex = 1;
            this.scale_X.TextChanged += new System.EventHandler(this.scale_X_TextChanged);
            // 
            // rotate_Z
            // 
            this.rotate_Z.Location = new System.Drawing.Point(231, 47);
            this.rotate_Z.Name = "rotate_Z";
            this.rotate_Z.Size = new System.Drawing.Size(53, 20);
            this.rotate_Z.TabIndex = 1;
            this.rotate_Z.TextChanged += new System.EventHandler(this.rotate_Z_TextChanged);
            // 
            // translate_Z
            // 
            this.translate_Z.Location = new System.Drawing.Point(231, 18);
            this.translate_Z.Name = "translate_Z";
            this.translate_Z.Size = new System.Drawing.Size(53, 20);
            this.translate_Z.TabIndex = 1;
            this.translate_Z.TextChanged += new System.EventHandler(this.translate_Z_TextChanged);
            // 
            // rotate_Y
            // 
            this.rotate_Y.Location = new System.Drawing.Point(158, 47);
            this.rotate_Y.Name = "rotate_Y";
            this.rotate_Y.Size = new System.Drawing.Size(53, 20);
            this.rotate_Y.TabIndex = 1;
            this.rotate_Y.TextChanged += new System.EventHandler(this.rotate_Y_TextChanged);
            // 
            // translate_Y
            // 
            this.translate_Y.Location = new System.Drawing.Point(158, 18);
            this.translate_Y.Name = "translate_Y";
            this.translate_Y.Size = new System.Drawing.Size(53, 20);
            this.translate_Y.TabIndex = 1;
            this.translate_Y.TextChanged += new System.EventHandler(this.translate_Y_TextChanged);
            // 
            // rotate_X
            // 
            this.rotate_X.Location = new System.Drawing.Point(79, 47);
            this.rotate_X.Name = "rotate_X";
            this.rotate_X.Size = new System.Drawing.Size(53, 20);
            this.rotate_X.TabIndex = 1;
            this.rotate_X.TextChanged += new System.EventHandler(this.rotate_X_TextChanged);
            // 
            // translate_X
            // 
            this.translate_X.BackColor = System.Drawing.Color.Beige;
            this.translate_X.Location = new System.Drawing.Point(77, 18);
            this.translate_X.Name = "translate_X";
            this.translate_X.Size = new System.Drawing.Size(53, 20);
            this.translate_X.TabIndex = 1;
            this.translate_X.TextChanged += new System.EventHandler(this.translate_X_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rotate";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(7, 20);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(51, 13);
            this.Position.TabIndex = 0;
            this.Position.Text = "Translate";
            // 
            // object_groupBox1
            // 
            this.object_groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.object_groupBox1.Controls.Add(this.create_pyramid);
            this.object_groupBox1.Controls.Add(this.create_triangular_prism);
            this.object_groupBox1.Controls.Add(this.create_cube);
            this.object_groupBox1.Location = new System.Drawing.Point(16, 227);
            this.object_groupBox1.Name = "object_groupBox1";
            this.object_groupBox1.Size = new System.Drawing.Size(152, 154);
            this.object_groupBox1.TabIndex = 8;
            this.object_groupBox1.TabStop = false;
            this.object_groupBox1.Text = "Object";
            // 
            // create_pyramid
            // 
            this.create_pyramid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.create_pyramid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_pyramid.Location = new System.Drawing.Point(6, 74);
            this.create_pyramid.Name = "create_pyramid";
            this.create_pyramid.Size = new System.Drawing.Size(140, 23);
            this.create_pyramid.TabIndex = 6;
            this.create_pyramid.Text = "Pyramid";
            this.create_pyramid.UseVisualStyleBackColor = false;
            this.create_pyramid.Click += new System.EventHandler(this.create_pyramid_Click);
            // 
            // create_triangular_prism
            // 
            this.create_triangular_prism.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.create_triangular_prism.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_triangular_prism.Location = new System.Drawing.Point(6, 119);
            this.create_triangular_prism.Name = "create_triangular_prism";
            this.create_triangular_prism.Size = new System.Drawing.Size(140, 23);
            this.create_triangular_prism.TabIndex = 5;
            this.create_triangular_prism.Text = "Triangular Prism";
            this.create_triangular_prism.UseVisualStyleBackColor = false;
            this.create_triangular_prism.Click += new System.EventHandler(this.create_triangular_prism_Click);
            // 
            // create_cube
            // 
            this.create_cube.BackColor = System.Drawing.Color.DarkGray;
            this.create_cube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_cube.Location = new System.Drawing.Point(6, 30);
            this.create_cube.Name = "create_cube";
            this.create_cube.Size = new System.Drawing.Size(140, 23);
            this.create_cube.TabIndex = 4;
            this.create_cube.Text = "Cube";
            this.create_cube.UseVisualStyleBackColor = false;
            this.create_cube.Click += new System.EventHandler(this.create_cube_Click);
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
            // buttom_loadTexture
            // 
            this.buttom_loadTexture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttom_loadTexture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttom_loadTexture.ForeColor = System.Drawing.Color.White;
            this.buttom_loadTexture.Image = global::Paint_3D.Properties.Resources.Crate;
            this.buttom_loadTexture.Location = new System.Drawing.Point(9, 74);
            this.buttom_loadTexture.Name = "buttom_loadTexture";
            this.buttom_loadTexture.Size = new System.Drawing.Size(120, 23);
            this.buttom_loadTexture.TabIndex = 10;
            this.buttom_loadTexture.Text = "Load Texture";
            this.buttom_loadTexture.UseVisualStyleBackColor = false;
            this.buttom_loadTexture.Click += new System.EventHandler(this.buttom_loadTexture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.color_dialog);
            this.groupBox1.Controls.Add(this.buttom_loadTexture);
            this.groupBox1.Location = new System.Drawing.Point(174, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 154);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decoration";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Paint3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paint_3D.Properties.Resources.dark_bg;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.object_list);
            this.Controls.Add(this.object_groupBox1);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.object_list_box);
            this.Controls.Add(this.openGLControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint3D";
            this.Text = "Paint3D";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.Transformation.ResumeLayout(false);
            this.Transformation.PerformLayout();
            this.object_groupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ListBox object_list_box;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color_dialog;
        private System.Windows.Forms.GroupBox Transformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox rotate_X;
        private System.Windows.Forms.TextBox translate_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scale_Z;
        private System.Windows.Forms.TextBox scale_Y;
        private System.Windows.Forms.TextBox scale_X;
        private System.Windows.Forms.TextBox rotate_Z;
        private System.Windows.Forms.TextBox translate_Z;
        private System.Windows.Forms.TextBox rotate_Y;
        private System.Windows.Forms.TextBox translate_Y;
        private System.Windows.Forms.GroupBox object_groupBox1;
        private System.Windows.Forms.Button create_pyramid;
        private System.Windows.Forms.Button create_triangular_prism;
        private System.Windows.Forms.Button create_cube;
        private System.Windows.Forms.Label object_list;
        private System.Windows.Forms.Button buttom_loadTexture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

