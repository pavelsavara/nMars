using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void 
DIV_A_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
bool reg_die = false;
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_A_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_B_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
bool reg_die = false;
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_AB_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_BA_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_F_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_X_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }
        }
        public void 
DIV_I_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
bool reg_die = false;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
if (reg_AA_Value == 0) reg_die = true;
else ValuesA[reg_AdrB] = reg_AB_Value / reg_AA_Value;
if (reg_IR_ValueA == 0) reg_die = true;
else ValuesB[reg_AdrB] = reg_IR_ValueB / reg_IR_ValueA;
ip++;

                if (!reg_die)
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
