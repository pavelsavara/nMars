using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void 
JMN_A_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_A_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrA;
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_B_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrA;
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_AB_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_BA_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_F_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_X_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
bool reg_jump;
reg_AdrA = ip;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ImAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_AdrA = ip;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_DiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = reg_direct;
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_BpAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesB[reg_direct]);
inc(ref ValuesB[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AiAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_AmAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApIm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB = ValuesB[ip];
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_AdrA;
int reg_AB_Value = ValuesA[ip];
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApDi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AB_Value = ValuesA[reg_direct];
reg_IR_ValueB = ValuesB[reg_direct];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApBi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApBm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesB[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApBp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesB[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesB[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApAi
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApAm
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + dec(ref ValuesA[reg_direct]));
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
        public void 
JMN_I_ApAp
(int ip, EngineWarrior warrior)
        {
int reg_IR_ValueB;
int reg_IR_ValueCpyA = ValuesA[ip];
int reg_IR_ValueCpyB = ValuesB[ip];
int reg_AdrA;
int reg_AdrB;
int reg_AB_Value;
int reg_direct;
bool reg_jump;
reg_direct = mod(reg_IR_ValueCpyA + ip);
reg_AdrA = mod(reg_direct + ValuesA[reg_direct]);
inc(ref ValuesA[reg_direct]);
reg_direct = mod(reg_IR_ValueCpyB + ip);
reg_AdrB = mod(reg_direct + ValuesA[reg_direct]);
reg_AB_Value = ValuesA[reg_AdrB];
reg_IR_ValueB = ValuesB[reg_AdrB];
inc(ref ValuesA[reg_direct]);
reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);

                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;
warrior.Tasks.Enqueue(mod(ip));
        }
    }
}
