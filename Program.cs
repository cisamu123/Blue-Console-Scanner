using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAJGen;
using SimpleTCP;

namespace Blue_Console_Scanner___BCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("       * *    *   *    *  BLUE CONSOLE SCANNER *   *   *    *     *");
            Console.WriteLine("  *  *    *   *     *     *    BY CISAMU  *   *    *         *");
            Console.WriteLine("     *   *      *   *    *     (c) 2022   *      *    *    *     *  ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("                         Press any key to continue");
            Console.WriteLine("                         CTRL + C == EXIT SOFTWARE");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                BCS_CONSOLE();
            }
        }
        private static void BCS_CONSOLE() {
            Console.Clear();
            Console.WriteLine("BLUE CONSOLE SCANNER [VERSION 1.0.0.0]:");
            Console.WriteLine("WRITE: READ (FOR DOCUMENTATION)");
            Console.Write("BCS CONSOLE >>> ");
            String UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "INFO":
                    Console.Clear();
                    Console.WriteLine("Getting information about BCS...");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Gmail support (Contact): cisamusuppo@gmail.com");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("My GitHub: https://github.com/cisamu123");
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "READ":
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("[1] Command: START (for starting processes)");
                    Console.WriteLine("[2] Command: INFO (for get more info about project and developer)");
                    Console.WriteLine("[3] Command: GEN-RANDOM (for generate random string or int)");
                    Console.WriteLine(" [4] Command: CHAT (So good function :) You can chat with your friend\n and other peoples using it. \n Instruction: Select a choose whether you will be the server part or the client part,\n if the server part: you need to listen on the port, and the client needs to connect through the same program\n only as the client part and connect to the host that you open :)");
                    Console.WriteLine("[5] Command: READ (for read this)");
                    Console.WriteLine("[6] Command: ERR-CODES (for get information about all error codes)");
                    Console.WriteLine("[7] Command: BCS (launching a new copy of the BCS interpreter)");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Thanks for using it :)");
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "START":
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Enter process to start (with file extension): ");
                    String StartProcess = Console.ReadLine();
                    Console.WriteLine("----------------------------------------------");
                    try
                    {
                        Process.Start(StartProcess);
                        Console.WriteLine(StartProcess + " = STARTED SUCCESFULY!");
                    }
                    catch
                    {
                        Console.WriteLine(" Oops... The process does not start due to an unknown error.\n The reason may be the absence of a file or the file cannot be accessed \n Error Code: EPBCS = x0000001");
                        Console.WriteLine(" ----------------------------------------------");
                    }
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "GEN-RANDOM":
                    RandomGen rnd = new RandomGen();
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Your random: " + rnd.Gen());
                    Console.WriteLine("\n" + "----------------------------------------------");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "SMILE":
                    Console.Clear();
                    Console.WriteLine("░░░░░░░░░░░███████░░░░░░░░░░░");
                    Console.WriteLine("░░░░░░░████░░░░░░░████░░░░░░░");
                    Console.WriteLine("░░░░░██░░░░░░░░░░░░░░░██░░░░░");
                    Console.WriteLine("░░░██░░░░░░░░░░░░░░░░░░░██░░░");
                    Console.WriteLine("░░█░░░░░░░░░░░░░░░░░░░░░░░█░░");
                    Console.WriteLine("░█░░████░░░░░░░░██████░░░░░█░");
                    Console.WriteLine("█░░█░░░██░░░░░░█░░░░███░░░░░█");
                    Console.WriteLine("█░█░░░░░░█░░░░░█░░░░░░░█░░░░█");
                    Console.WriteLine("█░█████████░░░░█████████░░░░█");
                    Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
                    Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
                    Console.WriteLine("█░░░████████████████████░░░░█");
                    Console.WriteLine("░█░░░█▓▓▓▓▓▓▓▓█████▓▓▓█░░░░█░");
                    Console.WriteLine("░█░░░░█▓▓▓▓▓██░░░░██▓██░░░░█░");
                    Console.WriteLine("░░█░░░░██▓▓█░░░░░░░▒██░░░░█░░");
                    Console.WriteLine("░░░██░░░░██░░░░░░▒██░░░░██░░░");
                    Console.WriteLine("░░░░░██░░░░███████░░░░██░░░░░");
                    Console.WriteLine("░░░░░░░███░░░░░░░░░███░░░░░░░");
                    Console.WriteLine("░░░░░░░░░░█████████░░░░░░░░░░");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "CHAT":
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Choose through which part you will connect to the interlocutor (Write 1-2):");
                    Console.WriteLine("\n" + "----------------------------------------------");
                    Console.WriteLine("[1] Server");
                    Console.WriteLine("[2] Client");
                    String ConnectionInput = Console.ReadLine();
                    switch (ConnectionInput)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("----------------------------------------------");
                                Console.Write("WELCOME SERVER! WRITE PORT TO LISTEN:");
                                Console.WriteLine("\n" + "----------------------------------------------");
                                String ServerPortListen = Console.ReadLine();
                                Console.WriteLine("Server Started.");
                                Console.Write("WRITE YOUR NICKNAME: ");
                                String NickNameServer = Console.ReadLine();

                                var server = new SimpleTcpServer();
                                Console.Clear();

                                server.ClientConnected += (sender, e) =>
                                Console.WriteLine($"Client ({e.Client.RemoteEndPoint}) connected!");

                                server.ClientDisconnected += (sender, e) =>
                                Console.WriteLine($"Client ({e.Client.RemoteEndPoint}) disconnected!");
                                server.DataReceived += (sender, e) =>
                                {
                                    var ep = e.TcpClient.Client.RemoteEndPoint;
                                    var msg = Encoding.UTF8.GetString(e.Data);
                                    Console.WriteLine($"Received message from {ep}: \"{msg}\".");
                                    Console.WriteLine("WRITE YOUR REPLY: ");
                                    Console.WriteLine("WARNING: PRESS ENTER BEFORE WRITING A MESSAGE OR IT WILL BE BLANK!");
                                    String ReplyByServer = Console.ReadLine();
                                    e.Reply(NickNameServer + ": " + ReplyByServer);
                                };
                                server.Start(Convert.ToInt32(ServerPortListen));

                                while (1 < 2)
                                {
                                    Console.ReadLine();
                                }
                            }
                            catch
                            {
                                Console.WriteLine(" Oops... THE CHAT DID NOT START DUE TO AN UNKNOWN ERROR, \n YOU MIGHT HAVE ENTERED A WRONG IP ADDRESS OR PORT! \n OR THERE IS NO SUCH SERVER PART! \n Error Code: EPBCS = x0000002");
                            }
                            break;
                        case "2":
                            try
                            {
                                Console.WriteLine("----------------------------------------------");
                                Console.Write("WELCOME CLIENT! WRITE IP TO CONNECT:");
                                Console.WriteLine("\n" + "----------------------------------------------");
                                String ClientIpConnect = Console.ReadLine();
                                Console.WriteLine("----------------------------------------------");
                                Console.Write("WRITE PORT TO LISTEN:");
                                Console.WriteLine("\n" + "----------------------------------------------");
                                String ClientPortConnect = Console.ReadLine();
                                Console.WriteLine("WARNING! ALWAYS WRITE ONE MESSAGE UNTIL YOU WAIT FOR A REPLY OR THE MESSAGE WILL BE CLOSED AND CHAT WILL NOT WORK CORRECTLY!");
                                Console.WriteLine("Chat with server.");
                                Console.Write("WRITE YOUR NICKNAME: ");
                                String NickNameClient = Console.ReadLine();
                                var client = new SimpleTcpClient();
                                Console.Clear();

                                client.DataReceived += (sender, e) =>
                                {
                                    var msg = Encoding.UTF8.GetString(e.Data);
                                    Console.WriteLine($"Received message: \"{msg}\".");
                                };
                                client.Connect(ClientIpConnect, Convert.ToInt32(ClientPortConnect));
                                while (1 < 2)
                                {
                                    Console.Write($"Write message:");
                                    String writed = Console.ReadLine();
                                    client.Write(Encoding.UTF8.GetBytes(NickNameClient + ": " + writed));
                                }
                            }
                            catch
                            {
                                Console.WriteLine(" ----------------------------------------------");
                                Console.WriteLine(" Oops... THE CHAT DID NOT START DUE TO AN UNKNOWN ERROR, \n YOU MIGHT HAVE ENTERED A WRONG IP ADDRESS OR PORT! \n OR THERE IS NO SUCH SERVER PART! \n Error Code: EPBCS = x0000002");
                                Console.WriteLine(" ----------------------------------------------");
                            }
                            break;
                    }
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "ERR-CODES":
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("ERROR CODE: EPBCS = x0000001 == The process does not start due to an unknown error.\n The reason may be the absence of a file or the file cannot be accessed");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("ERROR CODE: EPBCS = x0000002 == THE CHAT DID NOT START DUE TO AN UNKNOWN ERROR, \n YOU MIGHT HAVE ENTERED A WRONG IP ADDRESS OR PORT! \n OR THERE IS NO SUCH SERVER PART!");
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "BCS":
                    Process.Start("Blue Console Scanner - BCS.exe");
                    break;
            }
        }
    }
}
