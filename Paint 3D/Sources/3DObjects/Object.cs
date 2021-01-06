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
    interface Object
    {
        Vertex Center
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

        List<Vertex> VertexList
        {
            get;
            set;
        }

        Texture CurrentTexture
        {
            get;
            set;
        }

        string TexturePath { get; set; }

        List<Vertex> TextureCoord
        {
            get;
            set;
        }

        Color CurrentColor
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

        void showObject(OpenGL gl, int type);

        void drawBorder(OpenGL gl, int type);
    }
}
