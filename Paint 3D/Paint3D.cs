using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using SharpGLTexturesSample._3D_Objects;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;

namespace Paint_3D
{
    public partial class Paint3D : Form
    {
        // Values of transformation textboxes
        float currentTranslationValueX = 0, currentTranslationValueY = 0, currentTranslationValueZ = 0;
        float currentRotationValueX = 0, currentRotationValueY = 0, currentRotationValueZ = 0;
        float currentScalizationValueX = 1, currentScalizationValueY = 1, currentScalizationValueZ = 1;

        List<Object_t> objectsRendered; // List contains rendered objects
        int objectID;   // ID number for each object
        int selectedItem;   // ID of selected object
        Color currentColor; // User color picked up
        Scene scene;    // Scene variable 
        Camera camera;  // Camera variable 
        Texture currentTexture; // Texture variable 
        String texturePath; // Texture file name path

        public Paint3D()
        {
            // Initialization
            InitializeComponent();
            OpenGL gl = new OpenGL();
            objectsRendered = new List<Object_t>();
            objectID = -1;
            selectedItem = -1;
            currentColor = Color.White;
            scene = new Scene();

            /*****************************************************************************************/

            // The texture identifier.
            currentTexture = new Texture();
            texturePath = "";

            /*****************************************************************************************/

            // Set camera
            // Camera Position set up
            float[] CamPos = new float[3];
            CamPos[0] = -5f; CamPos[1] = 10f; CamPos[2] = 6f;
            float[] CamTar = new float[3];
            CamTar[0] = 0f; CamTar[1] = 0f; CamTar[2] = 0f;
            float[] CamUp = new float[3];
            CamUp[0] = 0f; CamUp[1] = 1f; CamUp[2] = 0f;
            camera = new Camera(CamPos, CamTar, CamUp);

            /*****************************************************************************************/

            // Disable transformation textboxes
            // Translation textbox
            translate_X.Enabled = false;
            translate_Y.Enabled = false;
            translate_Z.Enabled = false;
            // Rotation textbox
            rotate_X.Enabled = false;
            rotate_Y.Enabled = false;
            rotate_Z.Enabled = false;
            // Scalization textbox
            scale_X.Enabled = false;
            scale_Y.Enabled = false;
            scale_Z.Enabled = false;
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;

            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;

            //set ma tran viewport
            gl.Viewport(
                0, 0,
                openGLControl1.Width,
                openGLControl1.Height);

            //set ma tran phep chieu
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(60,
            openGLControl1.Width / openGLControl1.Height,
                1.0, 100.0);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl1.OpenGL;

            // Show scene catched by camera to on the screen
            camera.catch_Scene(gl);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //gl.LoadIdentity();

            // Display scene coordinate 
            scene.scene_display(gl);
            
            // Render objects in our Rendered_Objects List
            if (objectsRendered.Count > 0)
            {
                foreach (Object_t obj in objectsRendered)
                {
                    // If object is selected
                    if (obj.ID == selectedItem)
                    {
                        obj.IsChoose = true;
                        // Assigned user's picked up color to this object
                        obj.My_Color = currentColor;

                        // Assign transformation value from textboxes to this object
                        // Translation value
                        obj.Translate[0] = currentTranslationValueX;
                        obj.Translate[1] = currentTranslationValueY;
                        obj.Translate[2] = currentTranslationValueZ;
                        // Rotation value
                        obj.Rotate[0] = currentRotationValueX;
                        obj.Rotate[1] = currentRotationValueY;
                        obj.Rotate[2] = currentRotationValueZ;
                        // Scalization value
                        obj.Scale[0] = currentScalizationValueX;
                        obj.Scale[1] = currentScalizationValueY;
                        obj.Scale[2] = currentScalizationValueZ;
                    }

                    // Render object here
                    obj.show_Object(gl, 0);
                }
            }
        }

