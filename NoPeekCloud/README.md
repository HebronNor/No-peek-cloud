# No Peek Cloud
Latest **release, with binary files**, can be found [here](https://github.com/HebronNor/NoPeekCloud/releases).

## What is No Peek Cloud?
No Peek Cloud lets you select folder on your local computer that you want to encrypt, when combined with a cloud service this provides a secure backup solution.
Source folders can be scanned periodically or every time a change is detected. [7-Zip](http://www.7-zip.org/) is used for compression and encryption.

## Screenshots
<img src="https://y1mjva.bn1303.livefilestore.com/y2pllgFU0igL_4TdVzfHj9C-bgkNrEdFvhnw2qP_JHuT9m6rrwIKnbQmfgj5ozRPDUylaUvgnMYydBDm-tiHWfjHjTdSaznW6dSJ14wDbbJUzU/NoPeekClound_Screenshot2.png?psid=1" width="400">
&nbsp;&nbsp;
<img src="https://y1mjva.bn1302.livefilestore.com/y2plAJOlltSNKdtL7SZ8m0ddpn24eh8Gvqe_76-szNAuS-zPVPi1ALOGyb59IhtH_uWBLoI5bvbuRa91QeTJUy-fXzK51NyJdxBW7eSfrL78Cg/NoPeekClound_Screenshot1.png?psid=1" width="400">
&nbsp;&nbsp;
<img src="https://y1mjva.bn1301.livefilestore.com/y2per0cHc_bCFePDcwgyJXsFUAhMIId2PZvt1cb3m8friwaijhDQQUmLcjL3DIU_cwjxRcgOleZOzRchWUafXKoXFSw5Ebg8vHBlcTj4RtgKEI/NoPeekClound_Screenshot3.png?psid=1" width="400">

## Installation
No installation is required; simply unpack the release binary files (`NoPeekCloud_vX.X.X.zip`) to a folder of your choosing.

### Requirements
* 7-Zip
* Windows 7
* .NET Framework 4.5

## Upgrade
To upgrade your version of NoPeekCloud; unpack the release binary files (`NoPeekCloud_vX.X.X.zip`) to the folder containing your current version. Some files will be overwritten, but your library and configuration will not be affected.
Make sure NoPeekCloud is not running during the upgrade.

## File library
Your file library is stored in `FileDetails.xml`, this file is not affected when upgrading to a new version.

### File library backups
Every time you synchronize a backup of your library is stored as `FileDetails.bak`.

#### Restore backup
First make sure NoPeekCloud is not running, delete your current `FileDetails.xml` file. Then rename `FileDetails.bak` to `FileDetails.xml`
When starting NoPeekCloud your library will now have been restored to your backup.

## Command-line arguments
* Open application minimized: `NoPeekCloud.exe /Min`
* Synchronize when started: `NoPeekCloud.exe /Sync`
* Synchronize and exit when started: `NoPeekCloud.exe /SyncAndExit`

## Issues
The application is still work in progress so there may be bugs. Please report all bugs to the issue tracker on this repository ([here](https://github.com/HebronNor/NoPeekCloud/issues)).
