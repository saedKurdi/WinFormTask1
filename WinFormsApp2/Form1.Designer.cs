namespace WinFormsApp2
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        int begin_x ;
        int begin_y ;

        int end_x ;
        int end_y ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Task1";

           

            MouseDown += Form1_MouseDown;

            MouseUp += Form1_MouseUp;


            ResumeLayout(false);
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            begin_x = e.Location.X;
            begin_y = e.Location.Y;
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            end_x = e.Location.X;
            end_y = e.Location.Y;

            if (end_x > this.Width) end_x = this.Width - 1;
            if (end_y > this.Height) end_y = this.Height - 1;


            Label l =new Label();
            l.BackColor = Color.Red;
            l.MouseClick += L_MouseClick;
            l.DoubleClick += L_DoubleClick;

            if(end_x >= begin_x && end_y >= begin_y)
            {
                l.Size = new Size(end_x - begin_x,end_y - begin_y);
                l.Location = new Point(begin_x,begin_y);
            }

            else if(end_x <= begin_x && end_y >=begin_y)
            {
                l.Size = new Size(begin_x - end_x,end_y - begin_y);
                l.Location = new Point(end_x,begin_y);
            }

            else if(end_x  <= begin_x && end_y <= begin_y)
            {
                l.Size = new Size(begin_x - end_x,begin_y - end_y);
                l.Location = new Point(end_x,end_y);
            }

            else if(end_x >= begin_x && end_y <= begin_y)
            {
                l.Size = new Size(end_x - begin_x,begin_y - end_y);
                l.Location = new Point(begin_x,end_y);
            }
            Controls.Add(l);
        }

        private void L_DoubleClick(object sender, EventArgs e)
        {
            var l = sender as Label;
            var mouse = e as MouseEventArgs;

            if(mouse.Button == MouseButtons.Left)
            {
                l.Dispose();
            }
        }

        private void L_MouseClick(object sender, MouseEventArgs e)
        {
            var l = sender as Label;
           if(e.Button == MouseButtons.Left)
            {
                l.Text = $"Sahe : {l.Width * l.Height}\nLocation - {l.Location.X} : {l.Location.Y}";
            }
        }




        #endregion
    }
}