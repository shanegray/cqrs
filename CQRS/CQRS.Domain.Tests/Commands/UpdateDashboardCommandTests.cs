﻿using CQRS.Domain.Commands;
using CQRS.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Commands
{
    [TestFixture]
    public class UpdateDashboardCommandTests
    {                 
        [Test]
        public void Execute_UpdatesToContext()
        {
            var dashboard = new Dashboard { Title = "dsdf" };
            var sut = new UpdateDashboardCommand(dashboard);
            var cmdHelper = new CommandHelper<Dashboard>();

            sut.Execute(cmdHelper.DbContext);

            cmdHelper.DbContextMock.Verify(x => x.Update(dashboard), Times.Once());
        }

        [Test]
        public void Sut_IsInstanceOfBaseDashboardCommand()
        {
            var sut = new UpdateDashboardCommand(new Dashboard());
            Assert.IsInstanceOf<BaseDashboardCommand>(sut);
        }
    }
}
