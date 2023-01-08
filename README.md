# CorgEng.Movement

Modular player movement modules for the CorgEng game engine. This project exists to save time making generic components that most games will use, mostly so I can develop games faster during game jams.
With enough of these modules, they can work like building blocks, quickly getting an extremely basic but functional foundation for any game.

This does not currently support networking due to the input handler being in the process of being refactored, and not currently having a demand for networked games (Our networking is too unstable right now and requires too much work).

TODO:
 - [ ] Setup the input handler to support networking properly, update this project to accomodate networking projects once that has been completed.

## Setting Up

In order to setup this project, the CorgEng repository needs to be downloaded. Once that is downloaded, place it into a directly alongside this project.
```
C:/Example/CorgEng
C:/Example/CorgEng.Movement
```
You may need to restore nuget in order to obtain the dependencies of CorgEng. See the ReadMe in https://github.com/PowerfulBacon/CorgEng for more details.

## Using

Adding these modules to a CorgEng project works like any other module.
Right click on the project you wish to add the module to, and select Add project reference.

![image](https://user-images.githubusercontent.com/26465327/211218662-d37b08e8-30e3-444b-9eb9-7c6c5d438d78.png)

Add the project as a reference.

![image](https://user-images.githubusercontent.com/26465327/211218733-6c179d35-143f-47de-a358-ec7e51036c4e.png)

Next, add the movement module you are using to the CorgEngConfig.xml file.

```xml
<CorgEngConfig>
  <!--Specify which modules we need to load dynamically-->
  <DependencyModules>
    <Module>CorgEng.GridMovement</Module>
  </DependencyModules>
</CorgEngConfig>
```

See the example project in the CorgEng project for more details about this.

You may now use the components specified in the added modules by adding them to any entity, either with `entity.AddComponent(...);` or by adding it in a content file.

## Dependencies

CorgEng is required to use this project, as well as any dependencies required by CorgEng. Place these repositories alongside each other and alongside your game project.

![image](https://user-images.githubusercontent.com/26465327/211218899-bbe1cc3f-4dea-4ae4-97c9-386a52e9d53d.png)

