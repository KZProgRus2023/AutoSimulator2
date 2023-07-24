namespace AutoSimulator2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private SharpGL.RenderEventHandler GetRenderEventHandler()
        {
            SharpGL.RenderEventHandler renderEventHandler1 = new SharpGL.RenderEventHandler(openGLControl1_OpenGLDraw);
            SharpGL.RenderEventHandler renderEventHandler = renderEventHandler1;
            return renderEventHandler;
        }

        private SharpGL.RenderEventHandler GetRenderEventHandler(SharpGL.RenderEventHandler renderEventHandler) => renderEventHandler;

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent(SharpGL.RenderEventHandler renderEventHandler)
        {
            this.glColourPicker1 = new SharpGL.Controls.GLColourPicker();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.openGLControl2 = new SharpGL.OpenGLControl();
            this.sceneControl1 = new SharpGL.SceneControl();
            this.vertexControl1 = new SharpGL.Controls.VertexControl();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // glColourPicker1
            // 
            this.glColourPicker1.Location = new System.Drawing.Point(65, 388);
            this.glColourPicker1.Name = "glColourPicker1";
            this.glColourPicker1.Size = new System.Drawing.Size(75, 23);
            this.glColourPicker1.TabIndex = 0;
            this.glColourPicker1.Text = "glColourPicker1";
            // 
            // openGLControl1
            // 
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(0, 0);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(800, 450);
            this.openGLControl1.TabIndex = 1;
            this.openGLControl1.OpenGLDraw += renderEventHandler;
            // 
            // openGLControl2
            // 
            this.openGLControl2.DrawFPS = false;
            this.openGLControl2.Location = new System.Drawing.Point(314, 288);
            this.openGLControl2.Name = "openGLControl2";
            this.openGLControl2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl2.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl2.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl2.Size = new System.Drawing.Size(150, 150);
            this.openGLControl2.TabIndex = 2;
            // 
            // sceneControl1
            // 
            this.sceneControl1.DrawFPS = false;
            this.sceneControl1.Location = new System.Drawing.Point(158, 105);
            this.sceneControl1.Name = "sceneControl1";
            this.sceneControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.sceneControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.sceneControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.sceneControl1.Size = new System.Drawing.Size(150, 150);
            this.sceneControl1.TabIndex = 3;
            // 
            // vertexControl1
            // 
            this.vertexControl1.Location = new System.Drawing.Point(471, 406);
            this.vertexControl1.Name = "vertexControl1";
            this.vertexControl1.Size = new System.Drawing.Size(136, 32);
            this.vertexControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vertexControl1);
            this.Controls.Add(this.sceneControl1);
            this.Controls.Add(this.openGLControl2);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.glColourPicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.Controls.GLColourPicker glColourPicker1;
        private SharpGL.OpenGLControl openGLControl1;
        private SharpGL.OpenGLControl openGLControl2;
        private SharpGL.SceneControl sceneControl1;
        private SharpGL.Controls.VertexControl vertexControl1;
    }
}

