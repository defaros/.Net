CryptAPI Version 3.0
by Elmar Langholz (langholz@gmail.com)

to use crypt API just copy the CryptAPI.dll in bin into your 
current path or in your library path.

to build the dist just type "nant" in the source directory or
use the scripts provided for windows and linux.

Fixes for version 3.0:
* Changed license from GPL to BSD.
* Added AssemblyInfo.cs for versioning.

Fixes for version 2.2:

* Yannick Hamon reported a bug in MD5.cs in which 3 characters from the encryption 
  string were removed before processing them
* Removed a declared but unused variable in ValidateHash.cs

Fixes for version 2.1:

* Yannick Hamon reported a bug in LM.cs that affected passwords that have 14 characters
* Fixed missing file in winbuild.bat
* Fixed missing file in linbuild
