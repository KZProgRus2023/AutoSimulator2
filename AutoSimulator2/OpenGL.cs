using System;

namespace AutoSimulator2
{
    internal class OpenGL
    {
        public static object GL_COLOR_BUFFER_BIT { get; internal set; }
        public static object GL_DEPTH_BUFFER_BIT { get; internal set; }
        public static object GL_TRIANGLES { get; internal set; }

        internal void Begin(object gL_TRIANGLES)
        {
            throw new NotImplementedException();
        }

        internal void Clear(object value)
        {
            throw new NotImplementedException();
        }

        internal void Color(float v1, float v2, float v3)
        {
            throw new NotImplementedException();
        }

        internal void End()
        {
            throw new NotImplementedException();
        }

        internal void LoadIdentity()
        {
            throw new NotImplementedException();
        }

        internal void Translate(float v1, float v2, float v3)
        {
            throw new NotImplementedException();
        }

        internal void Vertex(float v1, float v2)
        {
            throw new NotImplementedException();
        }

        public static implicit operator OpenGL(SharpGL.OpenGL v)
        {
            throw new NotImplementedException();
        }
    }
}