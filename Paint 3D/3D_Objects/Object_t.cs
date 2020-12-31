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
    interface Object_t
    {
        Vertex center
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        int ID
        {
            get;
            set;
        }

        bool IsChoose
        {
            get;
            set;
        }

        List<Vertex> Vertex_List
        {
            get;
            set;
        }

        Texture MyTexture
        {
            get;
            set;
        }

        string TexturePath { get; set; }

        List<Vertex> Texture_Coord
        {
            get;
            set;
        }

        Color My_Color
        {
            get;
            set;
        }

        float[] Translate
        {
            get;
            set;
        }

        float[] Scale
        {
            get;
            set;
        }

        float[] Rotate
        {
            get;
            set;
        }

        void show_Object(OpenGL gl, int type);

        void draw_Border(OpenGL gl, int type);
    }
}
