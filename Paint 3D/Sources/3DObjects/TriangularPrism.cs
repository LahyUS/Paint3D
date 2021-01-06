using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;

namespace Paint3D._3DObjects
{
    class TriangularPrism : Object
    {
        private Vertex _center;
        private string _name;
        private string _texturePath;
        private int _id;
        private bool _isChoose;
        private List<Vertex> _vertexList;
        private Texture _currentTexture;
        private List<Vertex> _textureCoord;
        private Color _currentColor;
        private float[] _translate;
        private float[] _rotate;
        private float[] _scale;

        public Vertex Center
        {
            get => this._center;
            set { this._center = value; }
        }

        public string Name
        {
            get => this._name;
            set { this._name = value; }
        }
        public string TexturePath
        {
            get => this._texturePath;
            set { this._texturePath = value; }
        }
        public int ID
        {
            get => this._id;
            set { this._id = value; }
        }

        public bool IsChoose
        {
            get => this._isChoose;
            set { this._isChoose = value; }
        }

        public List<Vertex> VertexList
        {
            get => this._vertexList;
            set { this._vertexList = value; }
        }

        public Texture CurrentTexture
        {
            get => this._currentTexture;
            set { this._currentTexture = value; }
        }

        public List<Vertex> TextureCoord
        {
            get => this._textureCoord;
            set { this._textureCoord = value; }
        }

        public Color CurrentColor
        {
            get => this._currentColor;
            set { this._currentColor = value; }
        }

        public float[] Translate
        {
            get => this._translate;
            set { this._translate = value; }
        }

        public float[] Scale
        {
            get => this._scale;
            set { this._scale = value; }
        }

        public float[] Rotate
        {
            get => this._rotate;
            set { this._rotate = value; }
        }

        public TriangularPrism(string name, int id, Color color, string texturePath)
        {
            Name = name;
            ID = id;
            IsChoose = true;
            this.VertexList = new List<Vertex>();
            CurrentColor = color;

            /*****************************************************************************/

            // 3 Bottom vertices
            VertexList.Add(new Vertex(-0.5f, 0f, -0.5f));
            VertexList.Add(new Vertex(0.5f, 0f, -0.5f));
            VertexList.Add(new Vertex(0f, 0f, 0.5f));
            // 3 Top vertices
            VertexList.Add(new Vertex(-0.5f, 1f, -0.5f));
            VertexList.Add(new Vertex(0.5f, 1f, -0.5f));
            VertexList.Add(new Vertex(0f, 1f, 0.5f));

            /*****************************************************************************/

            // Assign texture to object's texture
            _currentTexture = new Texture();
            _texturePath = texturePath;
            // Texture coordinate initialization
            TextureCoord = new List<Vertex>();
            // Side face's coordinate 
            TextureCoord.Add(new Vertex(0f, 0f, 0f));
            TextureCoord.Add(new Vertex(1f, 0f, 0f));
            TextureCoord.Add(new Vertex(1f, 1f, 0f));
            TextureCoord.Add(new Vertex(0f, 1f, 0f));
            // Top and bottom face's coordinate
            TextureCoord.Add(new Vertex(0f, 0f, 0f));
            TextureCoord.Add(new Vertex(0.5f, 1f, 0f));
            TextureCoord.Add(new Vertex(1f, 0f, 0f));

            /*****************************************************************************/

            // Transformation Initialize
            // Translation
            Translate = new float[3];
            Translate[0] = 0f; Translate[1] = 0f; Translate[2] = 0f;
            // Rotation
            Rotate = new float[3];
            Rotate[0] = 0f; Rotate[1] = 0f; Rotate[2] = 0f;
            // Scalization
            Scale = new float[3];
            Scale[0] = 1f; Scale[1] = 1f; Scale[2] = 1f;
        }

        public void showObject(OpenGL gl, int type)
        {
            // If object is choosen, set the alpha equals 1 to make it solid
            // Else make it translucent
            float alpha;
            if (IsChoose == true)
                alpha = 1.0f;
            else alpha = 0.5f;

            /*****************************************************************************/

            gl.Enable(OpenGL.GL_BLEND);
            gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);

            /*****************************************************************************/

            // Save current matrix
            gl.PushMatrix();
            // Transformation
            gl.Translate(Translate[0], Translate[1], Translate[2]);
            gl.Rotate(Rotate[0], Rotate[1], Rotate[2]);
            gl.Scale(Scale[0], Scale[1], Scale[2]);
            if (_texturePath != "")
            {
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                bool is_loaded = _currentTexture.Create(gl, _texturePath);
                _currentTexture.Bind(gl);
            }
            // Begin rendering top and bottom faces
            // Bottom face rendering
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(CurrentColor.R, CurrentColor.G, CurrentColor.B, alpha);
            gl.TexCoord(TextureCoord[4].X, TextureCoord[4].Y); gl.Vertex(VertexList[0]);
            gl.TexCoord(TextureCoord[5].X, TextureCoord[5].Y); gl.Vertex(VertexList[1]);
            gl.TexCoord(TextureCoord[6].X, TextureCoord[6].Y); gl.Vertex(VertexList[2]);
            // Top face rendering
            gl.Color(CurrentColor.R, CurrentColor.G, CurrentColor.B, alpha);
            gl.TexCoord(TextureCoord[4].X, TextureCoord[4].Y); gl.Vertex(VertexList[3]);
            gl.TexCoord(TextureCoord[5].X, TextureCoord[5].Y); gl.Vertex(VertexList[4]);
            gl.TexCoord(TextureCoord[6].X, TextureCoord[6].Y); gl.Vertex(VertexList[5]);
            // End rendering
            gl.End();
            gl.Flush();

