using nMars.RedCode;
using nMars.Engine;
namespace nMars.Fngine.Fngine
{
    public partial class Fngine
    {
        public void DJN_A_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_A_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_B_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_AB_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_BA_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_F_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_X_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ImAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_DiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_BpAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AiAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_AmAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApIm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApDi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApBi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApBm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApBp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApAi(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApAm(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

        public void DJN_I_ApAp(int ip, EngineWarrior warrior)
        {


            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
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
                    
jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;
if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;

                warrior.Tasks.Enqueue(mod(ip));
        }

    }
}
