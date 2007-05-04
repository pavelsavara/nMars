using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void 
SUB_A_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_A_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_B_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_AB_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AA_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_BA_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_DiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpBp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_BpAp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_AmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApBp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_F_ApAp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_DiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpBp
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
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_BpAp
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
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_AmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApBp
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
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_X_ApAp
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
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_AA_Value;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ValuesA[reg_AdrB] = reg_AB_Value - reg_IR_ValueA;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value = ValuesA[ip];
reg_IR_ValueA = reg_IR_ValueB;
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrB;
int reg_AA_Value = ValuesA[ip];
int reg_AB_Value;
int reg_direct;
reg_IR_ValueA = reg_IR_ValueB;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueA;
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrB;
int reg_AA_Value;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_DiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AA_Value = ValuesA[reg_direct];
reg_IR_ValueA = ValuesB[reg_direct];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpBp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_BpAp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AiAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmBp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_AmAp
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApIm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_AdrB = ip;
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApDi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = reg_direct;
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApBi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApBm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApBp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApAi
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApAm
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
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_AA_Value = ValuesA[reg_AdrA];
reg_IR_ValueA = ValuesB[reg_AdrA];
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
SUB_I_ApAp
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
ValuesA[reg_AdrB] = reg_AB_Value - reg_AA_Value;
if (ValuesA[reg_AdrB] < 0) ValuesA[reg_AdrB] += coreSize;
ValuesB[reg_AdrB] = reg_IR_ValueB - reg_IR_ValueA;
if (ValuesB[reg_AdrB] < 0) ValuesB[reg_AdrB] += coreSize;
ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
    }
}
