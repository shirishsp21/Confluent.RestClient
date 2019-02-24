﻿namespace Confluent.TestHarness
{
    partial class TestApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConsumerGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConsumerId = new System.Windows.Forms.TextBox();
            this.buttonGetTopics = new System.Windows.Forms.Button();
            this.buttonGetTopicMetadata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPartitionId = new System.Windows.Forms.TextBox();
            this.buttonGetPartitions = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBinary = new System.Windows.Forms.Button();
            this.buttonAvro = new System.Windows.Forms.Button();
            this.buttonCreateBinaryConsumer = new System.Windows.Forms.Button();
            this.buttonCreateAvroConsumer = new System.Windows.Forms.Button();
            this.buttonCommitOffset = new System.Windows.Forms.Button();
            this.buttonConsumerBinary = new System.Windows.Forms.Button();
            this.buttonConsumeAvro = new System.Windows.Forms.Button();
            this.buttonDeleteConsumer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxBytes = new System.Windows.Forms.TextBox();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(13, 227);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(853, 406);
            this.textBoxLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic: ";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTopic.Location = new System.Drawing.Point(124, 67);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(119, 22);
            this.textBoxTopic.TabIndex = 2;
            this.textBoxTopic.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumer Group:";
            // 
            // textBoxConsumerGroup
            // 
            this.textBoxConsumerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsumerGroup.Location = new System.Drawing.Point(124, 96);
            this.textBoxConsumerGroup.Name = "textBoxConsumerGroup";
            this.textBoxConsumerGroup.Size = new System.Drawing.Size(119, 22);
            this.textBoxConsumerGroup.TabIndex = 2;
            this.textBoxConsumerGroup.Text = "testgroup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Consumer Id:";
            // 
            // textBoxConsumerId
            // 
            this.textBoxConsumerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsumerId.Location = new System.Drawing.Point(123, 126);
            this.textBoxConsumerId.Name = "textBoxConsumerId";
            this.textBoxConsumerId.Size = new System.Drawing.Size(119, 22);
            this.textBoxConsumerId.TabIndex = 2;
            this.textBoxConsumerId.Text = "testconsumer";
            // 
            // buttonGetTopics
            // 
            this.buttonGetTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetTopics.Location = new System.Drawing.Point(266, 65);
            this.buttonGetTopics.Name = "buttonGetTopics";
            this.buttonGetTopics.Size = new System.Drawing.Size(163, 33);
            this.buttonGetTopics.TabIndex = 3;
            this.buttonGetTopics.Text = "Get Topics";
            this.buttonGetTopics.UseVisualStyleBackColor = true;
            this.buttonGetTopics.Click += new System.EventHandler(this.buttonGetTopics_Click);
            // 
            // buttonGetTopicMetadata
            // 
            this.buttonGetTopicMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetTopicMetadata.Location = new System.Drawing.Point(266, 103);
            this.buttonGetTopicMetadata.Name = "buttonGetTopicMetadata";
            this.buttonGetTopicMetadata.Size = new System.Drawing.Size(163, 33);
            this.buttonGetTopicMetadata.TabIndex = 3;
            this.buttonGetTopicMetadata.Text = "Get Topic Metadata";
            this.buttonGetTopicMetadata.UseVisualStyleBackColor = true;
            this.buttonGetTopicMetadata.Click += new System.EventHandler(this.buttonGetTopicMetadata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Partition Id:";
            // 
            // textBoxPartitionId
            // 
            this.textBoxPartitionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPartitionId.Location = new System.Drawing.Point(123, 158);
            this.textBoxPartitionId.Name = "textBoxPartitionId";
            this.textBoxPartitionId.Size = new System.Drawing.Size(119, 22);
            this.textBoxPartitionId.TabIndex = 2;
            this.textBoxPartitionId.Text = "0";
            this.textBoxPartitionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartitionId_KeyPress);
            // 
            // buttonGetPartitions
            // 
            this.buttonGetPartitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPartitions.Location = new System.Drawing.Point(266, 141);
            this.buttonGetPartitions.Name = "buttonGetPartitions";
            this.buttonGetPartitions.Size = new System.Drawing.Size(163, 33);
            this.buttonGetPartitions.TabIndex = 3;
            this.buttonGetPartitions.Text = "Get Partitions";
            this.buttonGetPartitions.UseVisualStyleBackColor = true;
            this.buttonGetPartitions.Click += new System.EventHandler(this.buttonGetPartitions_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Partition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBinary
            // 
            this.buttonBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinary.Location = new System.Drawing.Point(433, 65);
            this.buttonBinary.Name = "buttonBinary";
            this.buttonBinary.Size = new System.Drawing.Size(163, 33);
            this.buttonBinary.TabIndex = 3;
            this.buttonBinary.Text = "Publish Binary";
            this.buttonBinary.UseVisualStyleBackColor = true;
            this.buttonBinary.Click += new System.EventHandler(this.buttonBinary_Click);
            // 
            // buttonAvro
            // 
            this.buttonAvro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvro.Location = new System.Drawing.Point(433, 103);
            this.buttonAvro.Name = "buttonAvro";
            this.buttonAvro.Size = new System.Drawing.Size(163, 33);
            this.buttonAvro.TabIndex = 3;
            this.buttonAvro.Text = "Publish Avro";
            this.buttonAvro.UseVisualStyleBackColor = true;
            this.buttonAvro.Click += new System.EventHandler(this.buttonAvro_Click);
            // 
            // buttonCreateBinaryConsumer
            // 
            this.buttonCreateBinaryConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBinaryConsumer.Location = new System.Drawing.Point(433, 141);
            this.buttonCreateBinaryConsumer.Name = "buttonCreateBinaryConsumer";
            this.buttonCreateBinaryConsumer.Size = new System.Drawing.Size(163, 33);
            this.buttonCreateBinaryConsumer.TabIndex = 3;
            this.buttonCreateBinaryConsumer.Text = "Create Binary Consumer";
            this.buttonCreateBinaryConsumer.UseVisualStyleBackColor = true;
            this.buttonCreateBinaryConsumer.Click += new System.EventHandler(this.buttonCreateBinaryConsumer_Click);
            // 
            // buttonCreateAvroConsumer
            // 
            this.buttonCreateAvroConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAvroConsumer.Location = new System.Drawing.Point(433, 181);
            this.buttonCreateAvroConsumer.Name = "buttonCreateAvroConsumer";
            this.buttonCreateAvroConsumer.Size = new System.Drawing.Size(163, 33);
            this.buttonCreateAvroConsumer.TabIndex = 3;
            this.buttonCreateAvroConsumer.Text = "Create Avro Consumer";
            this.buttonCreateAvroConsumer.UseVisualStyleBackColor = true;
            this.buttonCreateAvroConsumer.Click += new System.EventHandler(this.buttonCreateAvroConsumer_Click);
            // 
            // buttonCommitOffset
            // 
            this.buttonCommitOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommitOffset.Location = new System.Drawing.Point(600, 141);
            this.buttonCommitOffset.Name = "buttonCommitOffset";
            this.buttonCommitOffset.Size = new System.Drawing.Size(163, 33);
            this.buttonCommitOffset.TabIndex = 3;
            this.buttonCommitOffset.Text = "Commit Offset";
            this.buttonCommitOffset.UseVisualStyleBackColor = true;
            this.buttonCommitOffset.Click += new System.EventHandler(this.buttonCommitOffset_Click);
            // 
            // buttonConsumerBinary
            // 
            this.buttonConsumerBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsumerBinary.Location = new System.Drawing.Point(600, 65);
            this.buttonConsumerBinary.Name = "buttonConsumerBinary";
            this.buttonConsumerBinary.Size = new System.Drawing.Size(163, 33);
            this.buttonConsumerBinary.TabIndex = 3;
            this.buttonConsumerBinary.Text = "Consume Binary";
            this.buttonConsumerBinary.UseVisualStyleBackColor = true;
            this.buttonConsumerBinary.Click += new System.EventHandler(this.buttonConsumerBinary_Click);
            // 
            // buttonConsumeAvro
            // 
            this.buttonConsumeAvro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsumeAvro.Location = new System.Drawing.Point(600, 103);
            this.buttonConsumeAvro.Name = "buttonConsumeAvro";
            this.buttonConsumeAvro.Size = new System.Drawing.Size(163, 33);
            this.buttonConsumeAvro.TabIndex = 3;
            this.buttonConsumeAvro.Text = "Consume Avro";
            this.buttonConsumeAvro.UseVisualStyleBackColor = true;
            this.buttonConsumeAvro.Click += new System.EventHandler(this.buttonConsumeAvro_Click);
            // 
            // buttonDeleteConsumer
            // 
            this.buttonDeleteConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteConsumer.Location = new System.Drawing.Point(600, 181);
            this.buttonDeleteConsumer.Name = "buttonDeleteConsumer";
            this.buttonDeleteConsumer.Size = new System.Drawing.Size(163, 33);
            this.buttonDeleteConsumer.TabIndex = 3;
            this.buttonDeleteConsumer.Text = "Delete Consumer";
            this.buttonDeleteConsumer.UseVisualStyleBackColor = true;
            this.buttonDeleteConsumer.Click += new System.EventHandler(this.buttonDeleteConsumer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maximum Bytes:";
            // 
            // textBoxMaxBytes
            // 
            this.textBoxMaxBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxBytes.Location = new System.Drawing.Point(124, 188);
            this.textBoxMaxBytes.Name = "textBoxMaxBytes";
            this.textBoxMaxBytes.Size = new System.Drawing.Size(119, 22);
            this.textBoxMaxBytes.TabIndex = 2;
            this.textBoxMaxBytes.Text = "0";
            this.textBoxMaxBytes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxBytes_KeyPress);
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Controls.Add(this.textBoxPassword);
            this.groupBoxAuth.Controls.Add(this.labelPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxUsername);
            this.groupBoxAuth.Controls.Add(this.labelUsername);
            this.groupBoxAuth.Location = new System.Drawing.Point(16, 9);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(747, 46);
            this.groupBoxAuth.TabIndex = 4;
            this.groupBoxAuth.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelUsername.Location = new System.Drawing.Point(22, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 16);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(108, 13);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(220, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(477, 13);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(220, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelPassword.Location = new System.Drawing.Point(391, 18);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 16);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 645);
            this.Controls.Add(this.groupBoxAuth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGetPartitions);
            this.Controls.Add(this.buttonGetTopicMetadata);
            this.Controls.Add(this.buttonConsumeAvro);
            this.Controls.Add(this.buttonConsumerBinary);
            this.Controls.Add(this.buttonDeleteConsumer);
            this.Controls.Add(this.buttonCommitOffset);
            this.Controls.Add(this.buttonCreateAvroConsumer);
            this.Controls.Add(this.buttonCreateBinaryConsumer);
            this.Controls.Add(this.buttonAvro);
            this.Controls.Add(this.buttonBinary);
            this.Controls.Add(this.buttonGetTopics);
            this.Controls.Add(this.textBoxMaxBytes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPartitionId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConsumerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConsumerGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Name = "TestApp";
            this.Text = "Test Harness";
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConsumerGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConsumerId;
        private System.Windows.Forms.Button buttonGetTopics;
        private System.Windows.Forms.Button buttonGetTopicMetadata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPartitionId;
        private System.Windows.Forms.Button buttonGetPartitions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBinary;
        private System.Windows.Forms.Button buttonAvro;
        private System.Windows.Forms.Button buttonCreateBinaryConsumer;
        private System.Windows.Forms.Button buttonCreateAvroConsumer;
        private System.Windows.Forms.Button buttonCommitOffset;
        private System.Windows.Forms.Button buttonConsumerBinary;
        private System.Windows.Forms.Button buttonConsumeAvro;
        private System.Windows.Forms.Button buttonDeleteConsumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxBytes;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
    }
}

