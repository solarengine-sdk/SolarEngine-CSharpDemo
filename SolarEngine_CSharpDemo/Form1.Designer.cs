using System;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication2
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
     

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

    
        // 辅助方法：创建并配置按钮
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // 设置窗体的基本属性
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);

            int xPosition = 20; // 起始X位置
            int yPosition = 20; // 起始Y位置

           
               // AddButton(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SolarEngineData.json"), xPosition, ref yPosition, 400, 40, setSuperProperties);

            AddButton("setSuperProperties", xPosition, ref yPosition, 100, 40, setSuperProperties);

            AddButton("setPresetEvent", xPosition, ref yPosition, 100, 40, setPresetEvent);


            // 初始化并配置按钮（使用辅助方法简化代码）
            AddButton("setChannel", xPosition, ref yPosition, 100, 40, setChannel);
            AddButton("init SDK", xPosition, ref yPosition, 100, 40, init);
            AddButton("login", xPosition, ref yPosition, 100, 40, login);
            AddButton("disticid", xPosition, ref yPosition, 100, 40, getDistinctId);
            AddButton("getAccountId", xPosition, ref yPosition, 100, 40, getAccountId);
            AddButton("setVisitorId", xPosition, ref yPosition, 100, 40, setVisitorId);
            AddButton("getVisitorId", xPosition, ref yPosition, 100, 40, getVisitorId);
            AddButton("getPresetProperties", xPosition, ref yPosition, 100, 40, getPresetProperties);
            //AddButton("getPresetProperties", xPosition, ref yPosition, 100, 40, reportEventImmediately);
            AddButton("logout", xPosition, ref yPosition, 100, 40, logout);

            // 第二列按钮
            xPosition += 120; yPosition = 20; // 重置Y位置，并移动到下一列
            AddButton("trackAdClick", xPosition, ref yPosition, 100, 40, trackAdClick);

            AddButton("eventStart", xPosition, ref yPosition, 100, 40, eventStart);
            AddButton("eventFinish", xPosition, ref yPosition, 100, 40, eventFinish);



            AddButton("trackRegister", xPosition, ref yPosition, 100, 40, trackRegister);
            AddButton("track", xPosition, ref yPosition, 100, 40, track);
            AddButton("trackAppAtrr", xPosition, ref yPosition, 100, 40, trackAppAtrr);
            AddButton("trackIAP", xPosition, ref yPosition, 100, 40, trackIAP);
            AddButton("trackFirstEvent", xPosition, ref yPosition, 100, 40, trackFirstEvent);
            AddButton("trackAdImpression", xPosition, ref yPosition, 100, 40, trackAdImpression);
            AddButton("reportEventImmediately", xPosition, ref yPosition, 100, 40, reportEventImmediately);

            // 第三列按钮
            xPosition += 120; yPosition = 20; // 重置Y位置，并移动到下一列
            AddButton("trackLogin", xPosition, ref yPosition, 100, 40, trackLogin);
            AddButton("trackOrder", xPosition, ref yPosition, 100, 40, trackOrder);
            AddButton("userInit", xPosition, ref yPosition, 100, 40, userInit);
            AddButton("userUpdate", xPosition, ref yPosition, 100, 40, userUpdate);
            AddButton("userAdd", xPosition, ref yPosition, 100, 40, userAdd);
            AddButton("userUnset", xPosition, ref yPosition, 100, 40, userUnset);
            AddButton("userAppend", xPosition, ref yPosition, 100, 40, userAppend);
            AddButton("userDelete", xPosition, ref yPosition, 100, 40, userDelete);

            this.ResumeLayout(false);
        }

        // 辅助方法：创建并配置按钮
        private void AddButton(string text, int x, ref int y, int width, int height, EventHandler onClick)
        {
            var button = new System.Windows.Forms.Button()
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(width, height)
            };
            button.Click += onClick;
            this.Controls.Add(button);
            y += 60; // 更新Y位置以便下一个控件使用
        }

        #endregion
    }
}

