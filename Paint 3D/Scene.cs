using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Paint_3D
{
    class Scene
    {
        public Scene()
        {

        }

        float alpha = 0.2f;
        public void scene_display(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_BLEND);
            gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);

            // Display lines coordinate of the scene
            gl.Begin(OpenGL.GL_LINES);
            for (int z = -10; z < 11; z++)
            {
                if (z == 0 || z == -10 || z == 10)
                {
                    alpha = 1.0f;
                }
                else
                {
                    alpha = 0.5f;
                }
                gl.Color(1f, 1f, 1f, alpha);
                gl.Vertex(-10f, 0f, (float)z);
                gl.Vertex(10f, 0f, z);
            }

            for (int x = -10; x < 11; x++)
            {
                if (x == 0 || x == -10 || x == 10)
                {
                    alpha = 1.0f;
                }
                else
                {
                    alpha = 0.5f;
                }
                gl.Color(1f, 1f, 1f, alpha);
                gl.Vertex(x, 0f, -10f);
                gl.Vertex(x, 0f, 10f);
            }
            gl.End();
            gl.Flush();

            // Display original axis X,Y,Z
            gl.Begin(OpenGL.GL_LINES);
            // X axis
            gl.Color(1f, 0f, 0f, 1.0f);
            gl.Vertex(0.1f, 0f, 0f);
            gl.Vertex(2.1f, 0f, 0f);
            // Y axis
            gl.Color(0f, 1f, 0f, 1.0f);
            gl.Vertex(0f, 0f, 0f);
            gl.Vertex(0f, 2f, 0f);
            // Z axis
            gl.Color(0f, 0f, 1f, 1.0f);
            gl.Vertex(0f, 0f, 0.1f);
            gl.Vertex(0f, 0f, 2.1f);
            gl.End();
            gl.Flush();
        }
    }
}
