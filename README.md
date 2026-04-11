# Aonaran

Apps to download and package assets for Minecraft to be run on computers without internet.

## Disclaimer

This is not an official Minecraft product.
This project is in no way affiliated or endorsed by Microsoft or Mojang AB.

# How to use

## Archiving Minecraft

To create an archive, Aonaran Archiver is required.
The archiver must be built manually at the moment.

1. Open Aonaran Archiver
2. Select the desired Minecraft Versions
3. Click "Create Archive"
4. Wait for the Archiver to show the status  
   "Task:   Nothing"
6. Click "Open Output"

The result is a folder "aoarchive" and/or the file "aoarchive.zip"

## Running Minecraft

Coming soon...

## Building the Apps

### Windows

Requires Visual Studio 2026

1. Clone the repository  
`git clone https://github.com/businessma-n/Aonaran.git`
2. Open the .slnx file in Visual Studio (not VS Code)
3. In the top bar, press "Build Solution"

### Mac / Linux

No Mac / Linux apps at the moment

# TODO

### Windows

- Archiver
  - [x] Assets, libraries, and clients
  - [x] Mojang runtimes
  - [ ] Adoptium runtimes
  - [x] Compression
  - [ ] Forge
  - [ ] Fabric
- Launcher
  - [ ] Create instances
  - [ ] Start instances
  - [ ] Authentication

 ### Mac / Linux
  - Archiver
    - [ ] Assets, libraries, and clients
    - [ ] Mojang runtimes
    - [ ] Adoptium Runtimes
    - [ ] Compression
    - [ ] Forge
    - [ ] Fabric
  - Launcher
    - [ ] Create instances
    - [ ] Start instances
    - [ ] Authentication
