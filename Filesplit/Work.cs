using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Filesplit
{
    public class Work
    {
        private double progress = 0.0;
        private double currentProgress = 0.0;
        private bool isBusy = false;

        public delegate void isReady();
        public event isReady IsReady;

        public delegate void currentProgressChanged(double prg);
        public event currentProgressChanged CurrentProgressChanged;

        public delegate void progressChanged(double prg);
        public event progressChanged ProgressChanged;

        public double Progress
        {
            get
            {
                return this.progress;
            }
            private set
            {
                this.progress = value;
                if (this.ProgressChanged != null)
                    this.ProgressChanged(value);
            }
        }

        public double CurrentProgress
        {
            get
            {
                return this.currentProgress;
            }
            private set
            {
                this.currentProgress = value;
                if (this.CurrentProgressChanged != null)
                    this.CurrentProgressChanged(value);
            }
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
        }

        public enum Action
        {
            Split,
            PutTogheter
        }

        public void DoWork(Action currentAction, string[] files, string mainFile = "", string directory = "", long size = 32768)
        {
            if (isBusy)
                return;

            isBusy = true;
            switch (currentAction)
            {
                case Action.PutTogheter:
                    {
                        // Get progress info.
                        int file_ = files.Length;
                        int currentFile_ = 0;

                        // Start to create main stream 
                        Thread currentThread = new Thread(new ThreadStart(delegate
                        {
                            using (System.IO.FileStream targetStream = new System.IO.FileStream(mainFile, System.IO.FileMode.Create))
                            {
                                foreach (string currentFile in files)
                                {
                                    long currentPosition = 0L;
                                    byte[] buffer = new byte[4096 * 4096];

                                    using (FileStream currentStream = new FileStream(currentFile, FileMode.OpenOrCreate))
                                    {
                                        while (currentPosition < currentStream.Length)
                                        {
                                            if (currentPosition + buffer.Length > currentStream.Length)
                                            {
                                                while (currentPosition + buffer.Length > currentStream.Length)
                                                {
                                                    if (buffer.Length / 2 == 0)
                                                        break;
                                                    buffer = new byte[buffer.Length / 2];
                                                }
                                            }

                                            currentPosition += currentStream.Read(buffer, 0, buffer.Length);
                                            targetStream.Write(buffer, 0, buffer.Length);
                                            this.CurrentProgress = currentPosition / (double)currentStream.Length;
                                        }
                                        this.CurrentProgress = 1;
                                        this.Progress = ++currentFile_ / (double)file_;
                                    }
                                }
                            }
                            this.isBusy = false;
                            if (this.IsReady != null)
                                this.IsReady();

                        }));
                        currentThread.Start();
                    }
                    break;
                case Action.Split:
                    {
                        this.isBusy = true;

                        Thread currentThread = new Thread(new ThreadStart(delegate
                        {
                            if (System.IO.Directory.Exists(directory))
                                System.IO.Directory.CreateDirectory(directory);

                            FileStream currentFile = new FileStream(System.IO.Path.Combine(directory, System.IO.Path.GetFileNameWithoutExtension(mainFile) + ".0"), FileMode.Create);
                            using (FileStream currentStream = new FileStream(mainFile, FileMode.Open))
                            {
                                int fileCounter = 0;
                                long currentPosition = 0L;

                                while (currentPosition < currentStream.Length)
                                {
                                    byte[] buffer = new byte[size];

                                    if (currentPosition + buffer.Length > currentStream.Length)
                                    {
                                        buffer = new byte[currentStream.Length - currentPosition];
                                        currentPosition += currentStream.Read(buffer, 0, buffer.Length);
                                        currentFile.Write(buffer, 0, buffer.Length);

                                        currentFile.Flush();
                                        currentFile.Close();

                                        this.Progress = 1;
                                        this.CurrentProgress = 1;
                                        break;
                                    }
                                    else
                                    {
                                        currentPosition += currentStream.Read(buffer, 0, buffer.Length);
                                        currentFile.Write(buffer, 0, buffer.Length);
                                        this.CurrentProgress = currentPosition / (double)currentStream.Length;
                                    }

                                    currentFile.Flush();
                                    currentFile.Close();
                                    currentFile = new FileStream(System.IO.Path.Combine(directory, System.IO.Path.GetFileNameWithoutExtension(mainFile) + "." + ++fileCounter), FileMode.Create);
                                }
                            }
                            this.isBusy = false;
                            if (this.IsReady != null)
                                this.IsReady();
                        }));

                        currentThread.Start();
                    }
                    break;
            }
        }

    }
}
