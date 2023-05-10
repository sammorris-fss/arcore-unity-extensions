//-----------------------------------------------------------------------
// <copyright file="ResolveAnchorOnRooftopResult.cs" company="Google LLC">
//
// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace Google.XR.ARCoreExtensions
{
    using System;
    using Google.XR.ARCoreExtensions.Internal;
    using UnityEngine;
    using UnityEngine.XR.ARSubsystems;

    /// <summary>
    /// Contains the result of a <c><see cref="ResolveAnchorOnRooftopPromise"/></c>.
    /// </summary>
    public class ResolveAnchorOnRooftopResult
    {
        private ARGeospatialAnchor _anchor;
        private RooftopAnchorState _state;

        internal ResolveAnchorOnRooftopResult()
        {
            _state = RooftopAnchorState.None;
            _anchor = null;
        }

        internal ResolveAnchorOnRooftopResult(RooftopAnchorState state, ARGeospatialAnchor anchor)
        {
            _state = state;
            _anchor = anchor;
        }

        /// <summary>
        /// Gets the <c>RooftopAnchorState</c> associated with this result.
        /// </summary>
        public RooftopAnchorState RooftopAnchorState
        {
            get
            {
                return _state;
            }
        }

        /// <summary>
        /// Gets the <c>ARGeospatialAnchor</c> associated with this result. May be <c>null</c>.
        /// </summary>
        public ARGeospatialAnchor Anchor
        {
            get
            {
                return _anchor;
            }
        }
    }
}
