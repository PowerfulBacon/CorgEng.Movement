
# Grid Movement

Implements player movement to an entity, allowing it to move to different locations using clamped locations.
(Movement is discrete as oppossed to continuous.)

This is useful for games using cell-based player movement (Games like SS13 or dwarf fortress where players
are bound to the center of grid cells).

## Dependencies

 - Requires CorgEng.EntityComponentSystem as it uses the Component class defined inside of it.
 - Requires CorgEng.GenericInterfaces and some implementation of the dependencies defined within it. See the
CorgEng project for default implementations of these dependencies, however feel free to create your own if those
are not sufficient for your needs.