            // Load the lastest matrix we save in the previous step
            gl.PopMatrix();

            /*****************************************************************************/

            // Save current matrix
            gl.PushMatrix();
            // Transformation
            gl.Translate(Translate[0], Translate[1], Translate[2]);
            gl.Rotate(Rotate[0], Rotate[1], Rotate[2]);
            gl.Scale(Scale[0], Scale[1], Scale[2]);

            // Begin render side faces of the prism
            // Upward side face
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(CurrentColor.R, CurrentColor.G, CurrentColor.B, alpha);
            gl.TexCoord(TextureCoord[0].X, TextureCoord[0].Y); gl.Vertex(VertexList[0]);
            gl.TexCoord(TextureCoord[1].X, TextureCoord[1].Y); gl.Vertex(VertexList[1]);
            gl.TexCoord(TextureCoord[2].X, TextureCoord[2].Y); gl.Vertex(VertexList[4]);
            gl.TexCoord(TextureCoord[3].X, TextureCoord[3].Y); gl.Vertex(VertexList[3]);
            // Right side face
            gl.Color(CurrentColor.R, CurrentColor.G, CurrentColor.B, alpha);
            gl.TexCoord(TextureCoord[0].X, TextureCoord[0].Y); gl.Vertex(VertexList[1]);
            gl.TexCoord(TextureCoord[1].X, TextureCoord[1].Y); gl.Vertex(VertexList[2]);
            gl.TexCoord(TextureCoord[2].X, TextureCoord[2].Y); gl.Vertex(VertexList[5]);
            gl.TexCoord(TextureCoord[3].X, TextureCoord[3].Y); gl.Vertex(VertexList[4]);
            // Left side face
            gl.Color(CurrentColor.R, CurrentColor.G, CurrentColor.B, alpha);
            gl.TexCoord(TextureCoord[0].X, TextureCoord[0].Y); gl.Vertex(VertexList[0]);
            gl.TexCoord(TextureCoord[1].X, TextureCoord[1].Y); gl.Vertex(VertexList[2]);
            gl.TexCoord(TextureCoord[2].X, TextureCoord[2].Y); gl.Vertex(VertexList[5]);
            gl.TexCoord(TextureCoord[3].X, TextureCoord[3].Y); gl.Vertex(VertexList[3]);
            gl.End();
            // Disable Texture in order not to effect scene rendering
            gl.Flush();

            // Get the lastest matrix we save in previous step
            gl.PopMatrix();

            /*****************************************************************************/
            if (_texturePath != "")
            {
                _currentTexture.Destroy(gl);
                gl.Disable(OpenGL.GL_TEXTURE_2D);
            }
            // If this object is choosen, render its border
            if (this.IsChoose == true)
            {
                this.drawBorder(gl, 0);
            }
        }

        public void drawBorder(OpenGL gl, int type)
        {
            // Save current matrix
            gl.PushMatrix();
            // transformate
            gl.Translate(Translate[0], Translate[1], Translate[2]);
            gl.Rotate(Rotate[0], Rotate[1], Rotate[2]);
            gl.Scale(Scale[0], Scale[1], Scale[2]);

            /*****************************************************************************/
            // Begin render border lines of the prism
            // Bottom lines
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(1.0f, 0f, 0f);
            gl.Vertex(VertexList[0]);
            gl.Vertex(VertexList[1]);
            gl.Vertex(VertexList[1]);
            gl.Vertex(VertexList[2]);
            gl.Vertex(VertexList[2]);
            gl.Vertex(VertexList[0]);
            // Top lines
            gl.Vertex(VertexList[3]);
            gl.Vertex(VertexList[4]);
            gl.Vertex(VertexList[4]);
            gl.Vertex(VertexList[5]);
            gl.Vertex(VertexList[5]);
            gl.Vertex(VertexList[3]);
            // Side face lines
            gl.Vertex(VertexList[0]);
            gl.Vertex(VertexList[3]);
            gl.Vertex(VertexList[1]);
            gl.Vertex(VertexList[4]);
            gl.Vertex(VertexList[2]);
            gl.Vertex(VertexList[5]);
            // End rendering
            gl.End();
            gl.Flush();

            // Get the lastest matrix we save in previous step
            gl.PopMatrix();
        }
    }
}
