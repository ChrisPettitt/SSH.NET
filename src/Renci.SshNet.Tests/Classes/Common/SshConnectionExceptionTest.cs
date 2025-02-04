﻿using System;
using System.Runtime.Serialization;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Tests.Common;

namespace Renci.SshNet.Tests.Classes.Common
{
    /// <summary>
    ///This is a test class for SshConnectionExceptionTest and is intended
    ///to contain all SshConnectionExceptionTest Unit Tests
    ///</summary>
    [TestClass]
    public class SshConnectionExceptionTest : TestBase
    {
        /// <summary>
        ///A test for SshConnectionException Constructor
        ///</summary>
        [TestMethod]
        public void SshConnectionExceptionConstructorTest()
        {
            var target = new SshConnectionException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SshConnectionException Constructor
        ///</summary>
        [TestMethod]
        public void SshConnectionExceptionConstructorTest1()
        {
            var message = string.Empty; // TODO: Initialize to an appropriate value
            var target = new SshConnectionException(message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SshConnectionException Constructor
        ///</summary>
        [TestMethod]
        public void SshConnectionExceptionConstructorTest2()
        {
            var message = string.Empty; // TODO: Initialize to an appropriate value
            var disconnectReasonCode = new DisconnectReason(); // TODO: Initialize to an appropriate value
            var target = new SshConnectionException(message, disconnectReasonCode);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SshConnectionException Constructor
        ///</summary>
        [TestMethod]
        public void SshConnectionExceptionConstructorTest3()
        {
            var message = string.Empty; // TODO: Initialize to an appropriate value
            var disconnectReasonCode = new DisconnectReason(); // TODO: Initialize to an appropriate value
            Exception inner = null; // TODO: Initialize to an appropriate value
            var target = new SshConnectionException(message, disconnectReasonCode, inner);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetObjectData
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void GetObjectDataTest()
        {
            var target = new SshConnectionException(); // TODO: Initialize to an appropriate value
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            var context = new StreamingContext(); // TODO: Initialize to an appropriate value
            target.GetObjectData(info, context);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
