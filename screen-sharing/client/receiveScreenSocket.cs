using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class receiveScreenSocket
    {
        UdpClient listener;
        PictureBox pbox;
        Thread Listening;

        // Método construtor
        public receiveScreenSocket(string address, int Port, PictureBox Pbox)
        {
            pbox = Pbox;


            // Old
            //listener = new UdpClient(Port);


            // Testar se funciona no laboratório
            listener = new UdpClient(new IPEndPoint(IPAddress.Parse(address), Port));
            Listening = new Thread(Listener);
        }

        public void startListening()
        {
            MessageBox.Show("Entrando");
            Listening.Start();
        }

        public void stopListening()
        {
            Listening.Abort();
        }

        private void Listener()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    Thread.Sleep(1); // Resolve quebra de frame

                    var receivedResults = await listener.ReceiveAsync();
                    ThreadPool.QueueUserWorkItem(new WaitCallback(getSocket), receivedResults.Buffer);
                }
            });
        }

        byte[] buffer;
        int buffersize;
        int parts;

        private void getSocket(object obj)
        {
            byte[] recivedBytes = (byte[])obj;

            try
            {
                // Cópias das variáveis
                byte[] ibuffer = buffer;
                int ibuffersize = buffersize;
                int iparts = parts;
                int istate = recivedBytes[0];

                if (istate == 0)
                {
                    parts = recivedBytes[8];
                    iparts = recivedBytes[8];

                    byte[] byteBuffer = new byte[7];
                    Buffer.BlockCopy(recivedBytes, 1, byteBuffer, 0, 7);
                    buffersize = Convert.ToInt32(Encoding.ASCII.GetString(byteBuffer, 0, byteBuffer.Length).Replace("-", ""));

                    if (iparts == 0)
                    {
                        ibuffer = new byte[buffersize];
                        Buffer.BlockCopy(recivedBytes, 9, ibuffer, 0, buffersize);

                        ThreadPool.QueueUserWorkItem(new WaitCallback(drawBitmap), ibuffer);

                        //Console.WriteLine("Frame"); // LOG
                        return;
                    }

                    buffer = new byte[buffersize];
                    Buffer.BlockCopy(recivedBytes, 9, buffer, 0, 64999);

                    //Console.WriteLine("Inicio"); // LOG
                }
                else if (istate == parts)
                {
                    Buffer.BlockCopy(recivedBytes, 1, ibuffer, 64999 * iparts, ibuffersize - (64999 * iparts));

                    //Console.WriteLine("Final"); // LOG
                    ThreadPool.QueueUserWorkItem(new WaitCallback(drawBitmap), ibuffer);
                }
                else
                {
                    Buffer.BlockCopy(recivedBytes, 1, ibuffer, 64999 * istate, 64999);
                    buffer = ibuffer;
                    //Console.WriteLine("Parte"); // LOG
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("err: {0}", e);
            }
        }

        // Apresenta o frame
        private void drawBitmap(object obj)
        {
            byte[] buffer = (byte[])obj;

            ImageConverter convertData = new ImageConverter();
            Image img = (Image)convertData.ConvertFrom(buffer);
            pbox.Image = img;
        }

    }
}
