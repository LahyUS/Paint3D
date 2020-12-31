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

namespace SharpGLTexturesSample._3D_Objects
{
    class Triangular_Prism : Object_t
    {
        private Vertex _center;
        private string _name;
        private string _texturePath;
        private int _id;
        private bool _isChoose;
        private List<Vertex> _vertexList;
        private Texture _texture;
        private List<Vertex> _textureCoord;
        private Color _myColor;
        private float[] _translate;
        private float[] _rotate;
        private float[] _scale;

        public Vertex center
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

        public List<Vertex> Vertex_List
        {
            get => this._vertexList;
            set { this._vertexList = value; }
        }

        public Texture MyTexture
        {
            get => this._texture;
            set { this._texture = value; }
        }

        public List<Vertex> Texture_Coord
        {
            get => this._textureCoord;
            set { this._textureCoord = value; }
        }

        public Color My_Color
        {
            get => this._myColor;
            set { this._myColor = value; }
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

        public Triangular_Prism(string name, int id, Color color, string texturePath)
        {
            Name = name;
            ID = id;
            IsChoose = true;
            this.Vertex_List = new List<Vertex>();
            My_Color = color;

            /*****************************************************************************/

            // 3 Bottom vertices
            Vertex_List.Add(new Vertex(-0.5f, 0f, -0.5f));
            Vertex_List.Add(new Vertex(0.5f, 0f, -0.5f));
            Vertex_List.Add(new Vertex(0f, 0f, 0.5f));
            // 3 Top vertices
            Vertex_List.Add(new Vertex(-0.5f, 1f, -0.5f));
            Vertex_List.Add(new Vertex(0.5f, 1f, -0.5f));
            Vertex_List.Add(new Vertex(0f, 1f, 0.5f));

            /*****************************************************************************/

            // Assign texture to object's texture
            _texture = new Texture();
            _texturePath = texturePath;
            // Texture coordinate initialization
            Texture_Coord = new List<Vertex>();
            // Side face's coordinate 
            Texture_Coord.Add(new Vertex(0f, 0f, 0f));
            Texture_Coord.Add(new Vertex(1f, 0f, 0f));
            Texture_Coord.Add(new Vertex(1f, 1f, 0f));
            Texture_Coord.Add(new Vertex(0f, 1f, 0f));
            // Top and bottom face's coordinate
            Texture_Coord.Add(new Vertex(0f, 0f, 0f));
            Texture_Coord.Add(new Vertex(0.5f, 1f, 0f));
            Texture_Coord.Add(new Vertex(1f, 0f, 0f));

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

        public void show_Object(OpenGL gl, int type)
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
                bool is_loaded = _texture.Create(gl, _texturePath);
                _texture.Bind(gl);
            }
            // Begin rendering top and bottom faces
            // Bottom face rendering
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(My_Color.R, My_Color.G, My_Color.B, alpha);
            gl.TexCoord(Texture_Coord[4].X, Texture_Coord[4].Y); gl.Vertex(Vertex_List[0]);
            gl.TexCoord(Texture_Coord[5].X, Texture_Coord[5].Y); gl.Vertex(Vertex_List[1]);
            gl.TexCoord(Texture_Coord[6].X, Texture_Coord[6].Y); gl.Vertex(Vertex_List[2]);
            // Top face rendering
            gl.Color(My_Color.R, My_Color.G, My_Color.B, alpha);
            gl.TexCoord(Texture_Coord[4].X, Texture_Coord[4].Y); gl.Vertex(Vertex_List[3]);
            gl.TexCoord(Texture_Coord[5].X, Texture_Coord[5].Y); gl.Vertex(Vertex_List[4]);
            gl.TexCoord(Texture_Coord[6].X, Texture_Coord[6].Y); gl.Vertex(Vertex_List[5]);
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
            gl.Color(My_Color.R, My_Color.G, My_Color.B, alpha);
            gl.TexCoord(Texture_Coord[0].X, Texture_Coord[0].Y); gl.Vertex(Vertex_List[0]);
            gl.TexCoord(Texture_Coord[1].X, Texture_Coord[1].Y); gl.Vertex(Vertex_List[1]);
            gl.TexCoord(Texture_Coord[2].X, Texture_Coord[2].Y); gl.Vertex(Vertex_List[4]);
            gl.TexCoord(Texture_Coord[3].X, Texture_Coord[3].Y); gl.Vertex(Vertex_List[3]);
            // Right side face
            gl.Color(My_Color.R, My_Color.G, My_Color.B, alpha);
            gl.TexCoord(Texture_Coord[0].X, Texture_Coord[0].Y); gl.Vertex(Vertex_List[1]);
            gl.TexCoord(Texture_Coord[1].X, Texture_Coord[1].Y); gl.Vertex(Vertex_List[2]);
            gl.TexCoord(Texture_Coord[2].X, Texture_Coord[2].Y); gl.Vertex(Vertex_List[5]);
            gl.TexCoord(Texture_Coord[3].X, Texture_Coord[3].Y); gl.Vertex(Vertex_List[4]);
            // Left side face
            gl.Color(My_Color.R, My_Color.G, My_Color.B, alpha);
            gl.TexCoord(Texture_Coord[0].X, Texture_Coord[0].Y); gl.Vertex(Vertex_List[0]);
            gl.TexCoord(Texture_Coord[1].X, Texture_Coord[1].Y); gl.Vertex(Vertex_List[2]);
            gl.TexCoord(Texture_Coord[2].X, Texture_Coord[2].Y); gl.Vertex(Vertex_List[5]);
            gl.TexCoord(Texture_Coord[3].X, Texture_Coord[3].Y); gl.Vertex(Vertex_List[3]);
            gl.End();
            // Disable Texture in order not to effect scene rendering
            gl.Flush();

            // Get the lastest matrix we save in previous step
            gl.PopMatrix();

            /*****************************************************************************/
            if (_texturePath != "")
            {
                _texture.Destroy(gl);
                gl.Disable(OpenGL.GL_TEXTURE_2D);
            }
            // If this object is choosen, render its border
            if (this.IsChoose == true)
            {
                this.draw_Border(gl, 0);
            }
        }

        public void draw_Border(OpenGL gl, int type)
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
            gl.Vertex(Vertex_List[0]);
            gl.Vertex(Vertex_List[1]);
            gl.Vertex(Vertex_List[1]);
            gl.Vertex(Vertex_List[2]);
            gl.Vertex(Vertex_List[2]);
            gl.Vertex(Vertex_List[0]);
            // Top lines
            gl.Vertex(Vertex_List[3]);
            gl.Vertex(Vertex_List[4]);
            gl.Vertex(Vertex_List[4]);
            gl.Vertex(Vertex_List[5]);
            gl.Vertex(Vertex_List[5]);
            gl.Vertex(Vertex_List[3]);
            // Side face lines
            gl.Vertex(Vertex_List[0]);
            gl.Vertex(Vertex_List[3]);
            gl.Vertex(Vertex_List[1]);
            gl.Vertex(Vertex_List[4]);
            gl.Vertex(Vertex_List[2]);
            gl.Vertex(Vertex_List[5]);
            // End rendering
            gl.End();
            gl.Flush();

            // Get the lastest matrix we save in previous step
            gl.PopMatrix();
        }
    }
}
