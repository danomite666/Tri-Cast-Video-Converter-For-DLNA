using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tri_Cast_Video_Converter.Properties;
using System.IO;



namespace Tri_Cast_Video_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Icon = Properties.Resources.appicon;
            // In your main form or startup logic
            this.Text += " © 2026 TRI CAST";

        }
        private string lastOutputFile = null;
        private System.Diagnostics.Process currentProcess = null;
        private string selectedLevel = "";
        private string selectedBitrate = "7760k";
        private string selectedMaxrate = "7760k";
        private string selectedBufsize = "15520k";

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Video Files|*.mp4;*.mkv;*.avi;*.mov;*.wmv|All Files|*.*";
                dialog.Title = "Select a video file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputFile.Text = dialog.FileName;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblProgress.Text = "Progress: 0%";

            string input = txtInputFile.Text;
            if (string.IsNullOrWhiteSpace(input) || !System.IO.File.Exists(input))
            {
                MessageBox.Show("Please select a valid input file.");
                return;
            }

            // Generate base output path
            string output = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(input),
                System.IO.Path.GetFileNameWithoutExtension(input) + "_converted.mp4"
            );

            // Check if the file already exists
            if (System.IO.File.Exists(output))
            {
                DialogResult result = MessageBox.Show(
                    "A file named \"" + System.IO.Path.GetFileName(output) + "\" already exists. " +
                    "Overwriting is not permitted. Click 'Yes' to continue conversion and provide an incremented file name.",
                    "File Conflict",
                    MessageBoxButtons.YesNoCancel
                );

                if (result == DialogResult.Cancel)
                {
                    return; // Cancel the operation
                }
                else if (result == DialogResult.Yes)
                {
                    // Rename the file by appending a suffix
                    int counter = 1;
                    string newOutput = output;
                    while (System.IO.File.Exists(newOutput))
                    {
                        newOutput = System.IO.Path.Combine(
                            System.IO.Path.GetDirectoryName(output),
                            System.IO.Path.GetFileNameWithoutExtension(output) + $"_converted_{counter}.mp4"
                        );
                        counter++;
                    }
                    output = newOutput;
                }
                // If DialogResult.No, the user declines to proceed (no action needed)
            }

            lastOutputFile = output;

            // Build the FFmpeg command (unchanged)
            string arguments =
        $"-hwaccel cuda " +
        $"-i \"{input}\" " +
        $"-threads 8 " +
        $"-c:v h264_nvenc " +
        $"-profile:v high " +
        $"-level {selectedLevel} " +
        $"-pix_fmt yuv420p " +
        $"-preset p7 " +
        $"-tune hq " +
        $"-rc cbr " +
        $"-b:v {selectedBitrate} " +
        $"-maxrate {selectedMaxrate} " +
        $"-bufsize {selectedBufsize} " +
        $"-bf 0 " +
        $"-r 30 " +
        $"-fps_mode cfr " +
        $"-c:a aac " +
        $"-ar 44100 " +
        $"-b:a 320k " +
        $"-movflags +faststart " +
        $"\"{output}\"";

        // Start FFmpeg
        TimeSpan totalDuration = GetVideoDuration(input);
            currentProcess = new System.Diagnostics.Process();
            var process = currentProcess;
            process.StartInfo.FileName = "ffmpeg.exe"; // FFmpeg.GPL places this in your output folder
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.EnableRaisingEvents = true;
            btnCancel.Enabled = true;
            btnShowOutput.Enabled = false; // disable until finished
            process.Start();
            process.BeginErrorReadLine();
            process.ErrorDataReceived += (s, ev) =>
            {
                if (ev.Data == null)
                    return;

                // Look for "time=00:01:23.45"
                var match = System.Text.RegularExpressions.Regex.Match(ev.Data, @"time=(?<time>\d+:\d+:\d+\.\d+)");
                if (match.Success)
                {
                    TimeSpan current = TimeSpan.Parse(match.Groups["time"].Value);

                    double percent = current.TotalSeconds / totalDuration.TotalSeconds * 100.0;

                    // Update UI safely
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.Value = Math.Min(100, (int)percent);
                        lblProgress.Text = $"Progress: {percent:0}% ({current} / {totalDuration})";
                    }));
                }
            };

            process.Exited += (s, ev) =>
            {
                this.Invoke(new Action(() =>
                {
                    progressBar1.Value = 100;
                    lblProgress.Text = "Conversion Complete";

                    btnCancel.Enabled = false;
                    btnShowOutput.Enabled = true;

                    MessageBox.Show("Conversion Complete!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            };


        }

        private TimeSpan GetVideoDuration(string inputFile)
        {
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "ffmpeg.exe";
            process.StartInfo.Arguments = $"-i \"{inputFile}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardError.ReadToEnd();
            process.WaitForExit();

            // Look for "Duration: 00:03:45.12"
            var match = System.Text.RegularExpressions.Regex.Match(output, @"Duration:\s(?<duration>\d+:\d+:\d+\.\d+)");
            if (match.Success)
            {
                return TimeSpan.Parse(match.Groups["duration"].Value);
            }

            return TimeSpan.Zero;
        }

        private void btnShowOutput_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastOutputFile) && System.IO.File.Exists(lastOutputFile)) 
            { 
                System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{lastOutputFile}\""); 
            } 
            else 
            {
                MessageBox.Show("Output file not found."); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentProcess != null && !currentProcess.HasExited) 
            { 
                try { currentProcess.Kill(); 
                    currentProcess.Dispose(); 
                } 
                catch { } 
                
                progressBar1.Value = 0; 
                lblProgress.Text = "Conversion canceled"; 
                btnCancel.Enabled = false; btnShowOutput.Enabled = false; 
                MessageBox.Show("Conversion has been canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btnCustomBitrate_Click(object sender, EventArgs e)
        {
            string input = txtCustomBitrate.Text.Trim(); 
            if (string.IsNullOrWhiteSpace(input)) 
            { 
                MessageBox.Show("Please enter a bitrate value such as 12000k."); return; 
            } 
            // Basic validation: must end with 'k' and start with a number
            if (!input.EndsWith("k") || !int.TryParse(input.TrimEnd('k'), out int numericValue)) 
            { 
                MessageBox.Show("Invalid bitrate format. Use something like 12000k."); 
                return; 
            } 
            // Apply the custom bitrate
            selectedBitrate = input; 
            selectedMaxrate = input; 
            selectedBufsize = (numericValue * 2).ToString() + "k"; // bufsize = 2× maxrate
            lblProgress.Text = $"Preset: Custom ({input})";
        }

        private void btn1080p_Click_1(object sender, EventArgs e)
        {
            selectedBitrate = "12000k";
            selectedMaxrate = "12000k";
            selectedBufsize = "24000k";
            selectedLevel = "4.1";
            lblProgress.Text = "Preset: 1080p";
        }

        private void btn720p_Click_1(object sender, EventArgs e)
        {
            selectedBitrate = "7760k";
            selectedMaxrate = "7760k";
            selectedBufsize = "15520k";
            selectedLevel = "4.0";
            lblProgress.Text = "Preset: 720p";
        }

        private void btn1440p_Click_1(object sender, EventArgs e)
        {
            selectedBitrate = "18000k";
            selectedMaxrate = "18000k";
            selectedBufsize = "36000k";
            selectedLevel = "5.0";
            lblProgress.Text = "Preset: 1440p";
        }

        private void btn4k_Click(object sender, EventArgs e)
        {
            selectedBitrate = "28000k";
            selectedMaxrate = "28000k";
            selectedBufsize = "56000k";
            selectedLevel = "5.1";
            lblProgress.Text = "Preset: 4K UHD";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseForm licenseDialog = new LicenseForm();
            licenseDialog.StartPosition = FormStartPosition.CenterScreen;
            if (licenseDialog.ShowDialog() == DialogResult.OK)
            {
                // User accepted the license
            }
            else
            {
                // User canceled; exit the application
                Application.Exit();
            }

        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true; // Prevent closing unless "I Accept" is clicked
            }
        }

    }
}

