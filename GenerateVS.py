import os
import subprocess


def Generate():
    subprocess.run(["vendor/premake/premake5.exe", "--file=src/premake5.lua", "vs2022"])

if __name__ == "__main__":
    Generate()
    input("Press Enter to continue...")
