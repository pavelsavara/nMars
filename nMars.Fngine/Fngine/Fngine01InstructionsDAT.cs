using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void 
DAT_A_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_A_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_B_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_AB_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_BA_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_F_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_X_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiIm
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiDi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiBi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiAi
(int ip, EngineWarrior warrior)
        {
bool reg_die;
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
dec(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesB[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
dec(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DAT_I_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_direct;
bool reg_die;
reg_direct = mod(reg_IR_ValueCpyA + ip);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
inc(ref ValuesA[reg_direct]);
reg_die = true;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
    }
}
