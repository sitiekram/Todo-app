using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Xunit;

namespace Todo_app.Tests.DataTests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonIdTest()
        {
            PersonSequencer.PersonId = 0;
            Assert.Equal(0, PersonSequencer.PersonId);
            Assert.Equal(1, PersonSequencer.NextPersonId());
            Assert.Equal(2, PersonSequencer.NextPersonId());
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.NextPersonId();
            PersonSequencer.Reset();
            Assert.Equal(0, PersonSequencer.PersonId);
        }
    }
}
