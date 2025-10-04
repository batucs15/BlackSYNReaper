BlackSYNReaper
WARNING: This tool is for ethical cybersecurity testing only. Use it ONLY on systems you own or have explicit permission to test. Misuse is illegal, and the author is not responsible for any misuse or damage.
Description
BlackSYNReaper is a C# SYN flood DDoS testing tool by batucs15. It sends TCP SYN packets to a target IP and port using multiple threads to stress-test network systems. Designed for educational and security testing purposes in controlled environments, this tool helps evaluate system resilience against denial-of-service (DoS) attacks.
Features

Configurable target IP, port, and thread count for tailored testing.
Asynchronous SYN flood implementation for high-performance stress testing.
Sleek ASCII art banner for a killer interface 😎.
Open-source under the MIT License.

Requirements

.NET Core or .NET Framework (6.0+ recommended).
A target system with a running service (e.g., a web server on port 80).
Explicit permission to test the target system.

Installation

Clone the repository:git clone https://github.com/batucs15/BlackSYNReaper.git
cd BlackSYNReaper


Verify .NET is installed:dotnet --version


Run the tool:
dotnet run



Usage

Launch the program:dotnet run


Follow the prompts:
Target IP: Enter the IP address of the system to test (e.g., a local server).
Target Port: Specify the service port (e.g., 80 for HTTP).
Number of Threads: Choose the number of concurrent connections (e.g., 30 for moderate stress).


The tool initiates a SYN flood, sending TCP SYN packets to the target.
Monitor the target system’s performance using tools like:sudo apt install htop
htop
sudo apt install tcpdump
sudo tcpdump -i <interface> port 80


Stop the test with Ctrl+C when finished.

Ethical Use

DO NOT use this tool on systems without explicit permission. Unauthorized use is illegal and unethical.
Intended for educational and ethical testing only.
Always obtain written consent from the system owner before testing.

License
Licensed under the MIT License. See the LICENSE file for details.
Disclaimer
The author, batucs15, is not responsible for any misuse or damage caused by this tool. Use responsibly.
