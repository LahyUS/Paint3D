using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using SharpGL.SceneGraph;


namespace Paint_3D
{
    class Camera
    {
        private float[] _position;
        private float[] _target;
        private float[] _ups;

        public Camera(float[] Position, float[] Target, float[] Ups)
        {
            position = Position;
            target = Target;
            ups = Ups;
        }

        public float[] position
        {
            get => this._position;
            set { this._position = value; }
        }

        public float[] target
        {
            get => this._target;
            set { this._target = value; }
        }

        public float[] ups
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
                position[0], position[1], position[2],
                target[0], target[0], target[0],
                ups[0], ups[1], ups[2]);
        }
    }
}