        private void create_cube_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            Object_t cube = new Cube("Cube " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(cube);   // Add object to our list
            object_list_box.Items.Add(cube.Name);

            if (objectsRendered.Count > 0)
            {
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void create_pyramid_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            Object_t pyramid = new Pyramid("Pyramid " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(pyramid);   // Add object to our list
            object_list_box.Items.Add(pyramid.Name);

            if (objectsRendered.Count > 0)
            {   
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void create_triangular_prism_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            Object_t tri = new Triangular_Prism("Triangular Prism " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(tri);   // Add object to our list
            object_list_box.Items.Add(tri.Name);

            if (objectsRendered.Count > 0)
            {
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (object_list_box.SelectedItem == null)
            {

                return;
            }
            translate_X.Enabled = true;
            translate_Y.Enabled = true;
            translate_Z.Enabled = true;

            rotate_X.Enabled = true;
            rotate_Y.Enabled = true;
            rotate_Z.Enabled = true;

            scale_X.Enabled = true;
            scale_Y.Enabled = true;
            scale_Z.Enabled = true;
            System.Diagnostics.Debug.WriteLine(object_list_box.SelectedItem.ToString());
            string temp_line = object_list_box.SelectedItem.ToString();
            char num = temp_line[temp_line.Length - 1];
            selectedItem = num - '0';

            if (objectsRendered.Count > 0)
            {
                foreach (Object_t obj in objectsRendered)
                {
                    if (obj.ID != selectedItem)
                    {
                        obj.IsChoose = false;
                    }
                    else
                    {
                        translate_X.Text = obj.Translate[0].ToString();
                        translate_Y.Text = obj.Translate[1].ToString();
                        translate_Z.Text = obj.Translate[2].ToString();

                        rotate_X.Text = obj.Rotate[0].ToString();
                        rotate_Y.Text = obj.Rotate[1].ToString();
                        rotate_Z.Text = obj.Rotate[2].ToString();

                        scale_X.Text = obj.Scale[0].ToString();
                        scale_Y.Text = obj.Scale[1].ToString();
                        scale_Z.Text = obj.Scale[2].ToString();
                    }
                }
            }
        }

        private void color_dialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                currentColor = colorDialog1.Color;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e){}

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void openGLControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                camera.position[1] += 0.1f;
            }
            if (e.KeyChar == 's')
            {
                camera.position[1] -= 0.1f;
            }
            if (e.KeyChar == 'a')
            {
                camera.position[0] -= 0.1f;
            }
            if (e.KeyChar == 'd')
            {
                camera.position[0] += 0.1f;
            }
            if (e.KeyChar == 'z')
            {
                camera.position[2] -= 0.1f;
            }
            if (e.KeyChar == 'x')
            {
                camera.position[2] += 0.1f;
            }
        }

        private void translate_X_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(translate_X.Text, out userVal))
            {
                currentTranslationValueX = userVal;
            }

        }

        private void translate_Y_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(translate_Y.Text, out userVal))
            {
                currentTranslationValueY = userVal;
            }

        }

        private void translate_Z_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(translate_Z.Text, out userVal))
            {
                currentTranslationValueZ = userVal;
            }

        }

        private void buttom_loadTexture_Click(object sender, EventArgs e)
        {
            //  Show a file open dialog.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(selectedItem > -1)
                {
                    // Updata texture file path for selected object
                    objectsRendered[selectedItem].TexturePath = (openFileDialog1.FileName);
                    //  Redraw.
                    openGLControl1.Invalidate();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void rotate_X_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(rotate_X.Text, out userVal))
            {
                currentRotationValueX = userVal;
            }

        }

        private void rotate_Y_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(rotate_Y.Text, out userVal))
            {
                currentRotationValueY = userVal;
            }

        }

        private void rotate_Z_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(rotate_Z.Text, out userVal))
            {
                currentRotationValueZ = userVal;
            }

        }

        private void scale_X_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(scale_X.Text, out userVal))
            {
                currentScalizationValueX = userVal;
            }

        }

        private void scale_Y_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(scale_Y.Text, out userVal))
            {
                currentScalizationValueY = userVal;
            }

        }

        private void scale_Z_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(scale_Z.Text, out userVal))
            {
                currentScalizationValueZ = userVal;
            }
        }
    }
}
