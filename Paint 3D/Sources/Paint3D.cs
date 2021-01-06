using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using Paint3D._3DObjects;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;

namespace Paint3D
{
    public partial class Paint3D : Form
    {
        // Values of transformation textboxes
        float currentTranslationValueX = 0, currentTranslationValueY = 0, currentTranslationValueZ = 0;
        float currentRotationValueX = 0, currentRotationValueY = 0, currentRotationValueZ = 0;
        float currentScalizationValueX = 1, currentScalizationValueY = 1, currentScalizationValueZ = 1;

        List<global::Paint3D._3DObjects.Object> objectsRendered; // List contains rendered objects
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
            objectsRendered = new List<global::Paint3D._3DObjects.Object>();
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
            tbTranslateX.Enabled = false;
            tbTranslateY.Enabled = false;
            tbTranslateZ.Enabled = false;
            // Rotation textbox
            tbRotateX.Enabled = false;
            tbRotateY.Enabled = false;
            tbRotateZ.Enabled = false;
            // Scalization textbox
            tbScaleX.Enabled = false;
            tbScaleY.Enabled = false;
            tbScaleZ.Enabled = false;
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            //set ma tran viewport
            gl.Viewport(
                0, 0,
                openGLControl.Width,
                openGLControl.Height);

            //set ma tran phep chieu
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(60,
            openGLControl.Width / openGLControl.Height,
                1.0, 100.0);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;

            // Show scene catched by camera to on the screen
            camera.catch_Scene(gl);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //gl.LoadIdentity();

            // Display scene coordinate 
            scene.sceneDisplay(gl);
            
            // Render objects in our Rendered_Objects List
            if (objectsRendered.Count > 0)
            {
                foreach (global::Paint3D._3DObjects.Object obj in objectsRendered)
                {
                    // If object is selected
                    if (obj.ID == selectedItem)
                    {
                        obj.IsChoose = true;
                        // Assigned user's picked up color to this object
                        obj.CurrentColor = currentColor;

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
                    obj.showObject(gl, 0);
                }
            }
        }

        private void btnCreateCube_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            global::Paint3D._3DObjects.Object cube = new Cube("Cube " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(cube);   // Add object to our list
            objectListBox.Items.Add(cube.Name);

            if (objectsRendered.Count > 0)
            {
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void btnCreatePyramid_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            global::Paint3D._3DObjects.Object pyramid = new Pyramid("Pyramid " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(pyramid);   // Add object to our list
            objectListBox.Items.Add(pyramid.Name);

            if (objectsRendered.Count > 0)
            {   
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void btnCreateTriangularPrism_Click(object sender, EventArgs e)
        {
            objectID++; // Updata ID
            global::Paint3D._3DObjects.Object tri = new TriangularPrism("Triangular Prism " + objectID, objectID, currentColor, texturePath);
            objectsRendered.Add(tri);   // Add object to our list
            objectListBox.Items.Add(tri.Name);

            if (objectsRendered.Count > 0)
            {
                // Set other object to be not choosen
                for (int i = 0; i < objectsRendered.Count - 1; i++)
                    objectsRendered[i].IsChoose = false;
            }
        }

        private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (objectListBox.SelectedItem == null)
            {

                return;
            }
            tbTranslateX.Enabled = true;
            tbTranslateY.Enabled = true;
            tbTranslateZ.Enabled = true;

            tbRotateX.Enabled = true;
            tbRotateY.Enabled = true;
            tbRotateZ.Enabled = true;

            tbScaleX.Enabled = true;
            tbScaleY.Enabled = true;
            tbScaleZ.Enabled = true;
            System.Diagnostics.Debug.WriteLine(objectListBox.SelectedItem.ToString());
            string temp_line = objectListBox.SelectedItem.ToString();
            char num = temp_line[temp_line.Length - 1];
            selectedItem = num - '0';

            if (objectsRendered.Count > 0)
            {
                foreach (global::Paint3D._3DObjects.Object obj in objectsRendered)
                {
                    if (obj.ID != selectedItem)
                    {
                        obj.IsChoose = false;
                    }
                    else
                    {
                        tbTranslateX.Text = obj.Translate[0].ToString();
                        tbTranslateY.Text = obj.Translate[1].ToString();
                        tbTranslateZ.Text = obj.Translate[2].ToString();

                        tbRotateX.Text = obj.Rotate[0].ToString();
                        tbRotateY.Text = obj.Rotate[1].ToString();
                        tbRotateZ.Text = obj.Rotate[2].ToString();

                        tbScaleX.Text = obj.Scale[0].ToString();
                        tbScaleY.Text = obj.Scale[1].ToString();
                        tbScaleZ.Text = obj.Scale[2].ToString();
                    }
                }
            }
        }

        private void colorPickerDialog_Click(object sender, EventArgs e)
        {
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
                currentColor = colorPickerDialog.Color;
        }

        private void openGLControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                camera.Position[1] += 0.1f;
            }
            if (e.KeyChar == 's')
            {
                camera.Position[1] -= 0.1f;
            }
            if (e.KeyChar == 'a')
            {
                camera.Position[0] -= 0.1f;
            }
            if (e.KeyChar == 'd')
            {
                camera.Position[0] += 0.1f;
            }
            if (e.KeyChar == 'z')
            {
                camera.Position[2] -= 0.1f;
            }
            if (e.KeyChar == 'x')
            {
                camera.Position[2] += 0.1f;
            }
        }

       
        private void btnLoadTexture_Click(object sender, EventArgs e)
        {
            //  Show a file open dialog.
            if (texturePickerDialog.ShowDialog() == DialogResult.OK)
            {
                if(selectedItem > -1)
                {
                    // Updata texture file path for selected object
                    objectsRendered[selectedItem].TexturePath = (texturePickerDialog.FileName);
                    //  Redraw.
                    openGLControl.Invalidate();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbTranslateX_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbTranslateX.Text, out userVal))
            {
                currentTranslationValueX = userVal;
            }

        }

        private void tbTranslateY_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbTranslateY.Text, out userVal))
            {
                currentTranslationValueY = userVal;
            }

        }

        private void tbTranslateZ_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbTranslateZ.Text, out userVal))
            {
                currentTranslationValueZ = userVal;
            }

        }


        private void tbRotateX_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbRotateX.Text, out userVal))
            {
                currentRotationValueX = userVal;
            }

        }

        private void tbRotateY_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbRotateY.Text, out userVal))
            {
                currentRotationValueY = userVal;
            }

        }

        private void tbRotateZ_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbRotateZ.Text, out userVal))
            {
                currentRotationValueZ = userVal;
            }

        }

        private void tbScaleX_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbScaleX.Text, out userVal))
            {
                currentScalizationValueX = userVal;
            }

        }

        private void tbScaleY_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbScaleY.Text, out userVal))
            {
                currentScalizationValueY = userVal;
            }

        }

        private void tbScaleZ_TextChanged(object sender, EventArgs e)
        {
            float userVal;
            if (float.TryParse(tbScaleZ.Text, out userVal))
            {
                currentScalizationValueZ = userVal;
            }
        }
    }
}
