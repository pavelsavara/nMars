// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugWarriorOverview : UserControl
    {
        public DebugWarriorOverview()
        {
            InitializeComponent();
        }

        public void Attach(TableLayoutPanel panel, int aWarriorIndex)
        {
            Dock = DockStyle.Fill;
            warriorIndex = aWarriorIndex;
            panel.Controls.Add(this, aWarriorIndex, 0);
            groupBox.Text = Application.ActiveEngine.Warriors[aWarriorIndex].Name + " by " +
                            Application.ActiveEngine.Warriors[aWarriorIndex].Author;
            helper = new TaskListHelper(Application.ActiveEngine, aWarriorIndex);
            listBoxNextInstructions.BeginUpdate();
            listBoxNextInstructions.Attach(Application.ActiveEngine);
            listBoxNextInstructions.DataSource = helper;
            listBoxNextInstructions.EndUpdate();

        }

        public void RepaintView()
        {
            IRunningWarrior rw = Application.ActiveEngine.RunningWarriors[warriorIndex];
            textBoxTasks.Text = rw.TasksCount + "/" + rw.DeadTasksCount;
            if (rw.PrevInstruction != null)
                textBoxLastInstruction.Text = rw.PrevInstruction.ToString();
            else
                textBoxLastInstruction.Text = null;


            listBoxNextInstructions.BeginUpdate();
            listBoxNextInstructions.RepaintView();
            int maxVisible;
            if (Application.ActiveEngine.IsPaused)
            {
                maxVisible = Application.ActiveEngine.Project.Rules.MaxProcesses;
            }
            else
            {
                maxVisible = listBoxNextInstructions.Height / listBoxNextInstructions.ItemHeight;
            }
            helper.Update(maxVisible);
            listBoxNextInstructions.EndUpdate();
        }

        private int warriorIndex;
        private TaskListHelper helper;
    }

    class TaskListHelper : CoreBindingList
    {
        private int warriorIndex;
        private List<int> tasks=new List<int>();
        public void Update(int maxVisible)
        {
            IRunningWarrior rw = Engine.RunningWarriors[warriorIndex];
            tasks.Clear();
            foreach (int task in rw.Tasks)
            {
                tasks.Add(task);
                if (tasks.Count >= maxVisible)
                    break;
            }
            InvalidateAll();
        }

        public TaskListHelper(IAsyncEngine aEngine, int aWarriorIndex)
            : base(aEngine)
        {
            warriorIndex = aWarriorIndex;
            Update(aEngine.Project.Rules.MaxProcesses);
        }

        public override object this[int index]
        {
            get
            {
                int address = tasks[index];
                return cache[address];
            }
            set { throw new NotImplementedException(); }
        }

        public override int Count
        {
            get { return tasks.Count; }
        }

        public override bool IsFixedSize
        {
            get { return false; }
        }

        public override IEnumerator GetEnumerator()
        {
            return new TaskListEnumerator(this);
        }

        class TaskListEnumerator : IEnumerator
        {
            public TaskListEnumerator(TaskListHelper aParent)
            {
                parent = aParent;
            }

            private int pos = -1;
            private TaskListHelper parent;

            #region IEnumerator Members

            public bool MoveNext()
            {
                pos++;
                return pos < parent.tasks.Count;
            }

            public void Reset()
            {
                pos = -1;
            }

            public object Current
            {
                get
                {
                    return parent[pos];
                }
            }

            #endregion
        }
    }
}
