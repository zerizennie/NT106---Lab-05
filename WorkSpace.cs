using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using basic_whiteboard.Classes;
using basic_whiteboard_Assignment;

namespace basic_whiteboard
{
    public partial class WorkSpace : Form

    {

        public string code;
        public string name;
        public string _port = "9090";


        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX, cursorY = -1;


        enum ToolType { Pen, Eraser, Highlighter, Line, Rectangle, Ellipse, Triangle, Bucket };
        DrawingTool[] tools; //Array of all the available tools.
        DrawingTool userTool; //Stores the tool that is currently in use.
        bool isDrawing = false; //Used to determine if the user is currently drawing -> Necessary for the mouse events
        CustomPictureBox selectedToolPic; //Stores picturebox that matches the current tool
        CustomPictureBox selectedColorPic; //Stores the picturebox that matches the color of the current tool if there is one
        Bitmap image;
        Point firstPoint;
        Point lastPoint;
        Size shapeDim;
        Point?[] triPoints;
        public WorkSpace()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public void funData(string str, string text, string port)
        {
            code = str;
            name = text;
            _port = port;
            Connect();
        }

        IPEndPoint IP;
        Socket Client;

        void Connect()
        {
            //IP: server address
            int Port = Int32.Parse(_port);
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Can't connect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();
        }

        void Receive()
        {

        }

        

        private void setUpPens()
        {
            tools = new DrawingTool[8];
            tools[0] = new DrawingTool("pen", new Pen(Color.Black, 1), false);
            tools[1] = new DrawingTool("eraser", new Pen(Color.White, 1), false);
            tools[2] = new DrawingTool("highlighter", new Pen(Color.FromArgb(100, 0, 0, 0), 1), false);
            tools[3] = new DrawingTool("line", new Pen(Color.Black, 1), false);
            tools[4] = new DrawingTool("rectangle", new Pen(Color.Black, 1), false);
            tools[5] = new DrawingTool("ellipse", new Pen(Color.Black, 1), false);
            tools[6] = new DrawingTool("triangle", new Pen(Color.Black, 1), false);
            tools[7] = new DrawingTool("bucket", new Pen(Color.Black, 0), false);

            foreach (DrawingTool t in tools)
            {
                t.Tool.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                t.Tool.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

       

        


            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }


        }

            /*private void cstpnlWhiteboard_MouseDown_1(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void cstpnlWhiteboard_MouseMove_1(object sender, MouseEventArgs e)
        {
            if(cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }

        }

        private void cstpnlWhiteboard_MouseUp_1(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void BlackBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }
            */
    }
}
