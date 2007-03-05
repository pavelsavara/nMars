using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void STP_A_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_A_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_B_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_AB_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_BA_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_F_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_X_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    reg_AdrA = ip;
                    reg_IR_ValueA = reg_IR_ValueB;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AA_Value = ValuesA[direct];
                    reg_IR_ValueA = ValuesB[direct];
                    reg_AdrA = direct;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesB[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesB[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesB[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + (--ValuesA[direct]));
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    reg_AdrB = ip;
                    reg_IR_ValueB = reg_IR_ValueB;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AB_Value = ValuesA[direct];
                    reg_IR_ValueB = ValuesB[direct];
                    reg_AdrB = direct;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesB[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesB[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesB[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + (--ValuesA[direct]));
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void STP_I_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;

                    direct = mod(reg_IR_ValueACpy + ip);
                    reg_AdrA = mod(direct + ValuesA[direct]);
                    reg_AA_Value = ValuesA[reg_AdrA];
                    reg_IR_ValueA = ValuesB[reg_AdrA];
                    ValuesA[direct]++;
                    

                    direct = mod(reg_IR_ValueBCpy + ip);
                    reg_AdrB = mod(direct + ValuesA[direct]);
                    reg_AB_Value = ValuesA[reg_AdrB];
                    reg_IR_ValueB = ValuesB[reg_AdrB];
                    ValuesA[direct]++;
                    

                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);
ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

    }
}
