// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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
            engine = IDEApplication.Instance.Engine;
            groupBox.Text = engine.Warriors[aWarriorIndex].Name + " by " +
                            engine.Warriors[aWarriorIndex].Author;
            view = new TaskListCoreView(engine, aWarriorIndex);
            coreList.View = view;
            coreList.Attach(engine);
            coreList.PaintNextInstruction = true;
        }

        public void RepaintView()
        {
            IRunningWarrior rw = engine.RunningWarriors[warriorIndex];
            textBoxTasks.Text = rw.TasksCount + "/" + rw.DeadTasksCount;
            if (rw.PrevInstruction != null)
                textBoxLastInstruction.Text = rw.PrevInstruction.ToString();
            else
                textBoxLastInstruction.Text = null;

            view.Update();
            if (engine.NextWarriorIndex == warriorIndex)
            {
                coreList.NextIndex = 0;
            }
            else
            {
                coreList.NextIndex = -1;
            }
            
            coreList.RepaintView();
        }

        private int warriorIndex;
        private IAsyncEngine engine;
        private TaskListCoreView view;
    }

    class TaskListCoreView : ICoreBindingView
    {
        public TaskListCoreView(IAsyncEngine aEngine, int aWarriorIndex)
        {
            warriorIndex = aWarriorIndex;
            engine = aEngine;
            Update();
        }

        private IAsyncEngine engine;
        private int warriorIndex;
        private List<int> tasks=new List<int>();
        public void Update()
        {
            IRunningWarrior rw = engine.RunningWarriors[warriorIndex];
            tasks.Clear();
            foreach (int task in rw.Tasks)
            {
                tasks.Add(task);
            }
        }

        public int this[int index]
        {
            get
            {
                return tasks[index];
            }
        }

        public int Count
        {
            get { return tasks.Count; }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }
    }
}
