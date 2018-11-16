using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Payforthub.RNPayforthub
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPayforthubModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPayforthubModule"/>.
        /// </summary>
        internal RNPayforthubModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPayforthub";
            }
        }
    }
}
