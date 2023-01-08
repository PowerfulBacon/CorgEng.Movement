using CorgEng.EntityComponentSystem.Components;
using CorgEng.GenericInterfaces.Pathfinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgEng.GridMovement.Components
{
    public class GridMovementComponent : Component
    {

        /// <summary>
        /// The tester used to determine if we can enter a location from another
        /// location.
        /// </summary>
        public virtual IPathCellQueryer CellBlockedTester { get; set; }

        /// <summary>
        /// If true then we can only take a single step at a time and cannot
        /// hold down a key to continue moving.
        /// </summary>
        public virtual bool SingleSteps { get; set; } = false;

        /// <summary>
        /// The delay between each cell movement.
        /// </summary>
        public virtual double MoveDelay { get; set; } = 0.2;

        /// <summary>
        /// The last time that we performed a move at
        /// </summary>
        internal double lastMoveTime { get; set; }

    }
}
