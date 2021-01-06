using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using SharpGL.SceneGraph;


namespace Paint3D
{
    class Camera
    {
        private float[] _position;
        private float[] _target;
        private float[] _ups;

        public Camera(float[] position, float[] target, float[] ups)
        {
            this.Position = position;
            this.Target = target;
            this.Ups = ups;
        }

        public float[] Position
        {
            get => this._position;
            set { this._position = value; }
        }

        public float[] Target
        {
            get => this._target;
            set { this._target = value; }
        }

        public float[] Ups
        {
            get => this._ups;
            set { this._ups = value; }
        }

        public void catch_Scene(OpenGL gl)
        {
            //set ma tran model view
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(
                Position[0], Position[1], Position[2],
                Target[0], Target[0], Target[0],
                Ups[0], Ups[1], Ups[2]);
        }
    }
}
