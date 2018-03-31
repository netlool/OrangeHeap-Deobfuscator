using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeHeapDeobfuscator
{
    public partial class MainForm : Form
    {
        private static MethodDef target;
        public MainForm()
        {
            InitializeComponent();
        }
        string NAME
        {
        get
            {
                return "OrangeHeap Deobfuscator";
            }
        }
        private void btnofd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "NET Assembly| *.exe| NET DLL| *.dll";
            ofd.Title = "Choose a File";
            if(ofd.ShowDialog() == DialogResult.OK)
                tbin.Text = ofd.FileName;
        }

        private void btnsfd_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose a File";
            sfd.Filter = "NET Assembly| *.exe| NET DLL| *.dll";
            if (sfd.ShowDialog() == DialogResult.OK) 
                tbout.Text = sfd.FileName;
        }

        private void btnDeobf_Click(object sender, EventArgs e)
        {
            ModuleDefMD md = ModuleDefMD.Load(tbin.Text);
            if (!IsObfuscator(md))
                MessageBox.Show(null, "This Assembly is not protected with Orange Heap!", NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach(var type in md.Types)
                {
                    foreach(var method in type.Methods)
                    {
                        if (!method.HasBody) continue;
                        CilBody body = method.Body;
                        body.KeepOldMaxStack = true;
                        for(int  i = 0; i < body.Instructions.Count; i++)
                        {
                            if(body.Instructions[i].OpCode == OpCodes.Ldstr &&
                                body.Instructions[i + 1].OpCode == OpCodes.Call &&
                                body.Instructions[i + 1].Operand == target)
                            {
                                body.Instructions[i].Operand = decryptstring(body.Instructions[i].Operand.ToString());
                                body.Instructions[i + 1].Operand = null;
                                body.Instructions[i + 1].OpCode = OpCodes.Nop;
                            }
                        }
                    }
                }
                md.Write(tbout.Text);
                MessageBox.Show(null,"Saved Assembly to: " + tbout.Text, NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }
        private static bool IsObfuscator(ModuleDefMD md)
        {
            foreach(var type in md.Types)
            {
                foreach(var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    if (!method.ReturnType.ToString().ToLower().Contains("string")) continue;
                    CilBody body = method.Body;
                    for(int i = 0; i < body.Instructions.Count; i++)
                    {
                       if(body.Instructions[i].OpCode == OpCodes.Shr &&
                            body.Instructions[i + 1].OpCode == OpCodes.Ldloc_2 &&
                            body.Instructions[i + 2].OpCode == OpCodes.Xor &&
                            body.Instructions[i + 3].OpCode == OpCodes.Conv_U1)
                        {
                            target = method;
                            return true;
                        }  
                    }
                }
            }
            return false;
        }
        private static string decryptstring(string a6)
        {
            int length = a6.Length;
            char[] array = new char[length];
            for (int i = 0; i < array.Length; i++)
            {
                char c = a6[i];
                byte b = (byte)((int)c ^ length - i);
                byte b2 = (byte)((int)(c >> 8) ^ i);
                array[i] = (char)((int)b2 << 8 | (int)b);
            }
            return string.Intern(new string(array));
        }
     
        } 
    }

