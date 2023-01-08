using CorgEng.EntityComponentSystem.Events.Events;
using CorgEng.EntityComponentSystem.Systems;
using CorgEng.GenericInterfaces.EntityComponentSystem;
using CorgEng.GridMovement.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgEng.GridMovement.Systems
{
    internal class GridMovementSystem : ProcessingSystem
    {

        /// <summary>
        /// Runs only on the server host.
        /// </summary>
        public override EntitySystemFlags SystemFlags => EntitySystemFlags.HOST_SYSTEM;

        /// <summary>
        /// Process delay is the minimum delay we specify in our grid movement components.
        /// </summary>
        protected override int ProcessDelay { get; } = 1;

        public override void SystemSetup()
        {
            RegisterLocalEvent<GridMovementComponent, ComponentAddedEvent>(OnComponentAdded);
        }

        private void OnComponentAdded(IEntity entity, GridMovementComponent gridMovementComponent, ComponentAddedEvent componentAddedEvent)
        {
            // The component that was added was some other component that isn't relevant to us.
            if (componentAddedEvent.Component != gridMovementComponent)
                return;
            // Determine if we need to change the update rate of our process by taking the lowest common multiple
            if (!gridMovementComponent.SingleSteps && (ProcessDelay % gridMovementComponent.MoveDelay != 0))
            {
                // An update to the process delay is required
                throw new NotImplementedException("Do this tomorrow.");
            }
        }

    }
}
